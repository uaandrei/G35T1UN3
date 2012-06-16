using System;
using System.Linq;
using GestiuneBusiness.Poco;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class DelegatiDataHelper : GestiuneDataHelper
    {
        private DelegatiDataHelper()
        {
            this.selectAllStoredProcedureName = "sp_Delegati_SelectAll";
            this.insertStoredProcedureName = "sp_Delegati_Insert";
            this.updateStoredProcedureName = "sp_Delegati_Update";
        }

        private static DelegatiDataHelper delegatiDataHelper = null;

        public static DelegatiDataHelper GetInstance()
        {
            if (delegatiDataHelper == null)
            {
                delegatiDataHelper = new DelegatiDataHelper();
            }
            return delegatiDataHelper;
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new Delegat
            {
                ID = (int)reader[0],
                Cnp = reader[1].ToString(),
                Serie = reader[2].ToString(),
                Nume = reader[3].ToString()
            };
        }
    }
}
