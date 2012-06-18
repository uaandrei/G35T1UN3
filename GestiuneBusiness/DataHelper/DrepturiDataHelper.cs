using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class DrepturiDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static DrepturiDataHelper drepturiDataHelper = null;

        private DrepturiDataHelper()
        {
            this.selectAllStoredProcedureName = "sp_Drepturi_SelectAll";
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
                Nume = reader[1].ToString(),
                Descriere = reader[2].ToString()
            };
        }
    }
}
