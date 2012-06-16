using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class PozitiiFacturiIesireDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static PozitiiFacturiIesireDataHelper pozitiiFacturiIesireDataHelper = null;

        public static PozitiiFacturiIesireDataHelper GetInstance()
        {
            if (pozitiiFacturiIesireDataHelper == null) pozitiiFacturiIesireDataHelper = new PozitiiFacturiIesireDataHelper();
            return pozitiiFacturiIesireDataHelper;
        }

        private PozitiiFacturiIesireDataHelper()
        {
            this.insertStoredProcedureName = "sp_Plati_Insert";
            this.selectAllStoredProcedureName = "sp_Plati_SelectAll";
            this.updateStoredProcedureName = "sp_Plati_Update";
        }

        protected override GestiuneObject ToPocoObject(System.Data.SqlClient.SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.PozitieFacturaIesire
            {
                ID = (int)reader[0],
                IdFacturaIesire = (int)reader[1],
                IdStoc = (int)reader[2],
                Cantitate = (decimal)reader[3],
                PretUnitar = (decimal)reader[4]
            };
        }
    }
}
