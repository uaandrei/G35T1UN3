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
            this.selectAllStoredProcedureName = "sp_Stoc_SelectAll";
            this.insertStoredProcedureName = "sp_Stoc_Insert";
            this.updateStoredProcedureName = "sp_Stoc_Update";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Stoc
            {
                ID = (int)reader[0],
                IdProdus = (int)reader[1],
                Pret = (decimal)reader[2],
                IdPozitieFacturaIntrare = (int)reader[3]
            };
        }
    }
}
