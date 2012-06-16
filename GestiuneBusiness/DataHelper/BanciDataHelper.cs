using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class BanciDataHelper : GestiuneDataHelper
    {
        private static BanciDataHelper banciDataHelper = null;

        public static BanciDataHelper GetInstance()
        {
            if (banciDataHelper == null) banciDataHelper = new BanciDataHelper();
            return banciDataHelper;
        }

        private BanciDataHelper()
        {
            this.readStoredProcedureName = "BanciRead";
            this.insertStoredProcedureName = "BanciCreate";
            this.updateStoredProcedureName = "BanciUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new Banca
            {
                ID = (int)reader[0],
                Nume = reader[1].ToString(),
                Adresa = reader[2].ToString(),
                Cui = reader[3].ToString(),
                RC = reader[4].ToString(),
                CapitalSocial = (decimal)reader[5]
            };
        }
    }
}
