using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
            public static readonly string connectionString = @"Data Source=DESKTOP-PL3944K\SQLEXPRESS;Initial Catalog=MovieTest;Integrated Security=True";
            public static readonly SqlConnection dbconn = new SqlConnection(connectionString);

            private static SqlCommand dbCmd;

            private static void Open()
            {
                if (dbconn.State.ToString().CompareTo("Open") != 0)
                    dbconn.Open();
            }

            public static void Close()
            {
                dbconn.Close();
            }

            public static SqlCommand GetDbCommand(string sql)
            {
                if (dbconn.State.ToString().CompareTo("Open") != 0)
                    Open();
                if (dbCmd == null)
                {
                    dbCmd = new SqlCommand(sql, dbconn);
                }
                dbCmd.CommandText = sql;
                return dbCmd;
            }
        }
}
