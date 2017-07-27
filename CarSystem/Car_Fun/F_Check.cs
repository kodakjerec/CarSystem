using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Fun
{
    public class F_Check
    {
        /// <summary>
        /// WMS加密
        /// </summary>
        /// <param name="Psw"></param>
        /// <returns></returns>
        public long PasswdValue(string Psw)
        {
            int i = 0;
            string s1 = null;
            long pswdval = 0;
            int[] primary = new int[9];

            primary[0] = 1;
            primary[1] = 521;
            primary[2] = 89;
            primary[3] = 607;
            primary[4] = 127;
            primary[5] = 79;
            primary[6] = 101;
            primary[7] = 107;
            primary[8] = 43;

            if (Psw.Length > 8)
            {
                Psw = Psw.Substring(0, 8);
            }
            pswdval = 0;
            for (i = 1; i <= Psw.Length; i++)
            {
                s1 = Psw.Substring(i - 1, 1);
                pswdval = pswdval + Convert.ToInt32(Convert.ToChar(s1)) * Convert.ToInt64(primary[i]);
            }
            return pswdval;
        }
    }
}
