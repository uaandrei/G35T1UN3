using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Banca : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Cui { get; set; }
        public string RC { get; set; }
        public decimal CapitalSocial { get; set; }
        #endregion

        public override PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = BanciDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (bancaList == null)
                    {
                        bancaList = new List<Banca>();
                    }
                    bancaList.Add(this);
                }

                else
                {
                    BanciDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        private static List<Banca> bancaList = null;
        public static List<Banca> GetAll()
        {
            try
            {
                if (bancaList == null) bancaList = BanciDataHelper.GetInstance().GetAll().Cast<Banca>().ToList();
                return bancaList;
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
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                result.Add(new DbObject { Name = "@Adresa", Value = this.Adresa, FriendlyName = "Adresa" });
                result.Add(new DbObject { Name = "@CUI", Value = this.Cui, FriendlyName = "C.U.I." });
                result.Add(new DbObject { Name = "@RC", Value = this.RC, FriendlyName = "Registru Comert" });
                result.Add(new DbObject { Name = "@CapitalSocial", Value = this.CapitalSocial, FriendlyName = "Capital social" });
                return result;
            }
        }
    }
}
