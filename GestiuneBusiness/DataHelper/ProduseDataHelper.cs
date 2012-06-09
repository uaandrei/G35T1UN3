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
                ID = int.Parse(reader[0].ToString()),
                Nume = reader[1].ToString(),
                Pret = Decimal.Parse(reader[2].ToString()),
                RataTva = Decimal.Parse(reader[3].ToString()),
                Um = reader[4].ToString()
            };
        }
    }
}
