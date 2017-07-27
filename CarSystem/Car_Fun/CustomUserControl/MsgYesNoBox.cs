using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Fun
{
    public partial class MsgYesNoBox : Form
    {

        public bool blYesNo = new bool();
        public MsgYesNoBox()
        {
            InitializeComponent();
        }

        private void MsgYesNoBox_Load(object sender, EventArgs e)
        {
            btn_Yes.MyColor = this.BackColor;
            btn_No.MyColor = this.BackColor;
            timer1.Start();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            blYesNo = true;
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            blYesNo = false;
            this.Close();
        }

        #region 10秒鐘關閉視窗
        int timeCount = 10;
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
                btn_No.PerformClick();
            }
            else
            {
                lbl_TimeCount.Text = timeCount.ToString();
            }
        }
        #endregion
    }
}
