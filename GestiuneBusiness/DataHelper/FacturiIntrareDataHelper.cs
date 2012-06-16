using System;
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
            this.selectAllStoredProcedureName = "sp_FacturiIntrare_SelectAll";
            this.insertStoredProcedureName = "sp_FacturiIntrare_Insert";
            this.updateStoredProcedureName = "sp_FacturiIntrare_Update";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new FacturaIntrare
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
