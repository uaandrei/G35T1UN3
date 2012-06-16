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
        public string Nr { get; set; }
        public DateTime Data { get; set; }
        public string TipPlata { get; set; }
        public decimal Suma { get; set; }
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
                result.Add(new DbObject { Name = "@Serie", Value = this.Serie, FriendlyName = "Serie" });
                result.Add(new DbObject { Name = "@Nr", Value = this.Nr, FriendlyName = "Numar" });
                result.Add(new DbObject { Name = "@Data", Value = this.Data, FriendlyName = "Data platii" });
                result.Add(new DbObject { Name = "@TipPlata", Value = this.TipPlata, FriendlyName = "Tip plata" });
                result.Add(new DbObject { Name = "@Suma", Value = this.Suma, FriendlyName = "Suma" });
                return result;
            }
        }
    }
}
