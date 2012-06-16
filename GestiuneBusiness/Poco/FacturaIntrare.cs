using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class FacturaIntrare : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Serie { get; set; }
        public string Numar { get; set; }
        public DateTime Data { get; set; }
        public int IdFirma { get; set; }
        public Firma FirmaObject
        {
            get
            {
                return Firma.GetAll().FirstOrDefault(p => p.ID == IdFirma);
            }
        }
        #endregion

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = FacturiIntrareDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (facturaIntrareList==null)
                    {
                        facturaIntrareList = new List<FacturaIntrare>();
                    }
                    facturaIntrareList.Add(this);
                }

                else
                {
                    FacturiIntrareDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Status = Enums.StatusEnum.Saved;
                persistenceResult.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                persistenceResult.Status = Enums.StatusEnum.Errors;
                persistenceResult.Message = StringSaveFail;
                persistenceResult.ExceptionOccurred = ex;
            }
            return persistenceResult;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        internal static List<FacturaIntrare> facturaIntrareList = null;
        public static List<FacturaIntrare> GetAll()
        {
            try
            {
                if (facturaIntrareList == null)
                    facturaIntrareList = FacturiIntrareDataHelper.GetInstance().GetAll().Cast<FacturaIntrare>().ToList();
                return facturaIntrareList;
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
                result.Add(new DbObject { Name = "@Numar", Value = this.Numar, FriendlyName = "Numar" });
                result.Add(new DbObject { Name = "@Data", Value = this.Data, FriendlyName = "Data facturarii" });
                result.Add(new DbObject { Name = "@IdFirma", Value = this.IdFirma, FriendlyName = "Furnizor" });
                return result;
            }
        }
    }
}
