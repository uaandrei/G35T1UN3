using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.DataHelper
{
    internal class SetareDataHelper : GestiuneBusiness.DataHelper.Kernel.GestiuneDataHelper
    {
        private static SetareDataHelper setareDataHelper = null;

        private SetareDataHelper()
        {
            this.updateStoredProcedureName = "sp_Setari_Update";
            this.selectAllStoredProcedureName = "sp_Setari_SelectAll";
        }

        public static SetareDataHelper GetInstance()
        {
            if (setareDataHelper == null) setareDataHelper = new SetareDataHelper();
            return setareDataHelper;
        }

        protected override GestiuneObject ToPocoObject(SqlDataReader reader)
        {
            return new GestiuneBusiness.Poco.Administration.Setare
            {
                AdminPassword = reader[0].ToString(),
                MyFirmaId = reader[1] == DBNull.Value?0:(int)reader[1]
            };
        }
    }
}
