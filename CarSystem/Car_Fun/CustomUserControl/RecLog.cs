using System;
using System.IO;

namespace Car_Fun
{
    public class RecLog
    {
        /// <summary>
        /// 出錯紀錄
        /// </summary>
        /// <param name="ErrEx">錯誤訊息</param>
        /// <param name="ErrAp">類別</param>
        public void ExLog(Exception ErrEx, string ErrAp)
        {
            object obj2 = new object();
            string path = @"C:\CarSystem\RecLog\";
            string str2 = string.Empty;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + "ErrLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            str2 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "," + ErrAp + "," + ErrEx.ToString();
            lock (obj2)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(str2, true);
                    writer.Close();
                }
            }
        }

        static object obj2 = new object();
        /// <summary>
        /// 紀錄Log
        /// </summary>
        /// <param name="ErrAp">類別</param>
        /// <param name="Msg">訊息</param>
        public void ExLog(string ErrAp, string Msg)
        {
            string path = @"C:\CarSystem\RecLog\";
            string str2 = string.Empty;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + "ErrLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            str2 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "," + ErrAp + "," + Msg;
            lock (obj2)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(str2, true);
                    writer.Close();
                }
            }
        }
    }
}
