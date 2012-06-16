﻿using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Delegat : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Cnp { get; set; }
        public string Serie { get; set; }
        public string Nume { get; set; }
        #endregion

        public override GestiuneBusiness.DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0)
                {
                    // obiectul este nou, deci trebuie creat
                    this.ID = DelegatiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    delegatList.Add(this);
                }

                else
                {
                    DelegatiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        private static List<Delegat> delegatList = null;
        public static List<Delegat> GetAll()
        {
            try
            {
                if (delegatList == null)
                {
                    delegatList = DelegatiDataHelper.GetInstance().GetAll().Cast<Delegat>().ToList();
                }
                return delegatList;
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
                result.Add(new DbObject { Name = "@CNP", Value = this.Cnp, FriendlyName = "CNP" });
                result.Add(new DbObject { Name = "@Serie", Value = this.Serie, FriendlyName = "Serie" });
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                return result;
            }
        }
    }
}
