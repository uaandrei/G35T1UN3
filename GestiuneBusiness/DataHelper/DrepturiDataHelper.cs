using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class DrepturiDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static DrepturiDataHelper drepturiDataHelper = null;

        private DrepturiDataHelper()
        {
            this.insertStoredProcedureName = "sp_Drepturi_Insert";
            this.selectAllStoredProcedureName = "sp_Drepturi_SelectAll";
            this.updateStoredProcedureName = "sp_Drepturi_Update";
        }

        public static DrepturiDataHelper GetInstance()
        {
            if (drepturiDataHelper == null) drepturiDataHelper = new DrepturiDataHelper();
            return drepturiDataHelper;
        }

        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Administration.Drept
            {
                ID = (int)reader[0],
                Descriere = reader[1].ToString(),
                AreDrept = (bool)reader[2]
            };
        }
    }
}
