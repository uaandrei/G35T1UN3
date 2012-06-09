using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Firma : GestiuneBusiness.Poco.Kernel.GestiuneObject, IErrorInfo
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Cui { get; set; }
        public string NrInmatriculare { get; set; }
        public string Iban { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string PersoanaContact { get; set; }
        public DateTime? DataInfiintarii { get; set; }

        private int idBanca;

        public int IdBanca
        {
            get
            {
                return idBanca;
            }
            set
            {
                idBanca = value;
                banca = Banca.GetAll().Where(p => p.ID == value).FirstOrDefault();
            }
        }

        private Banca banca = null;
        public Banca BancaObject
        {
            get { return banca; }
        }

        private int idDelegat;
        public int IdDelegat
        {
            get
            {
                return idDelegat;
            }
            set
            {
                idDelegat = value;
                delegat = Delegat.GetAll().Where(p => p.ID == value).FirstOrDefault();
            }
        }

        private Delegat delegat = null;
        public Delegat DelegatObject
        {
            get { return delegat; }
        }

        #endregion
        public string GetErrors()
        {
            string result = "";
            if (string.IsNullOrEmpty(Nume)) result += "Nu ati introdus numele!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Cui)) result += "Nu ati introdus CUI!" + Environment.NewLine;
            if (string.IsNullOrEmpty(NrInmatriculare)) result += "Nu ati introdus Nr. de Inmantriculare!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Iban)) result += "Nu ati introdus IBAN!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Localitate)) result += "Nu ati introdus Localitatea!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Judet)) result += "Nu ati introdus Judetul!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Adresa)) result += "Nu ati introdus Adresa!" + Environment.NewLine;
            if (string.IsNullOrEmpty(Telefon)) result += "Nu ati introdus Telefonul!" + Environment.NewLine;
            if (string.IsNullOrEmpty(PersoanaContact)) result += "Nu ati introdus Persoana de Contact!" + Environment.NewLine;
            if (idBanca == 0) result += "Alegeti banca!" + Environment.NewLine;
            if (idDelegat == 0) result += "Alegeti delegatul!" + Environment.NewLine;
            return result;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = FirmeDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    firmaList.Add(this);
                }
                else
                {
                    FirmeDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Status = Enums.EnumStatus.Saved;
                result.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                result.Status = Enums.EnumStatus.Errors;
                result.Message = StringSaveFail;
                result.ExceptionOccurred = ex;
            }
            return result;
        }

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        private static List<Firma> firmaList = null;
        public static List<Firma> GetAll()
        {
            try
            {
                if (firmaList == null)
                {
                    firmaList = FirmeDataHelper.GetInstance().GetAll().Cast<Firma>().ToList();
                }
                return firmaList;
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
                result.Add(new DbObject { Name = "@CUI", Value = this.Cui });
                result.Add(new DbObject { Name = "@Numar_inmatriculare", Value = this.NrInmatriculare });
                result.Add(new DbObject { Name = "@IBAN", Value = this.Iban });
                result.Add(new DbObject { Name = "@Localitate", Value = this.Localitate });
                result.Add(new DbObject { Name = "@Judet", Value = this.Judet });
                result.Add(new DbObject { Name = "@Adresa", Value = this.Adresa });
                result.Add(new DbObject { Name = "@Telefon", Value = this.Telefon });
                result.Add(new DbObject { Name = "@Persoana_contact", Value = this.PersoanaContact });
                result.Add(new DbObject { Name = "@Data_infiintarii", Value = this.DataInfiintarii });
                result.Add(new DbObject { Name = "@ID_Banca", Value = this.IdBanca });
                result.Add(new DbObject { Name = "@ID_Delegat", Value = this.IdDelegat });
                return result;
            }
        }
    }
}
