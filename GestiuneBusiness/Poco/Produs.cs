using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Produs : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public decimal StocMinim { get; set; }
        public decimal Pret { get; set; }
        public string Um { get; set; }
        #endregion

        public override string NumeCompact
        {
            get
            {
                return Nume + " " + Um;
            }
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            var result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = ProduseDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (produsList == null)
                    {
                        produsList = new List<Produs>();
                    }
                    produsList.Add(this);
                }
                else
                {
                    ProduseDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Message = StringSaveSuccess;
                result.Status = Enums.StatusEnum.Saved;
            }
            catch (Exception ex)
            {
                result.ExceptionOccurred = ex;
                result.Message = StringSaveFail;
                result.Status = Enums.StatusEnum.Errors;
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

        public decimal CantitateDisponibila()
        {
            return (from s in Stoc.GetAll()
                    where s.IdProdus == this.ID
                    group s by s.NumeProdus into s_nou
                    select s_nou.Sum(p => p.Cantitate)).FirstOrDefault();
        }

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                result.Add(new DbObject { Name = "@StocMinim", Value = this.StocMinim, FriendlyName = "Stoc minim" });
                result.Add(new DbObject { Name = "@Pret", Value = this.Pret, FriendlyName = "Pret" });
                result.Add(new DbObject { Name = "@Um", Value = this.Um, FriendlyName = "Unitatea de masura" });
                return result;
            }
        }
    }
}
