﻿using System;
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
            this.selectAllStoredProcedureName = "sp_Produse_SelectAll";
            this.insertStoredProcedureName = "sp_Produse_Insert";
            this.updateStoredProcedureName = "sp_Produse_Update";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Produs
            {
                ID = (int)reader[0],
                Nume = reader[1].ToString(),
                StocMinim = (decimal)reader[2],
                Pret = (decimal)reader[3],
                Um = reader[4].ToString()
            };
        }
    }
}
