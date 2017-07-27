using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;

namespace Car_Fun
{
    public partial class Keyboard_Number : Form
    {
        public Control ParentControl = new Control();   //依照呼叫物件判斷位置
        Point OriginLocation = new Point();         //原始位置
        object PreClick = null;     //前一個按下的按鈕

        //取得呼叫的視窗
        IntPtr iptr = new IntPtr();
        public Keyboard_Number()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 此處用於取得計算機視窗的控制碼
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        /// <summary>
        /// 此處用於向視窗發送消息
        /// </summary>
        /// <param name="hWnd">視窗代碼</param>
        /// <param name="Msg">視窗控制代碼</param>
        /// <param name="wParam">傳送指令A</param>
        /// <param name="lParam">傳送指令B</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// 此處用於將視窗設置在最前
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hWndInsertAfter"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="uFlags"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        //視窗置於最前方
        public static void SetWindowPos(IntPtr hWnd)
        {
            //方法一
            //SetWindowPos(hWnd, -1, 0, 0, 0, 0, 0X0003);
            //方法二
            SetForegroundWindow(hWnd);
        }

        protected override CreateParams CreateParams
        {

            get
            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= (int)0x08000000L;

                return cp;

            }

        }

        private void Keyboard_Number_Load(object sender, EventArgs e)
        {
            iptr = (IntPtr)this.Tag;

            //保證在最上層，才不會關閉鍵盤以後重開就消失
            //因為車機主程式本身就是TopMost
            this.TopMost = true;

            //調整視窗大小
            #region 更改視窗彈出位置
            int StartX = 0, StartY = 0;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width,
                ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            //X座標
            StartX = ScreenWidth - this.Width;

            //Y座標
            StartY = ScreenHeight - this.Height;

            //呼叫元件的位置, 決定小視窗出現點
            if ( (ParentControl.Location.X+ParentControl.Width) > (ScreenWidth / 2))
            { 
                //元件在螢幕右半邊
                StartX = 0;
            }

            this.Location = new Point(StartX, StartY);
            OriginLocation = this.Location;
            #endregion
        }

        private void Keyboard_Number_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                //前一個按鈕還原
                if (PreClick != null)
                {
                    Button Preobj = PreClick as Button;
                    Preobj.BackColor = SystemColors.Control;
                }
                PreClick = null;
            }
        }

        #region 按鈕動作
        //數字鍵
        private void btnNumber_Click(object sender, EventArgs e)
        {
            SetWindowPos(iptr);
            SendKeys.Send(((Button)sender).Tag.ToString());
            ShowTip(sender);
        }
        //離開
        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Location = OriginLocation;
            //SetWindowPos(iptr);
            //SendKeys.Send("^A");
            //SendKeys.Send("{BACKSPACE}");
            //ShowTip(sender);
        }
        //Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            SetWindowPos(iptr);
            SendKeys.Send("{Enter}");
            ShowTip(sender);
            Thread.Sleep(100);
            btnLeave.PerformClick();
        }
        //按下按鈕的提示視窗
        void ShowTip(object sender)
        {
            //前一個按鈕還原
            if (PreClick != null)
            {
                Button Preobj = PreClick as Button;
                Preobj.BackColor = SystemColors.Control;
            }

            PreClick = sender;

            //現在按鈕變暗
            Button obj = sender as Button;
            obj.BackColor = SystemColors.ControlDark;
        }
        #endregion

        #region 拖曳視窗位置
        private Point startPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //當滑鼠擊點到Form1控制項的範圍內時，紀錄目前是窗的位置
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //如果使用者使用的是左鍵按下，意旨使用右鍵拖曳無效
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                //新視窗的位置
                mousePos.Offset(startPoint.X, startPoint.Y);
                //改變視窗位置
                Location = mousePos;
            }
        }
        #endregion
    }
}
