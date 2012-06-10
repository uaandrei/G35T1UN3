using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Factura : GestiuneBusiness.Poco.Kernel.GestiuneObject, IErrorInfo
    {
        #region [MEMBERS]
        public string Serie { get; set; }
        public string Numar { get; set; }
        public DateTime? Data { get; set; }
        public string Tip { get; set; }

        private int idFirma;

        public int IdFirma
        {
            get
            {
                return idFirma;
            }
            set
            {
                idFirma = value;
                firma = Firma.GetAll().Where(p => p.ID == value).FirstOrDefault();
            }
        }

        private Firma firma = null;
        public Firma Firma
        {
            get { return firma; }
        }

        #endregion

        public string GetErrors()
        {
            string result = "";
            if (string.IsNullOrEmpty(Serie)) result += "Nu ati introdus Seria!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Numar)) result += "Nu ati introdus Numarul!" + Environment.NewLine;
            if (idFirma == 0) result += "Nu ati selectat Firma!" + Environment.NewLine;
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
                    this.ID = FacturiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    facturaList.Add(this);
                }

                else
                {
                    FacturiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        internal static List<Factura> facturaList = null;
        public static List<Factura> GetAll()
        {
            try
            {
                if (facturaList == null)
                {
                    facturaList = FacturiDataHelper.GetInstance().GetAll().Cast<Factura>().ToList();
                }
                return facturaList;
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
                result.Add(new DbObject { Name = "@Serie", Value = this.Serie });
                result.Add(new DbObject { Name = "@Numar", Value = this.Numar });
                result.Add(new DbObject { Name = "@Data", Value = this.Data });
                result.Add(new DbObject { Name = "@Tip", Value = this.Tip });
                result.Add(new DbObject { Name = "@ID_firma", Value = this.IdFirma });
                return result;
            }
        }
    }
}
