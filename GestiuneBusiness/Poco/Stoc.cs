using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Stoc : GestiuneBusiness.Poco.Kernel.GestiuneObject, IErrorInfo
    {
        #region [MEMBERS]
        private int idProdus;

        public int IdProdus
        {
            get
            {
                return idProdus;
            }
            set
            {
                idProdus = value;
                produs = Produs.GetAll().Where(p => p.ID == value).FirstOrDefault();
            }
        }

        private Produs produs;
        public Produs ProdusObject
        {
            get { return produs; }
        }

        private int idFacturaIntrare;
        public int IdFacturaIntrare
        {
            get
            {
                return idFacturaIntrare;
            }
            set
            {
                idFacturaIntrare = value;
                factura = Factura.GetAll().Where(p => p.ID == value).FirstOrDefault();
            }
        }

        private Factura factura;
        public Factura FacturaObject
        {
            get { return factura; }
        }

        public decimal Cantitate { get; set; }

        #endregion
        public string GetErrors()
        {
            string result = "";
            if (Cantitate == 0m) result += "Cantitate invalida!" + Environment.NewLine;
            if (idFacturaIntrare == 0) result += "Alegeti o Factura de Intrare!" + Environment.NewLine;
            if (idProdus == 0) result += "Alegeti un Produs!" + Environment.NewLine;
            return result;
        }

        public override DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID ==0)
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

        private static List<Stoc> stocList = null;
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
                result.Add(new DbObject { Name = "@ID_produs", Value = this.IdProdus });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate });
                result.Add(new DbObject { Name = "@Id_factura_intrare", Value = this.IdFacturaIntrare });
                return result;
            }
        }
    }
}
