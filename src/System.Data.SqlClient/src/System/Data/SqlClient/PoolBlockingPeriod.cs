using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SqlClient
{
    public enum PoolBlockingPeriod
    {
        Auto = 0,         // Blocking period OFF for Azure SQL servers, but ON for all other SQL servers.
        AlwaysBlock = 1,  // Blocking period ON for all SQL servers including Azure SQL servers.    
        NeverBlock = 2,   // Blocking period OFF for all SQL servers including Azure SQL servers.
    }
}
