using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace System.Data.SqlClient.ManualTesting.Tests
{
    public class PoolBlockPeriodTest
    {
        //static string _tcpConnStr;
        static string _tcpConnStr = "Data Source= 192.168.227.48,1433;Initial Catalog=test;UID=afsaneh;PWD=Moonshine4u ;Timeout=120";
        [CheckConnStrSetupFact]
        public static void ConnectionPool_NonMars()
        {
            //_tcpConnStr = (new SqlConnectionStringBuilder(DataTestUtility.TcpConnStr) { PoolBlockingPeriod = PoolBlockingPeriod.AlwaysBlock }).ConnectionString;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(_tcpConnStr);
            builder.PoolBlockingPeriod = PoolBlockingPeriod.AlwaysBlock;
            _tcpConnStr = builder.ConnectionString;
            // If Always block will not throw the error 
            using (SqlConnection sqlConnection = new SqlConnection(_tcpConnStr))
            {
                sqlConnection.Open();
            }
        }
    }
}
