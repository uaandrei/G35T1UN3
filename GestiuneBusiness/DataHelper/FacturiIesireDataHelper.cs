using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class FacturiIesireDataHelper : GestiuneDataHelper
    {
        private static FacturiIesireDataHelper facturiIesireDataHelper = null;

        public static FacturiIesireDataHelper GetInstance()
        {
            if (facturiIesireDataHelper == null) facturiIesireDataHelper = new FacturiIesireDataHelper();
            return facturiIesireDataHelper;
        }

        private FacturiIesireDataHelper()
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
