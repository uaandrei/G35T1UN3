using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class FirmeDataHelper : GestiuneDataHelper
    {
        private static FirmeDataHelper firmeDataHelper = null;

        public static FirmeDataHelper GetInstance()
        {
            if (firmeDataHelper == null) firmeDataHelper = new FirmeDataHelper();
            return firmeDataHelper;

        }

        private FirmeDataHelper()
        {
            this.readStoredProcedureName = "FirmeRead";
            this.insertStoredProcedureName = "FirmeCreate";
            this.updateStoredProcedureName = "FirmeUpdate";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Firma
            {
                ID = int.Parse(reader[0].ToString()),
                Nume = reader[1].ToString(),
                Cui = reader[2].ToString(),
                NrInmatriculare = reader[3].ToString(),
                Iban = reader[4].ToString(),
                Localitate = reader[5].ToString(),
                Judet = reader[6].ToString(),
                Adresa = reader[7].ToString(),
                Telefon = reader[8].ToString(),
                PersoanaContact = reader[9].ToString(),
                DataInfiintarii = DateTime.Parse(reader[10].ToString()),
                IdBanca = int.Parse(reader[11].ToString()),
                IdDelegat = int.Parse(reader[12].ToString())
            };
        }
    }
}
