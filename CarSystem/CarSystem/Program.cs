using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Car_Fun;
using System.Drawing;
using System.Threading;
using System.ComponentModel;

namespace CarSystem
{
    static class Program
    {
        static F_Msg fMsg = new F_Msg();

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //處理未捕捉的例外
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //處理UI執行緒錯誤
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //非處理UI執行緒錯誤
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Form6_2_v2());
        }

        //處理UI執行緒錯誤
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string msg;
            Exception err = e.Exception as Exception;
            if (err != null)
            {
                if (err.Message.Contains("無法存取伺服器"))
                {
                    msg = "網路連線失敗，請離開目前作業重新操作\n";
                }
                else if (err.Message.Contains("逾時"))
                {
                    msg = "網路連線逾時";
                }
                else if (err.Message.Contains("信號交換"))
                {
                    msg = "網路連線逾時";
                }
                else
                {
                    msg = "發生應用程式例外，請離開目前作業重新操作\n並聯絡資訊部車機處理人員\n";
                }
            }
            else
            {
                msg = "發生應用程式例外，請離開目前作業重新操作\n並聯絡資訊部車機處理人員\n";
            }
            WhenException_Then_SnapShot();
            RecLog reclog = new RecLog();
            reclog.ExLog(err, "01");
            fMsg.messageshow(msg);
            
        }

        //非處理UI執行緒錯誤
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string msg;
            Exception err = e.ExceptionObject as Exception;
            if (err != null)
            {
                if (err.Message.Contains("無法存取伺服器"))
                {
                    msg = "網路連線失敗，請離開目前作業重新操作\n";
                }
                else if (err.Message.Contains("逾時"))
                {
                    msg = "網路連線逾時";
                }
                else if (err.Message.Contains("信號交換"))
                {
                    msg = "網路連線逾時";
                }
                else
                {
                    msg = "發生應用程式例外，請離開目前作業重新操作\n並聯絡資訊部車機處理人員\n";
                }
            }
            else
            {
                msg = string.Format("Application UnhandleException，請離開目前作業重新操作\n並聯絡資訊部車機處理人員:{0}", e);
            }
            WhenException_Then_SnapShot();
            RecLog reclog = new RecLog();
            reclog.ExLog(err, "02");
            fMsg.messageshow(msg);
        }

        //發生例外錯誤,自動抓圖存檔
        static void WhenException_Then_SnapShot()
        {
            Bitmap myImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            string FileName = @"C:\CarSystem\RecLog\"
                +"ErrPic_"+DateTime.Now.ToString("yyyyMMddHHmmss")+".jpg";
            myImage.Save(FileName); 
        }
    }
}
