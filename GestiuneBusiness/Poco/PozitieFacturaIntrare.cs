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
        public override string NumeCompact
        {
            get
            {
                return "PozitieFacturaIntrare";
            }
        }

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

        internal static List<PozitieFacturaIntrare> pozitieFacturaIntrareList = null;
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
            return null;
        }

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@IdFacturaIntrare", Value = this.IdFacturaIntrare, FriendlyName = "" });
                result.Add(new DbObject { Name = "@IdProdus", Value = this.IdProdus, FriendlyName = "Produs" });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate, FriendlyName = "Cantitate" });
                result.Add(new DbObject { Name = "@PretUnitar", Value = this.PretUnitar, FriendlyName = "Pret unitar" });
                return result;
            }
        }
    }
}
