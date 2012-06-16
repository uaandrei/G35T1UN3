﻿using System;
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
        public Banca BancaObject
        {
            get { return Banca.GetAll().FirstOrDefault(p => p.ID == IdBanca); }
        }
        public int IdDelegat { get; set; }
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
                    if (firmaList==null)
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

        protected override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                result.Add(new DbObject { Name = "@CUI", Value = this.Cui, FriendlyName = "C.U.I." });
                result.Add(new DbObject { Name = "@RC", Value = this.Rc, FriendlyName = "Registru Comert" });
                result.Add(new DbObject { Name = "@IBAN", Value = this.Iban, FriendlyName = "IBAN" });
                result.Add(new DbObject { Name = "@Adresa", Value = this.Adresa, FriendlyName = "Adresa" });
                result.Add(new DbObject { Name = "@Telefon", Value = this.Telefon });
                result.Add(new DbObject { Name = "@DataInfiintarii", Value = this.DataInfiintarii });
                result.Add(new DbObject { Name = "@IdBanca", Value = this.IdBanca, FriendlyName = "Banca" });
                result.Add(new DbObject { Name = "@IdDelegat", Value = this.IdDelegat, FriendlyName = "Delegat" });
                return result;
            }
        }
    }
}
