using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Car_Fun
{
    public static class F_Msg_static
    {
        public static void messageshow(string Msg)
        {
            MsgBox msg = new MsgBox();
            msg.timeCountSet(65535);
            msg.lbl_Msg.Text = Msg;
            if (msg.lbl_Msg.PreferredHeight >= 170)
                msg.Height = msg.lbl_Msg.PreferredHeight + 50;
            msg.ShowDialog();
        }

    }
}
