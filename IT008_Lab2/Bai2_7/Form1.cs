using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_7
{
    public partial class Form1 : Form
    {
        int hour, min, sec;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NowTimer_Tick(object sender, EventArgs e)
        {
            NowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            int now = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int till = hour * 3600 + min * 60 + sec;


            if (k == 1)
            {
                int remain = till - now;
                if (till < now)
                {
                    remain = 24 * 3600 - now + till;
                }

                if (remain == 0)
                {
                    CountDown.Text = "00:00:00";
                    Process.Start("shutdown", "/s /t 0");
                }
                CountDown.Text = string.Format("{0}:{1}:{2}", (remain / 3600).ToString().PadLeft(2, '0'), ((remain - (remain / 3600) * 3600) / 60).ToString().PadLeft(2, '0'), (remain % 60).ToString().PadLeft(2, '0'));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NowTimer.Interval = 1000;
            NowTimer.Start();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (HourBox.Text == "")
            {
                hour = 0;
                HourBox.Text = "0";
            }
            if (MinBox.Text == "")
            {
                min = 0;
                MinBox.Text = "0";
            }
            if (SecBox.Text == "")
            {
                sec = 0;
                SecBox.Text = "0";
            }
            bool Num1 = int.TryParse(HourBox.Text, out hour);
            if (!Num1)
            {
                MessageBox.Show("Wrong type of hour", "Wrong Type");
            }
            else if (hour < 0 || hour >= 24)
            {
                MessageBox.Show("Hour cannot be that number", "Wrong number");
            }
            else
                s = s + 1;
            bool Num2 = int.TryParse(MinBox.Text, out min);
            if (!Num2)
            {
                MessageBox.Show("Wrong type of minute", "Wrong Type");
            }
            else if (min < 0 || min > 59)
            {
                MessageBox.Show("Minute cannot be that number", "Wrong number");
            }
            else
                s = s + 1;
            bool Num3 = int.TryParse(SecBox.Text, out sec);
            if (!Num3)
            {
                MessageBox.Show("Wrong type of Second", "Wrong Type");
            }
            else if (sec < 0 || sec > 59)
            {
                MessageBox.Show("Second cannot be that number", "Wrong number");
            }
            else
                s = s + 1;
            if (s == 3)
            {
                SetTime.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                k = 1;
            }
        }

        private void UnSetButton_Click(object sender, EventArgs e)
        {
            k = 0;
            CountDown.Text = "00:00:00";
            SetTime.Text = "00:00:00";
            HourBox.Text = "";
            MinBox.Text = "";
            SecBox.Text = "";
        }
    }
}
