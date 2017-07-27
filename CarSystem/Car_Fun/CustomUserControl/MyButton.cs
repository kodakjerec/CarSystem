using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Fun
{
    public partial class myButton : System.Windows.Forms.Button
    {
        private bool mouseover = false;//鼠標經過
        public Color MyColor = Color.Transparent;

        public myButton()
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //在這裏用自己的方法來繪製Button的外觀(其實也就是幾個框框)
            Graphics g = e.Graphics;
            g.Clear(MyColor);
            Rectangle rect = e.ClipRectangle;
            rect = new Rectangle(rect.X, rect.Y, rect.Width - 1, rect.Height - 2);
            Point Location = new Point(rect.X, rect.Y);
            
            //g.ReleaseHdc();
            if (mouseover)
            {
                if (Focused)
                {
                    Util_GDI.DrawRoundButton(this.Font, this.Text, g, rect, buttonStyle.ButtonFocuseAndMouseOver);
                    return;
                }
                Util_GDI.DrawRoundButton(this.Font, this.Text, g, rect, buttonStyle.ButtonMouseOver);
                return;
            }
            if (Focused)
            {
                Util_GDI.DrawRoundButton(this.Font, this.Text, g, rect, buttonStyle.ButtonFocuse);
                return;
            }
            if (!Enabled)
            {
                Util_GDI.DrawRoundButton(this.Font, this.Text, g, rect, buttonStyle.ButtonEnableFalse);
                return;
            }
            Util_GDI.DrawRoundButton(this.Font, this.Text, g, rect, buttonStyle.ButtonNormal);
        }

        public void ChangeBkColor(Color color)
        {
            PaintEventArgs e = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);
            MyColor = color;
            OnPaint(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            mouseover = true;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            mouseover = false;
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// 複寫Click
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            Button button1 = this;
            int x = button1.Width, AfterX = Convert.ToInt32(x * 1.2);
            int y = button1.Height, AfterY = Convert.ToInt32(y * 1.2);
            int Xpos = button1.Location.X, AfterXpos = Xpos - (AfterX - x) / 2;
            int Ypos = button1.Location.Y, AfterYpos = Ypos - (AfterY - y) / 2;
            float OriFontSize = button1.Font.Size, AfterFontSize = Convert.ToSingle(button1.Font.Size * 1.2);
            Color OriColor_Fore = button1.ForeColor, OriColor_Back = SystemColors.ButtonFace;
            //Change
            //button1.Size = new Size(AfterX, AfterY);
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Font = new Font(button1.Font.FontFamily, AfterFontSize, FontStyle.Bold);
            //button1.Location = new Point(AfterXpos, AfterYpos);

            //Refresh
            button1.Refresh();
            System.Threading.Thread.Sleep(300);

            //Re-Change
            //button1.Size = new Size(x, y);
            button1.BackColor = OriColor_Back;
            button1.ForeColor = OriColor_Fore;
            button1.Font = new Font(button1.Font.FontFamily, OriFontSize, FontStyle.Regular);
            //button1.Location = new Point(Xpos, Ypos);

            base.OnClick(e);
        }
    }
}
