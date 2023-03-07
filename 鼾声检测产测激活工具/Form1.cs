using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 鼾声检测产测激活工具
{
    public partial class Form1 : Form
    {
        bool debug = false; //测试模式 or 激活模式
        string uartdata = "";
        List<float> data = new List<float>(); //缓存的数据
        const int len = 30; // 窗口长度
        int count = 0;
        public void clear_data()
        {
            data.Clear();
            for (int i = 0; i < len; i++)
                data.Add(0);
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clear_data();
            update_status();
        }
        public void update_status()
        {
            string para = "/get_info?API_KEY=" + textBox_APIKEY.Text;
            string res=webget.get_res(textBox_SERVER.Text, para);
            if (res == "FAIL")
            {
               // textBox_ACTLOG.Text += "网络错误！\n";
               //这里不单独处理了
            }
            else if (res == "-1")
            {
                //  textBox_ACTLOG.Text += "不存在这个用户！\n";
                //这里不单独处理了
            }
            else
            {
                string[] str = res.Split(',');
                label_CUSTOM.Text = str[0];
                label_SUM.Text = (int.Parse(str[1])-int.Parse(str[2])).ToString();
                label_REMAIN.Text = str[2];
                label_TODAY.Text = str[3];

            }

        }
        //连接串口
        private void button_COM_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = textBox_COM.Text;
                serialPort1.Open();
                textBox_UARTLOG.Text = "连接串口成功\n";
                byte[] data = { 0xFA, 0x02, 0x12, 0x34 };
                serialPort1.Write(data, 0, 4);
            }
            catch
            {
                textBox_UARTLOG.Text = "连接串口失败\n";
            }
        }

       //串口收到数据处理方法
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (debug)
            {
                string temp = serialPort1.ReadLine();
                //textBox_UARTLOG.Text = temp+ "\n" + textBox_UARTLOG.Text;
                try
                {
                    data.Add(float.Parse(temp));
                }
                catch
                {
                    textBox_UARTLOG.Text = "串口接收格式有问题,请检查固件\n";
                    return;
                }
                try
                {
                    int a = int.Parse(textBox_MAX.Text);
                    a = int.Parse(textBox_MIN.Text);
                }
                catch
                {
                    textBox_UARTLOG.Text = "最大，最小值输入有错误\n";
                    return;
                }
                data.RemoveAt(0);
                //显示图形
                pictureBox_CHART.Image = display.getimage_s(pictureBox_CHART.Width, pictureBox_CHART.Height, data.ToArray(), Color.Orange, 100, 30000);
                count++;
                if (count == len)
                {
                    debug = false;
                    float min = data.Min();
                    float max = data.Max();
                    byte[] data2 = { 0xFA, 0x02, 0x12, 0x34 };
                    serialPort1.Write(data2, 0, 4);

                    if (min < float.Parse(textBox_MIN.Text) && max > float.Parse(textBox_MAX.Text))
                    {
                        button_STATUS.Text = "PASS";
                        button_STATUS.BackColor = Color.Green;
                    }
                    else
                    {
                        button_STATUS.Text = "FAIL";
                        button_STATUS.BackColor = Color.Red;
                    }
                    textBox_UARTLOG.Text = DateTime.Now.ToShortTimeString() + " " + button_STATUS.Text + ": MAX: " + max + " MIN: " + min + "\r\n" + textBox_UARTLOG.Text;
                    button_ACT.Enabled = true;
                }
            }
            else
            {
                uartdata = serialPort1.ReadLine().Replace("\n","");
                listBox2.Items.Insert(0, uartdata);
            }
        }
        //测试按钮
        private void button_TEST_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                clear_data();
                debug = true;
                count = 0;
                byte[] data = { 0xFA, 0x02, 0xFD, 0x0D };
                serialPort1.Write(data, 0, 4);
                button_ACT.Enabled = false;
            }
            else
            {
                MessageBox.Show("请打开串口");
            }
        }
        //激活按钮
        private void button_ACT_Click(object sender, EventArgs e)
        {
            byte[] data = { 0xFA, 0x02, 0x12, 0x34 };
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("请打开串口");
                return;
            }
            serialPort1.Write(data, 0, 4);
            Thread.Sleep(300);
            serialPort1.Write(data, 0, 4);
            Thread.Sleep(300);

            if (uartdata.Length < 10)
            {
                listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + ":设备ID获取失败！");
                return;
            }
            if (uartdata.Length != 33)
            {
                listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + ":获取ID长度异常，请重试！");
                return;
            }
            string para = "/get_lic?API_KEY=" + textBox_APIKEY.Text+ "&DEV_ID="+ uartdata;
            string did = uartdata;
            string res=webget.get_res(textBox_SERVER.Text, para);
            if (res == "FAIL")
            {

                listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + ":网络访问失败！");
                return;
            }
            else if (res == "-1")
            {
                listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + ":厂商API_KEY错误！");
                return;
            }
            else if (res == "-2")
            {
                listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + ":余额不足需要充值！");
                return;
            }
            else
            {
                byte[] data2 = { 0xFA, 0x02, 0x56, 0x78 };
                serialPort1.Write(data2, 0, 4);
                byte[] lic = toolbox.get_lic_byte(res);
                serialPort1.Write(lic, 0, 16);
                Thread.Sleep(300);
                Console.WriteLine(uartdata);
                serialPort1.ReadExisting();
                if(uartdata.Contains("OK"))                   
                    listBox1.Items.Insert(0,  DateTime.Now.ToShortTimeString() + "设备号:"+ did + " 激活成功!");       
                else
                    listBox1.Items.Insert(0, DateTime.Now.ToShortTimeString() + "设备号:" + did + " 激活失败!!!!");
            }
            update_status();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == ">")
            {
                button1.Text = "<";
                this.Width = 1176;
            }
            else
            {
                button1.Text = ">";
                this.Width = 808;
            }

        }
    }

}
