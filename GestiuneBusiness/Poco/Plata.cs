using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Plata : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Serie { get; set; }
        public int Nr { get; set; }
        public DateTime Data { get; set; }
        public string TipPlata { get; set; }
        #endregion

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            throw new NotImplementedException();
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        public static List<Plata> GetAll()
        {
            return PlatiDataHelper.GetInstance().GetAll().Cast<Plata>().ToList();
        }

        protected override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Serie", Value = this.Serie });
                result.Add(new DbObject { Name = "@Nr", Value = this.Nr });
                result.Add(new DbObject { Name = "@Data", Value = this.Data });
                result.Add(new DbObject { Name = "@Tip_plata", Value = this.TipPlata });
                return result;
            }
        }
    }
}
