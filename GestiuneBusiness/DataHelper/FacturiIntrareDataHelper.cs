using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class FacturiIntrareDataHelper : GestiuneDataHelper
    {
        private static FacturiIntrareDataHelper facturiIntrareDataHelper = null;

        public static FacturiIntrareDataHelper GetInstance()
        {
            if (facturiIntrareDataHelper == null) facturiIntrareDataHelper = new FacturiIntrareDataHelper();
            return facturiIntrareDataHelper;
        }

        private FacturiIntrareDataHelper()
        {
            this.readStoredProcedureName = "FacturiRead";
            this.insertStoredProcedureName = "FacturiCreate";
            this.updateStoredProcedureName = "FacturiUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new FacturaIesire
            {
                ID = (int)reader[0],
                Serie = reader[1].ToString(),
                Numar = reader[2].ToString(),
                Data = (DateTime)reader[3],
                IdFirma = (int)reader[4]
            };
        }
    }
}
