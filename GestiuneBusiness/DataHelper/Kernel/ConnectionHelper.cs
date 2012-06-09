using System;
using System.Linq;
using System.Data.SqlClient;

namespace GestiuneBusiness.DataHelper.Kernel
{
    internal static class ConnectionHelper
    {
        internal static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(@"Data Source=ADI\SQLEXPRESS;Initial Catalog=Gestiune;Persist Security Info=True;User ID=sa;Password=1q2w3e4r;");
            }
        }
    }
}
