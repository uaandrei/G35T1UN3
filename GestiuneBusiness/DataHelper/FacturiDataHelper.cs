using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class FacturiDataHelper : GestiuneDataHelper
    {
        private static FacturiDataHelper facturiDataHelper = null;

        public static FacturiDataHelper GetInstance()
        {
            if (facturiDataHelper == null) facturiDataHelper = new FacturiDataHelper();
            return facturiDataHelper;
        }

        private FacturiDataHelper()
        {
            this.readStoredProcedureName = "FacturiRead";
            this.insertStoredProcedureName = "FacturiCreate";
            this.updateStoredProcedureName = "FacturiUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new Factura
            {
                ID = int.Parse(reader[0].ToString()),
                Serie = reader[1].ToString(),
                Numar = reader[2].ToString(),
                Data = DateTime.Parse(reader[3].ToString()),
                Tip = reader[4].ToString(),
                IdFirma = int.Parse(reader[5].ToString())
            };
        }
    }
}
