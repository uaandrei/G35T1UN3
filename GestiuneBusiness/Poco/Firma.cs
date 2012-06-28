using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Firma : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Cui { get; set; }
        public string Rc { get; set; }
        public string Iban { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public DateTime DataInfiintarii { get; set; }
        public int IdBanca { get; set; }
        public int IdDelegat { get; set; }
        public override string NumeCompact
        {
            get
            {
                return Nume;
            }
        }

        public string InfoString
        {
            get
            {
                var result = "";
                result += Nume + Environment.NewLine;
                result += "C.U.I.: " + this.Cui + Environment.NewLine;
                result += "Reg. com.: " + this.Rc + Environment.NewLine;
                result += "Adresa: " + this.Adresa + Environment.NewLine;
                result += "IBAN: " + this.Iban + Environment.NewLine;
                result += "Banca: " + this.BancaObject.Nume;
                return result;
            }
        }

        public Banca BancaObject
        {
            get { return Banca.GetAll().FirstOrDefault(p => p.ID == IdBanca); }
        }
        public Delegat DelegatObject
        {
            get { return Delegat.GetAll().FirstOrDefault(p => p.ID == IdDelegat); }
        }
        #endregion

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = FirmeDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (firmaList == null)
                    {
                        firmaList = new List<Firma>();
                    }
                    firmaList.Add(this);
                }
                else
                {
                    FirmeDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Status = Enums.StatusEnum.Saved;
                result.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                result.Status = Enums.StatusEnum.Errors;
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
        //TODO: sa ma scot pe mine de aici ca firma de aici, dupa ce imi fac partea de autoidentificare
        public static List<Firma> GetAll()
        {
            try
            {
                if (firmaList == null)
                    firmaList = FirmeDataHelper.GetInstance().GetAll().Cast<Firma>().ToList();
                return firmaList;
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
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                result.Add(new DbObject { Name = "@CUI", Value = this.Cui, FriendlyName = "C.U.I." });
                result.Add(new DbObject { Name = "@RC", Value = this.Rc, FriendlyName = "Registru Comert" });
                result.Add(new DbObject { Name = "@IBAN", Value = this.Iban, FriendlyName = "IBAN" });
                result.Add(new DbObject { Name = "@Adresa", Value = this.Adresa, FriendlyName = "Adresa" });
                result.Add(new DbObject { Name = "@Telefon", Value = this.Telefon, FriendlyName = "Telefon" });
                result.Add(new DbObject { Name = "@DataInfiintarii", Value = this.DataInfiintarii, FriendlyName = "Data infiintarii" });
                result.Add(new DbObject { Name = "@IdBanca", Value = this.IdBanca, FriendlyName = "Banca" });
                result.Add(new DbObject { Name = "@IdDelegat", Value = this.IdDelegat, FriendlyName = "Delegat" });
                return result;
            }
        }
    }
}
