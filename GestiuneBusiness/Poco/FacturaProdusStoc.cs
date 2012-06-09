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
        public Factura FacturaObject { get; set; }

        public Produs ProdusObject { get; set; }

        public Stoc StocObject { get; set; }

        public decimal Pret { get; set; }
        public decimal Cantitate { get; set; }

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
                result.Add(new DbObject { Name = "@ID_factura", Value = this.FacturaObject.ID });
                result.Add(new DbObject { Name = "@ID_produs", Value = this.ProdusObject.ID });
                result.Add(new DbObject { Name = "@ID_stoc", Value = this.StocObject.ID });
                result.Add(new DbObject { Name = "@Pret", Value = this.Pret});
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate });
                return result;
            }
        }

        //TODO: la dublu click pe grid sa apara raport cu factura;
        public override PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();
            try
            {
                if (this.ProdusObject.ID == 0) throw new Exception("Produs invalid, id = 0.");
                using (TransactionScope scope = new TransactionScope())
                {
                    var result = this.FacturaObject.Save();
                    if (result.ExceptionOccurred != null) throw new Exception("Transaction fail.", result.ExceptionOccurred);
                    StocObject.IdFacturaIntrare = this.FacturaObject.ID;
                    result = this.StocObject.Save();
                    if (result.ExceptionOccurred != null) throw new Exception("Transaction fail.", result.ExceptionOccurred);
                    FacturaProdusStocDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    scope.Complete();
                }
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

        public string GetErrors()
        {
            string result = "";
            if (this.Cantitate < 0) result += "Introduceti o cantitate!" + Environment.NewLine;
            result += this.ProdusObject.GetErrors();
            result += this.FacturaObject.GetErrors();
            result += this.StocObject.GetErrors();
            return result;
        }
    }
}
