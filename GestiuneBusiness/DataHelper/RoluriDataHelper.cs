using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class RoluriDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static RoluriDataHelper roluriDataHelper = null;

        private RoluriDataHelper()
        {
            this.insertStoredProcedureName = "sp_Roluri_Insert";
            this.selectAllStoredProcedureName = "sp_Roluri_SelectAll";
            this.updateStoredProcedureName = "sp_Roluri_Update";
        }

        public static RoluriDataHelper GetInstance()
        {
            if (roluriDataHelper == null) roluriDataHelper = new RoluriDataHelper();
            return roluriDataHelper;
        }

        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Administration.Rol
            {
                ID = (int)reader[0],
                Nume = reader[1].ToString()
            };
        }
    }
}
