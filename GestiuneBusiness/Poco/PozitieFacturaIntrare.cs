using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.DataHelper;

namespace GestiuneBusiness.Poco
{
    public class PozitieFacturaIntrare : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdFacturaIntrare { get; set; }
        public int IdProdus { get; set; }
        public decimal Cantitate { get; set; }
        public decimal PretUnitar { get; set; }
        public FacturaIntrare FacturaIntrareObject
        {
            get
            {
                return FacturaIntrare.GetAll().FirstOrDefault(p => p.ID == IdFacturaIntrare);
            }
        }
        public Produs ProdusObject
        {
            get
            {
                return Produs.GetAll().FirstOrDefault(p => p.ID == IdProdus);
            }
        }
        #endregion

        private static List<PozitieFacturaIntrare> pozitieFacturaIntrareList = null;
        // TODO: modifica asta in proprietate, ca altfel, prin referinta, poate fi modificata si din exterior;
        public static List<PozitieFacturaIntrare> GetAll()
        {
            try
            {
                if (pozitieFacturaIntrareList == null)
                    pozitieFacturaIntrareList = PozitiiFacturiIntrareDataHelper.GetInstance().GetAll().Cast<PozitieFacturaIntrare>().ToList();
                return pozitieFacturaIntrareList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = PozitiiFacturiIntrareDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (pozitieFacturaIntrareList == null)
                    {
                        pozitieFacturaIntrareList = new List<PozitieFacturaIntrare>();
                    }
                    pozitieFacturaIntrareList.Add(this);
                }
                else
                {
                    PozitiiFacturiIntrareDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Message = StringSaveSuccess;
                persistenceResult.Status = Enums.StatusEnum.Saved;
            }
            catch (Exception ex)
            {
                persistenceResult.Message = StringSaveFail;
                persistenceResult.Status = Enums.StatusEnum.Errors;
                persistenceResult.ExceptionOccurred = ex;
            }
            return persistenceResult;
        }

        public override PersistenceResult Delete()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        protected override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@IdFacturaIntrare", Value = this.IdFacturaIntrare, FriendlyName = "Factura intrare" });
                result.Add(new DbObject { Name = "@IdProdus", Value = this.IdProdus, FriendlyName = "Produs" });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate, FriendlyName = "Cantitate" });
                result.Add(new DbObject { Name = "@PretUnitar", Value = this.PretUnitar, FriendlyName = "Pret unitar" });
                return result;
            }
        }
    }
}
