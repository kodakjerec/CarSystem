using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Fun
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            ResizeForm.WSC_Resize(this, 1.1);
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            btn_Submit.MyColor = this.BackColor;

            timer1.Start();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 10秒鐘關閉視窗
        public int timeCount = 10;
        public void timeCountSet(int intTimeCount)
        {
            timeCount = intTimeCount;
            lbl_TimeCount.Text = timeCount.ToString();
            lbl_timecount_memo.Location = new Point(lbl_TimeCount.Location.X + lbl_TimeCount.Width + 5, lbl_timecount_memo.Location.Y);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount--;
            if (timeCount <= 0)
            {
                btn_Submit.PerformClick();
            }
            else
            {
                lbl_TimeCount.Text = timeCount.ToString();
            }
        }
        #endregion
    }
}
