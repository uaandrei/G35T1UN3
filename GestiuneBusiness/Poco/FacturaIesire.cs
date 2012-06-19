﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class FacturaIesire : GestiuneBusiness.Poco.Kernel.GestiuneObject
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

        public PersistenceResult Save(List<PozitieFacturaIesire> pozitiiList)
        {
            var result = new PersistenceResult();
            try
            {
                if (pozitiiList.Count == 0)
                {
                    return new PersistenceResult
                    {
                        Status = Enums.StatusEnum.Errors,
                        Message = "Nu ati adaugat niciun produs in factura!"
                    };
                }
                using (TransactionScope scope = new TransactionScope())
                {
                    // salvez factura
                    var facturaPR = this.Save();
                    if (facturaPR.Status == Enums.StatusEnum.Errors)
                    {
                        throw new Exception(facturaPR.Message, facturaPR.ExceptionOccurred);
                    }
                    var facturaId = this.ID;

                    // pentru fiecare pozitie  din factura adaug in baza de date si fac update la stoc
                    foreach (var item in pozitiiList)
                    {
                        var stocPR = item.StocObject.Save();
                        if (stocPR.Status == Enums.StatusEnum.Errors)
                        {
                            throw new Exception(stocPR.Message, stocPR.ExceptionOccurred);
                        }
                        item.IdFacturaIesire = facturaId;
                        var pozitiePR = item.Save();
                        if (pozitiePR.Status == Enums.StatusEnum.Errors)
                        {
                            throw new Exception(pozitiePR.Message, pozitiePR.ExceptionOccurred);
                        }
                    }

                    scope.Complete();
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

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = FacturiIesireDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (facturaIesireList == null)
                    {
                        facturaIesireList = new List<FacturaIesire>();
                    }
                    facturaIesireList.Add(this);
                }

                else
                {
                    FacturiIesireDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        internal static List<FacturaIesire> facturaIesireList = null;
        public static List<FacturaIesire> GetAll()
        {
            try
            {
                if (facturaIesireList == null) facturaIesireList = FacturiIesireDataHelper.GetInstance().GetAll().Cast<FacturaIesire>().ToList();
                return facturaIesireList;
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
                result.Add(new DbObject { Name = "@IdFirma", Value = this.IdFirma, FriendlyName = "Cumparator" });
                return result;
            }
        }
    }
}
