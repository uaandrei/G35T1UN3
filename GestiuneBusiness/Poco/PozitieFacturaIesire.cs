using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.DataHelper;

namespace GestiuneBusiness.Poco
{
    // TODO: verifica inainte de a salva orice daca nu mai exista deja in baza de date cu aceleasi date(si nu e vb de update)
    public class PozitieFacturaIesire : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdFacturaIesire { get; set; }
        public int IdStoc { get; set; }
        public decimal Cantitate { get; set; }
        public decimal PretUnitar { get; set; }
        public FacturaIesire FacturaIesireObject
        {
            get
            {
                return FacturaIesire.GetAll().FirstOrDefault(p => p.ID == IdFacturaIesire);
            }
        }
        public Stoc StocObject
        {
            get
            {
                return Stoc.GetAll().FirstOrDefault(p => p.ID == IdStoc);
            }
        }
        #endregion

        private static List<PozitieFacturaIesire> pozitieFacturaIesireList = null;
        public static List<PozitieFacturaIesire> GetAll()
        {
            try
            {
                if (pozitieFacturaIesireList == null)
                    pozitieFacturaIesireList = PozitiiFacturiIesireDataHelper.GetInstance().GetAll().Cast<PozitieFacturaIesire>().ToList();
                return pozitieFacturaIesireList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override PersistenceResult Save()
        {
            var persistenceResult = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = PozitiiFacturiIesireDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (pozitieFacturaIesireList == null)
                    {
                        pozitieFacturaIesireList = new List<PozitieFacturaIesire>();
                    }
                    pozitieFacturaIesireList.Add(this);
                }
                else
                {
                    PozitiiFacturiIesireDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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
                result.Add(new DbObject { Name = "@IdFacturaIesire", Value = this.IdFacturaIesire, FriendlyName = "Factura iesire" });
                result.Add(new DbObject { Name = "@IdStoc", Value = this.IdStoc, FriendlyName = "Stoc" });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate, FriendlyName = "Cantitate" });
                result.Add(new DbObject { Name = "@PretUnitar", Value = this.PretUnitar, FriendlyName = "Pret unitar" });
                return result;
            }
        }
    }
}
