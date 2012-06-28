using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace GestiuneBusiness.Poco.Administration
{
    public class Utilizator : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Parola { get; set; }
        public bool Activ { get; set; }
        public int IdRol { get; set; }
        public override string NumeCompact
        {
            get
            {
                return Nume;
            }
        }

        public Rol RolObject
        {
            get
            {
                return Rol.GetAll().FirstOrDefault(p => p.ID == IdRol);
            }
        }
        #endregion

        private static List<Utilizator> utilizatorList = null;

        public static List<Utilizator> GetAll()
        {
            try
            {
                if (utilizatorList == null)
                {
                    utilizatorList = UtilizatoriDataHelper.GetInstance().GetAll().Cast<Utilizator>().ToList();
                }
                return utilizatorList;
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
                    this.ID = UtilizatoriDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (utilizatorList == null)
                    {
                        utilizatorList = new List<Utilizator>();
                    }
                    utilizatorList.Add(this);
                }
                else
                {
                    UtilizatoriDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Message = StringSaveSuccess;
                persistenceResult.Status = StatusEnum.Saved;
            }
            catch (Exception ex)
            {
                utilizatorList = null;
                persistenceResult.Message = StringSaveFail;
                persistenceResult.Status = StatusEnum.Errors;
                persistenceResult.ExceptionOccurred = ex;
            }
            return persistenceResult;
        }

        public override PersistenceResult Delete()
        {
            return null;
        }

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                result.Add(new DbObject { Name = "@Parola", Value = this.Parola, FriendlyName = "Parola" });
                result.Add(new DbObject { Name = "@Activ", Value = this.Activ, FriendlyName = "Activ" });
                result.Add(new DbObject { Name = "@IdRol", Value = this.IdRol, FriendlyName = "Rol" });
                return result;
            }
        }
    }
}
