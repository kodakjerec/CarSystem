using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Fun
{
    public class F_LogIn
    {
        //工號
        //長度限制:varchar(10)
        private static string _UserID;
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        //人員
        private static string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        //權限
        private static string _Autgid;
        public string Autgid
        {
            get { return _Autgid; }
            set { _Autgid = value; }
        }

        //登入IP
        private static string _IP;
        public string IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        //登入時間
        private static DateTime _LogDate;
        public DateTime LogDate
        {
            get { return _LogDate; }
            set { _LogDate = value; }
        }

        //登入主機
        private static string _DBName;
        public string DBName
        {
            get { return _DBName; }
            set { _DBName = value; }
        }

        //登入電腦名稱
        //長度限制:varchar(20)
        private static string _ComputerName;
        public string ComputerName
        {
            get { return _ComputerName; }
            set { _ComputerName = value; }
        }
    }
}
