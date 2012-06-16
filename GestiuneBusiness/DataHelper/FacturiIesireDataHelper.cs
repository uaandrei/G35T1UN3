using System;
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
            this.selectAllStoredProcedureName = "sp_FacturiIesire_SelectAll";
            this.insertStoredProcedureName = "sp_FacturiIesire_Insert";
            this.updateStoredProcedureName = "sp_FacturiIesire_Update";
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
