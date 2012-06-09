using System;
using System.Data.SqlClient;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco;

namespace GestiuneBusiness.DataHelper
{
    internal class FacturaProdusStocDataHelper : GestiuneDataHelper
    {
        private static FacturaProdusStocDataHelper facturaProdusStocDataHelper = null;

        private FacturaProdusStocDataHelper()
        {
            this.insertStoredProcedureName = "Facturi_Produse_StocCreate";
        }

        public static FacturaProdusStocDataHelper GetInstance()
        {
            if (facturaProdusStocDataHelper == null) facturaProdusStocDataHelper = new FacturaProdusStocDataHelper();
            return facturaProdusStocDataHelper;
        }

        protected override Poco.Kernel.GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new FacturaProdusStoc
            {
                FacturaObject = Factura.GetAll().Where(p => p.ID == (int)reader[0]).FirstOrDefault(),
                ProdusObject = Produs.GetAll().Where(p => p.ID == (int)reader[1]).FirstOrDefault(),
                StocObject = Stoc.GetAll().Where(p => p.ID == (int)reader[2]).FirstOrDefault(),
                Pret = (int)reader[3],
                Cantitate = (int)reader[4]
            };
        }
    }
}
