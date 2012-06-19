using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
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
        public decimal CotaTva { get; set; }
        public Firma FirmaObject
        {
            get
            {
                return Firma.GetAll().FirstOrDefault(p => p.ID == IdFirma);
            }
        }
        #endregion

        public PersistenceResult Save(List<PozitieFacturaIntrare> pozitieFacturaIntrareList)
        { // toate salvarea unei facturi de intrare reprezinta o tranzactie
            var persistenceResult = new PersistenceResult();
            try
            {
                if (pozitieFacturaIntrareList.Count == 0)
                {
                    return new PersistenceResult
                    {
                        Message = "Nu ati adaugat niciun produs in factura!",
                        Status = Enums.StatusEnum.Errors
                    };
                }
                using (TransactionScope scope = new TransactionScope())
                {
                    // salvez factura de intrare
                    var facturaPersistenceResult = this.Save();
                    if (facturaPersistenceResult.Status == Enums.StatusEnum.Errors)
                    {
                        throw new Exception(facturaPersistenceResult.Message, facturaPersistenceResult.ExceptionOccurred);
                    }
                    int facturaIntrareId = this.ID;
                    foreach (var pozitieFacturaIntrare in pozitieFacturaIntrareList)
                    {
                        // salvez fiecare pozitie factura intrare
                        pozitieFacturaIntrare.IdFacturaIntrare = facturaIntrareId;
                        var pozitieFacturaIntrarePersistenceResult = pozitieFacturaIntrare.Save();

                        if (pozitieFacturaIntrarePersistenceResult.Status == Enums.StatusEnum.Errors)
                        {
                            throw new Exception(pozitieFacturaIntrarePersistenceResult.Message, pozitieFacturaIntrarePersistenceResult.ExceptionOccurred);
                        }

                        var stocNou = new Stoc
                        {
                            IdPozitieFacturaIntrare = pozitieFacturaIntrare.ID,
                            IdProdus = pozitieFacturaIntrare.IdProdus,
                            Cantitate = pozitieFacturaIntrare.Cantitate
                        };
                        var stocPersistenceResult = stocNou.Save();

                        if (stocPersistenceResult.Status == Enums.StatusEnum.Errors)
                        {
                            throw new Exception(stocPersistenceResult.Message, stocPersistenceResult.ExceptionOccurred);
                        }

                    }
                    scope.Complete();
                }
                persistenceResult.Status = Enums.StatusEnum.Saved;
                persistenceResult.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                FacturaIntrare.facturaIntrareList = null;
                PozitieFacturaIntrare.pozitieFacturaIntrareList = null;
                Stoc.stocList = null;
                persistenceResult.Status = Enums.StatusEnum.Errors;
                persistenceResult.ExceptionOccurred = ex;
                persistenceResult.Message = StringSaveFail;
            }
            return persistenceResult;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = FacturiIntrareDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (facturaIntrareList == null)
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

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Serie", Value = this.Serie, FriendlyName = "Serie" });
                result.Add(new DbObject { Name = "@Numar", Value = this.Numar, FriendlyName = "Numar" });
                result.Add(new DbObject { Name = "@Data", Value = this.Data, FriendlyName = "Data facturarii" });
                result.Add(new DbObject { Name = "@CotaTva", Value = this.CotaTva, FriendlyName = "Cota TVA" });
                result.Add(new DbObject { Name = "@IdFirma", Value = this.IdFirma, FriendlyName = "Furnizor" });
                return result;
            }
        }
    }
}
