using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class PlatiDataHelper : GestiuneDataHelper
    {
        private static PlatiDataHelper platiDataHelper = null;

        public static PlatiDataHelper GetInstance()
        {
            if (platiDataHelper == null) platiDataHelper = new PlatiDataHelper();
            return platiDataHelper;
        }

        private PlatiDataHelper()
        {
            this.readStoredProcedureName = "PlatiRead";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Plata
            {
                ID = int.Parse(reader[0].ToString()),
                Serie = reader[1].ToString(),
                Nr = int.Parse(reader[2].ToString()),
                Data = DateTime.Parse(reader[3].ToString()),
                TipPlata = reader[4].ToString()
            };
        }
    }
}
