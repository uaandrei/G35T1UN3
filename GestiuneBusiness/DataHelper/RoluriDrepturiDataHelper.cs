using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class RoluriDrepturiDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static RoluriDrepturiDataHelper roluriDrepturiDataHelper = null;

        private RoluriDrepturiDataHelper()
        {
            this.insertStoredProcedureName = "sp_Roluri_Drepturi_Insert";
            this.updateStoredProcedureName = "sp_Roluri_Drepturi_Update";
            this.selectAllStoredProcedureName = "sp_Roluri_Drepturi_SelectAll";
        }

        public static RoluriDrepturiDataHelper GetInstance()
        {
            if (roluriDrepturiDataHelper == null)
            {
                roluriDrepturiDataHelper = new RoluriDrepturiDataHelper();
            }
            return roluriDrepturiDataHelper;
        }
        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Administration.RolDrept
            {
                ID = (int)reader[0],
                IdRol = (int)reader[1],
                IdDrept = (int)reader[2],
                AreDrept = (bool)reader[3]
            };
        }
    }
}
