using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using System.Transactions;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class FacturaProdusStoc : GestiuneObject
    {
        public FacturaIesire FacturaObject { get; set; }

        public Produs ProdusObject { get; set; }

        public Stoc StocObject { get; set; }

        public decimal Pret { get; set; }
        public decimal Cantitate { get; set; }

        public override PersistenceResult Delete()
        {
            // TODO: Implement this method if needed
            throw new NotImplementedException();
        }

        protected override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@ID_factura", Value = this.FacturaObject.ID });
                result.Add(new DbObject { Name = "@ID_produs", Value = this.ProdusObject.ID });
                result.Add(new DbObject { Name = "@ID_stoc", Value = this.StocObject.ID });
                result.Add(new DbObject { Name = "@Pret", Value = this.Pret });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate });
                return result;
            }
        }

        public override PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();
            try
            {
                if (this.ProdusObject.ID == 0) throw new Exception("Produs invalid, id = 0.");
                var result = this.FacturaObject.Save();
                if (result.ExceptionOccurred != null) throw new Exception("Factura save fail.", result.ExceptionOccurred);
                StocObject.IdFacturaIntrare = this.FacturaObject.ID;
                result = this.StocObject.Save();
                if (result.ExceptionOccurred != null) throw new Exception("Stoc save fail.", result.ExceptionOccurred);
                this.ID = FacturaProdusStocDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                persistenceResult.Status = Enums.EnumStatus.Saved;
                persistenceResult.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                persistenceResult.ExceptionOccurred = ex;
                persistenceResult.Status = Enums.EnumStatus.Errors;
                persistenceResult.Message = StringSaveFail;
            }
            return persistenceResult;
        }

        public static PersistenceResult SaveManyFacturaProdusStoc(List<FacturaProdusStoc> facturaProdusStocList)
        {
            PersistenceResult persistenceResult = new PersistenceResult();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    foreach (var item in facturaProdusStocList)
                    {
                        var result = item.Save();
                        if (result.ExceptionOccurred != null) throw new Exception("Save FacturaProdusStoc fail.", result.ExceptionOccurred);
                    }
                    scope.Complete();
                }
                foreach (var item in facturaProdusStocList)
                {
                    FacturaProdusStoc.facturaProdusStocList.Add(item);
                }
                persistenceResult.Message = StringSaveSuccess;
                persistenceResult.Status = Enums.EnumStatus.Saved;
            }
            catch (Exception ex)
            {
                // daca au aparut erori in timpul tranzactiei trebuie resetat cache`ul local pentru facturi si stocuri;
                FacturaIesire.facturaIesireList = null;
                Stoc.stocList = null;
                persistenceResult.ExceptionOccurred = ex;
                persistenceResult.Message = StringSaveFail;
                persistenceResult.Status = Enums.EnumStatus.Errors;
            }
            return persistenceResult;
        }

        public string GetErrors()
        {
            string result = "";
            if (this.Cantitate < 0) result += "Introduceti o cantitate!" + Environment.NewLine;
            result += this.ProdusObject.GetErrors();
            result += this.FacturaObject.GetErrors();
            result += this.StocObject.GetErrors();
            return result;
        }

        private static List<FacturaProdusStoc> facturaProdusStocList = null;

        public static List<FacturaProdusStoc> GetAll()
        {
            try
            {
                if (facturaProdusStocList == null)
                {
                    facturaProdusStocList = FacturaProdusStocDataHelper.GetInstance().GetAll().Cast<FacturaProdusStoc>().ToList();
                }
                return facturaProdusStocList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
