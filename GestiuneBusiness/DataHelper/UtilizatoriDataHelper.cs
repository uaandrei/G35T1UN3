using System.Data.SqlClient;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class UtilizatoriDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static UtilizatoriDataHelper utilizatoriDataHelper = null;

        private UtilizatoriDataHelper()
        {
            this.insertStoredProcedureName = "sp_Utilizatori_Insert";
            this.selectAllStoredProcedureName = "sp_Utilizatori_SelectAll";
            this.updateStoredProcedureName = "sp_Utilizatori_Update";
        }

        public static UtilizatoriDataHelper GetInstance()
        {
            if (utilizatoriDataHelper == null) utilizatoriDataHelper = new UtilizatoriDataHelper();
            return utilizatoriDataHelper;
        }

        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Administration.Utilizator
            {
                ID = (int)reader[0],
                Nume = reader[1].ToString(),
                Parola = reader[2].ToString(),
                Activ = (bool)reader[3],
                IdRol = (int)reader[4]
            };
        }
    }
}
