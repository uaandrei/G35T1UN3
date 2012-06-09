using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Banca : GestiuneBusiness.Poco.Kernel.GestiuneObject, IErrorInfo
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string CodIdentificareFiscala { get; set; }
        public string NrOrc { get; set; }
        #endregion

        public string GetErrors()
        {
            string result = "";
            if (string.IsNullOrEmpty(Nume)) result += "Nu ati introdus Numele!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Adresa)) result += "Nu ati introdus Adresa!" + Environment.NewLine;
            if (string.IsNullOrEmpty(CodIdentificareFiscala)) result += "Nu ati introdus CIF!" + Environment.NewLine;
            if (string.IsNullOrEmpty(NrOrc)) result += "Nu ati introdus Nr Orc!" + Environment.NewLine;
            return result;
        }

        public override PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = BanciDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    bancaList.Add(this);
                }

                else
                {
                    BanciDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        private static List<Banca> bancaList = null;
        public static List<Banca> GetAll()
        {
            try
            {
                if (bancaList==null)
                {
                    bancaList = BanciDataHelper.GetInstance().GetAll().Cast<Banca>().ToList();
                }
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
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume });
                result.Add(new DbObject { Name = "@Adresa", Value = this.Adresa });
                result.Add(new DbObject { Name = "@Cod_identificare_fiscala", Value = this.CodIdentificareFiscala });
                result.Add(new DbObject { Name = "@Nr_orc", Value = this.NrOrc });
                return result;
            }
        }
    }
}
