using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class PlatiFacturiDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static PlatiFacturiDataHelper plataFacturaDataHelper = null;

        public static PlatiFacturiDataHelper GetInstance()
        {
            if (plataFacturaDataHelper == null) plataFacturaDataHelper = new PlatiFacturiDataHelper();
            return plataFacturaDataHelper;
        }

        private PlatiFacturiDataHelper()
        {
            this.selectAllStoredProcedureName = "sp_Plati_Facturi_SelectAll";
            this.insertStoredProcedureName = "sp_Plati_Facturi_Insert";
            this.updateStoredProcedureName = "sp_Plati_Facturi_Update";
        }

        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.PlataFactura
            {
                ID = (int)reader[0],
                IdPlata = (int)reader[1],
                IdFactura = (int)reader[2],
                TipFactura = reader[3].ToString()
            };
        }
    }
}
