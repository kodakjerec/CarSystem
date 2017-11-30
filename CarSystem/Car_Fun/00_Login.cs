using Car_IO;
using System.Collections;

namespace Car_Fun
{
    public partial class _00_Login
    {
        IO_DB IO = new IO_DB();

        public void UpdateCarSystemIP(string Login_Server, string hostname, string IP) {
            int SuccessCount = 0;
            string sql_cmd =
                    @"UPDATE [CarSystem].[dbo].CarSystemIPList
                    SET ComputerName=@hostname, UpdDate=GETDATE()
                    WHERE IP=@IP";
            Hashtable ht1 = new Hashtable();
            ht1.Add("@IP", IP);
            ht1.Add("@hostname", hostname);
            IO.SqlUpdate(Login_Server, sql_cmd, ht1, ref SuccessCount);

            if (SuccessCount == 0) {
                sql_cmd = @"Insert Into [CarSystem].[dbo].CarSystemIPList(IP,ComputerName,UpdDate) 
                            values(@IP,@hostname,GETDATE())";
                IO.SqlUpdate(Login_Server, sql_cmd, ht1, ref SuccessCount);
            }
        }
    }
}
