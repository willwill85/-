using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 鼾声检测产测激活工具
{
    static class webget
    {
        public static string get_res(string server, string para)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            try
            {
                string res = wc.DownloadString(server + para);
                return res;
            }
            catch(Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(server+para+" "+e.ToString());
                return "FAIL";
            }
        }
    }
    static class toolbox
    {
        public static byte[] get_lic_byte(string lic)
        {
            int subStringLength = 2;
            List<string> subStrings = new List<string>();
            for (int i = 0; i < lic.Length; i += subStringLength)
            {
                subStrings.Add(lic.Substring(i, Math.Min(subStringLength, lic.Length - i)));
            }
            byte[] tempbyte = new byte[subStrings.Count];
            for (int i = 0; i < subStrings.Count; i++)
            {
                tempbyte[i]= Convert.ToByte(subStrings[i], 16);
            }
            return tempbyte;
        }
    }
    class display
    {
        public static Bitmap getimage_s(int width, int height, float[] ali, Color c, int mid, int max)
        {
            Bitmap bwav = new Bitmap(width, height);
            Graphics gph = Graphics.FromImage(bwav);

            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            gph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            gph.Clear(Color.FromArgb(55, 55, 55));
            Pen pen1 = new Pen(Brushes.LightGray);
            PointF p1 = new PointF(0, 0);
            PointF p2 = new PointF(0, 0);

            int grid = 20;
            pen1.Width = 1;

            p1 = new PointF(0, 0);
            p2 = new PointF(0, 0);

            pen1.Width = 1;
            pen1.Color = c;

            for (int i = 0; i < ali.Length; i += 1)
            {
                p1 = p2;
                float x = i * width * 1.0f / ali.Length;
                float h = height / 2 - ((ali[i] * 1 + mid) * 1.0f * height / max);
                //    int h = height / 2 - (int)(ali[i]);
                p2 = new PointF(x, h + height / 2);
                gph.DrawLine(pen1, p1, p2);

                PointF p3 = new PointF(x, height);
                gph.DrawLine(pen1, p2, p3);

            }

            return bwav;

        }
    }
}
