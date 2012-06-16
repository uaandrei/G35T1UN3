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
            var result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = PlatiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (plataList == null)
                    {
                        plataList = new List<Plata>();
                    }
                    plataList.Add(this);
                }
                else
                {
                    PlatiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Message = StringSaveSuccess;
                result.Status = Enums.StatusEnum.Saved;
            }
            catch (Exception ex)
            {
                result.Message = StringSaveFail;
                result.Status = Enums.StatusEnum.Errors;
                result.ExceptionOccurred = ex;
            }
            return result;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        private static List<Plata> plataList = null;
        public static List<Plata> GetAll()
        {
            try
            {
                if (plataList == null)
                    plataList = PlatiDataHelper.GetInstance().GetAll().Cast<Plata>().ToList();
                return plataList;
            }
            catch (Exception)
            {
                return null;
            }
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
