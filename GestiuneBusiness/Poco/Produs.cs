using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Produs : GestiuneBusiness.Poco.Kernel.GestiuneObject, IErrorInfo
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public decimal RataTva { get; set; }
        public string Um { get; set; }
        #endregion

        public string GetErrors()
        {
            // TODO: avertisment daca vrea sa puna rata tva zero
            string result = "";
            if (string.IsNullOrEmpty(Nume)) result += "Nu ati introdus Numele!" + Environment.NewLine;
            if (Pret == 0m) result += "Nu ati introdus Pretul!" + Environment.NewLine;
            if (RataTva == 0m) result += "Nu ati introdus Rata TVA!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Nume)) result += "Nu ati introdus Unitatea de Masura!" + Environment.NewLine;
            return result;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            var result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = ProduseDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    produsList.Add(this);
                }
                else
                {
                    ProduseDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Message = StringSaveSuccess;
                result.Status = Enums.EnumStatus.Saved;
            }
            catch (Exception ex)
            {
                result.ExceptionOccurred = ex;
                result.Message = StringSaveFail;
                result.Status = Enums.EnumStatus.Errors;
            }
            return result;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        private static List<Produs> produsList = null;
        public static List<Produs> GetAll()
        {
            try
            {
                if (produsList == null)
                {
                    produsList = ProduseDataHelper.GetInstance().GetAll().Cast<Produs>().ToList();
                }
                return produsList;
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
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume });
                result.Add(new DbObject { Name = "@Pret", Value = this.Pret });
                result.Add(new DbObject { Name = "@Rata_TVA", Value = this.RataTva });
                result.Add(new DbObject { Name = "@UM", Value = this.Um });
                return result;
            }
        }
    }
}
