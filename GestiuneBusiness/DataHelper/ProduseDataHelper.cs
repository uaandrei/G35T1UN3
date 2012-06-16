using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class ProduseDataHelper : GestiuneDataHelper
    {
        private static ProduseDataHelper produseDataHelper = null;

        public static ProduseDataHelper GetInstance()
        {
            if (produseDataHelper == null) produseDataHelper = new ProduseDataHelper();
            return produseDataHelper;
        }

        private ProduseDataHelper()
        {
            this.readStoredProcedureName = "ProduseRead";
            this.insertStoredProcedureName = "ProduseCreate";
            this.updateStoredProcedureName = "ProduseUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Produs
            {
                ID = (int)reader[0],
                Nume = reader[1].ToString(),
                StocMinim = (decimal)reader[2],
                Pret = (decimal)reader[3],
                RataTva = (decimal)reader[4],
                Um = reader[5].ToString()
            };
        }
    }
}
