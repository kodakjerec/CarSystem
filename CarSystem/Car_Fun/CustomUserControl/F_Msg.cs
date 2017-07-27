using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Car_Fun
{
    public class F_Msg
    {
        public bool blYesNo = new bool();

        /// <summary>
        /// 訊息視窗
        /// </summary>
        /// <param name="Msg">內容</param>
        /// <param name="Title">標題</param>
        public void messageshow(string Msg, string Title)
        {
            MsgBox msg = new MsgBox();
            msg.lbl_Msg.Text = Msg;
            if ((msg.lbl_Msg.Location.Y + msg.lbl_Msg.Height) >= (msg.Height - 50))
                msg.Height = (msg.lbl_Msg.Location.Y + msg.lbl_Msg.Height) + 50;
            msg.lbl_title.Text = Title;
            msg.ShowDialog();
        }
        public void messageshow(string Msg)
        {
            MsgBox msg = new MsgBox();
            msg.lbl_Msg.Text = Msg;
            if ((msg.lbl_Msg.Location.Y + msg.lbl_Msg.Height) >= (msg.Height-50))
                msg.Height = (msg.lbl_Msg.Location.Y + msg.lbl_Msg.Height) + 50;
            msg.ShowDialog();
        }

        /// <summary>
        /// 選擇視窗
        /// </summary>
        /// <param name="Msg">內容</param>
        /// <param name="Title">標題</param>
        /// <param name="YesNo">選用YesNo True=使用</param>
        /// <returns></returns>
        public bool messageshow(string Msg, string Title, bool YesNo)
        {
            MsgYesNoBox msgYN = new MsgYesNoBox();
            msgYN.lbl_Msg.Text = Msg;
            if ((msgYN.lbl_Msg.Location.Y + msgYN.lbl_Msg.Height) >= (msgYN.Height - 50))
                msgYN.Height = (msgYN.lbl_Msg.Location.Y + msgYN.lbl_Msg.Height) + 50;
            msgYN.lbl_title.Text = Title;
            msgYN.ShowDialog();
            blYesNo = msgYN.blYesNo;
            return blYesNo;
        }
    }
}
