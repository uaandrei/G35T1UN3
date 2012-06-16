﻿using System;
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
                ID = (int)reader[0],
                Nume = reader[1].ToString(),
                Cui = reader[2].ToString(),
                Rc = reader[3].ToString(),
                Iban = reader[4].ToString(),
                Adresa = reader[5].ToString(),
                Telefon = reader[6].ToString(),
                DataInfiintarii = (DateTime)reader[7],
                IdBanca = (int)reader[8],
                IdDelegat = (int)reader[9]
            };
        }
    }
}
