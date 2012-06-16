using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Stoc : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdProdus { get; set; }
        public int IdPozitieFacturaIntrare { get; set; }
        public decimal Pret { get; set; }
        public PozitieFacturaIntrare PozitieFacturaIntrareObject
        {
            get { return PozitieFacturaIntrare.GetAll().FirstOrDefault(p => p.ID == IdPozitieFacturaIntrare); }
        }
        public Produs ProdusObject
        {
            get
            {
                return Produs.GetAll().FirstOrDefault(p => p.ID == IdProdus);
            }
        }
        #endregion
    
        public override DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = StocDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    stocList.Add(this);
                }

                else
                {
                    StocDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Status = Enums.EnumStatus.Saved;
                persistenceResult.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                persistenceResult.Status = Enums.EnumStatus.Errors;
                persistenceResult.Message = StringSaveFail;
                persistenceResult.ExceptionOccurred = ex;
            }
            return persistenceResult;
        }

        public override DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        internal static List<Stoc> stocList = null;
        public static List<Stoc> GetAll()
        {
            try
            {
                if (stocList == null)
                {
                    stocList = StocDataHelper.GetInstance().GetAll().Cast<Stoc>().ToList();
                }
                return stocList;
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
                result.Add(new DbObject { Name = "@IdProdus", Value = this.IdProdus,FriendlyName="Produs" });
                result.Add(new DbObject { Name = "@IdPozitieFacturaIntrare", Value = this.IdPozitieFacturaIntrare, FriendlyName = "Pozitie factura intrare" });
                result.Add(new DbObject { Name = "@Pret", Value = this.Pret, FriendlyName = "Pret" });
                return result;
            }
        }
    }
}
