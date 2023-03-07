namespace 鼾声检测产测激活工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_COM = new System.Windows.Forms.TextBox();
            this.button_COM = new System.Windows.Forms.Button();
            this.textBox_UARTLOG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_APIKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SERVER = new System.Windows.Forms.TextBox();
            this.pictureBox_CHART = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_ACT = new System.Windows.Forms.Button();
            this.label_TODAY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_REMAIN = new System.Windows.Forms.Label();
            this.label_SUM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_STATUS = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_MAX = new System.Windows.Forms.TextBox();
            this.textBox_MIN = new System.Windows.Forms.TextBox();
            this.button_TEST = new System.Windows.Forms.Button();
            this.label_CUSTOM = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CHART)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_COM
            // 
            this.textBox_COM.Location = new System.Drawing.Point(12, 10);
            this.textBox_COM.Name = "textBox_COM";
            this.textBox_COM.Size = new System.Drawing.Size(56, 21);
            this.textBox_COM.TabIndex = 0;
            this.textBox_COM.Text = "COM4";
            // 
            // button_COM
            // 
            this.button_COM.Location = new System.Drawing.Point(74, 9);
            this.button_COM.Name = "button_COM";
            this.button_COM.Size = new System.Drawing.Size(75, 23);
            this.button_COM.TabIndex = 1;
            this.button_COM.Text = "连接串口";
            this.button_COM.UseVisualStyleBackColor = true;
            this.button_COM.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // textBox_UARTLOG
            // 
            this.textBox_UARTLOG.Location = new System.Drawing.Point(16, 269);
            this.textBox_UARTLOG.Multiline = true;
            this.textBox_UARTLOG.Name = "textBox_UARTLOG";
            this.textBox_UARTLOG.Size = new System.Drawing.Size(325, 221);
            this.textBox_UARTLOG.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "波形";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "厂商API KEY";
            // 
            // textBox_APIKEY
            // 
            this.textBox_APIKEY.Location = new System.Drawing.Point(119, 71);
            this.textBox_APIKEY.Name = "textBox_APIKEY";
            this.textBox_APIKEY.Size = new System.Drawing.Size(269, 21);
            this.textBox_APIKEY.TabIndex = 5;
            this.textBox_APIKEY.Text = "FC0A1D0C6446BF77";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "激活用服务器地址";
            // 
            // textBox_SERVER
            // 
            this.textBox_SERVER.Location = new System.Drawing.Point(119, 31);
            this.textBox_SERVER.Name = "textBox_SERVER";
            this.textBox_SERVER.Size = new System.Drawing.Size(269, 21);
            this.textBox_SERVER.TabIndex = 7;
            this.textBox_SERVER.Text = "http://121.40.62.199";
            // 
            // pictureBox_CHART
            // 
            this.pictureBox_CHART.Location = new System.Drawing.Point(16, 79);
            this.pictureBox_CHART.Name = "pictureBox_CHART";
            this.pictureBox_CHART.Size = new System.Drawing.Size(325, 117);
            this.pictureBox_CHART.TabIndex = 9;
            this.pictureBox_CHART.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "日志";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button_ACT);
            this.groupBox1.Controls.Add(this.label_TODAY);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label_REMAIN);
            this.groupBox1.Controls.Add(this.label_SUM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_APIKEY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SERVER);
            this.groupBox1.Location = new System.Drawing.Point(368, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 503);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "激活";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 244);
            this.listBox1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "激活日志";
            // 
            // button_ACT
            // 
            this.button_ACT.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ACT.Location = new System.Drawing.Point(280, 121);
            this.button_ACT.Name = "button_ACT";
            this.button_ACT.Size = new System.Drawing.Size(108, 64);
            this.button_ACT.TabIndex = 14;
            this.button_ACT.Text = "激活";
            this.button_ACT.UseVisualStyleBackColor = true;
            this.button_ACT.Click += new System.EventHandler(this.button_ACT_Click);
            // 
            // label_TODAY
            // 
            this.label_TODAY.AutoSize = true;
            this.label_TODAY.Location = new System.Drawing.Point(117, 181);
            this.label_TODAY.Name = "label_TODAY";
            this.label_TODAY.Size = new System.Drawing.Size(11, 12);
            this.label_TODAY.TabIndex = 13;
            this.label_TODAY.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "今日激活数";
            // 
            // label_REMAIN
            // 
            this.label_REMAIN.AutoSize = true;
            this.label_REMAIN.Location = new System.Drawing.Point(117, 147);
            this.label_REMAIN.Name = "label_REMAIN";
            this.label_REMAIN.Size = new System.Drawing.Size(11, 12);
            this.label_REMAIN.TabIndex = 11;
            this.label_REMAIN.Text = "0";
            // 
            // label_SUM
            // 
            this.label_SUM.AutoSize = true;
            this.label_SUM.Location = new System.Drawing.Point(117, 115);
            this.label_SUM.Name = "label_SUM";
            this.label_SUM.Size = new System.Drawing.Size(11, 12);
            this.label_SUM.TabIndex = 10;
            this.label_SUM.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "剩余LIC数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "已经激活总数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_STATUS);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox_MAX);
            this.groupBox2.Controls.Add(this.textBox_MIN);
            this.groupBox2.Controls.Add(this.button_TEST);
            this.groupBox2.Controls.Add(this.pictureBox_CHART);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_UARTLOG);
            this.groupBox2.Location = new System.Drawing.Point(5, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 503);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // button_STATUS
            // 
            this.button_STATUS.BackColor = System.Drawing.Color.Green;
            this.button_STATUS.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_STATUS.ForeColor = System.Drawing.Color.White;
            this.button_STATUS.Location = new System.Drawing.Point(16, 206);
            this.button_STATUS.Name = "button_STATUS";
            this.button_STATUS.Size = new System.Drawing.Size(325, 45);
            this.button_STATUS.TabIndex = 16;
            this.button_STATUS.Text = "PASS";
            this.button_STATUS.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "最大值";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "最小值";
            // 
            // textBox_MAX
            // 
            this.textBox_MAX.Location = new System.Drawing.Point(173, 49);
            this.textBox_MAX.Name = "textBox_MAX";
            this.textBox_MAX.Size = new System.Drawing.Size(70, 21);
            this.textBox_MAX.TabIndex = 13;
            this.textBox_MAX.Text = "10000";
            this.textBox_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_MIN
            // 
            this.textBox_MIN.Location = new System.Drawing.Point(173, 22);
            this.textBox_MIN.Name = "textBox_MIN";
            this.textBox_MIN.Size = new System.Drawing.Size(70, 21);
            this.textBox_MIN.TabIndex = 12;
            this.textBox_MIN.Text = "1000";
            this.textBox_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_TEST
            // 
            this.button_TEST.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TEST.Location = new System.Drawing.Point(266, 22);
            this.button_TEST.Name = "button_TEST";
            this.button_TEST.Size = new System.Drawing.Size(75, 48);
            this.button_TEST.TabIndex = 11;
            this.button_TEST.Text = "测试";
            this.button_TEST.UseVisualStyleBackColor = true;
            this.button_TEST.Click += new System.EventHandler(this.button_TEST_Click);
            // 
            // label_CUSTOM
            // 
            this.label_CUSTOM.AutoSize = true;
            this.label_CUSTOM.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CUSTOM.Location = new System.Drawing.Point(711, 17);
            this.label_CUSTOM.Name = "label_CUSTOM";
            this.label_CUSTOM.Size = new System.Drawing.Size(51, 20);
            this.label_CUSTOM.TabIndex = 19;
            this.label_CUSTOM.Text = "客户";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(801, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(352, 472);
            this.listBox2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "UART RAW LOG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 83);
            this.button1.TabIndex = 21;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label_CUSTOM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_COM);
            this.Controls.Add(this.textBox_COM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MIAN 鼾声检测";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CHART)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_COM;
        private System.Windows.Forms.Button button_COM;
        private System.Windows.Forms.TextBox textBox_UARTLOG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_APIKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SERVER;
        private System.Windows.Forms.PictureBox pictureBox_CHART;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_ACT;
        private System.Windows.Forms.Label label_TODAY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_REMAIN;
        private System.Windows.Forms.Label label_SUM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_STATUS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_MAX;
        private System.Windows.Forms.TextBox textBox_MIN;
        private System.Windows.Forms.Button button_TEST;
        private System.Windows.Forms.Label label_CUSTOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

