using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class PozitiiFacturiIntrareDataHelper : GestiuneDataHelper
    {
        private static PozitiiFacturiIntrareDataHelper pozitiiFacturiIntrareDataHelper = null;

        public static PozitiiFacturiIntrareDataHelper GetInstance()
        {
            if (pozitiiFacturiIntrareDataHelper == null) pozitiiFacturiIntrareDataHelper = new PozitiiFacturiIntrareDataHelper();
            return pozitiiFacturiIntrareDataHelper;
        }

        private PozitiiFacturiIntrareDataHelper()
        {
            this.insertStoredProcedureName = "sp_Plati_Insert";
            this.selectAllStoredProcedureName = "sp_Plati_SelectAll";
            this.updateStoredProcedureName = "sp_Plati_Update";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.PozitieFacturaIntrare
            {
                ID = (int)reader[0],
                IdFacturaIntrare = (int)reader[1],
                IdProdus = (int)reader[2],
                Cantitate = (decimal)reader[3],
                PretUnitar = (decimal)reader[4]
            };
        }
    }
}
