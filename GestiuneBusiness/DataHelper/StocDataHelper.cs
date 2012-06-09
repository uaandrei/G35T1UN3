using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class StocDataHelper : GestiuneDataHelper
    {
        private static StocDataHelper stocDataHelper = null;

        public static StocDataHelper GetInstance()
        {
            if (stocDataHelper == null) stocDataHelper = new StocDataHelper();
            return stocDataHelper;
        }

        private StocDataHelper()
        {
            this.readStoredProcedureName = "StocRead";
            this.insertStoredProcedureName = "StocCreate";
            this.updateStoredProcedureName = "StocUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Stoc
            {
                ID = int.Parse(reader[0].ToString()),
                IdProdus = int.Parse(reader[1].ToString()),
                Cantitate = decimal.Parse(reader[2].ToString()),
                IdFacturaIntrare = int.Parse(reader[3].ToString())
            };
        }
    }
}
