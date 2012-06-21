using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace GestiuneBusiness.Poco.Administration
{
    public class Rol : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Descriere { get; set; }
        #endregion

        private static List<Rol> rolList = null;
        public static List<Rol> GetAll()
        {
            try
            {
                if (rolList == null)
                {
                    rolList = RoluriDataHelper.GetInstance().GetAll().Cast<Rol>().ToList();
                }
                return rolList;
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
                    this.ID = RoluriDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (rolList == null)
                    {
                        rolList = new List<Rol>();
                    }
                    rolList.Add(this);
                }
                else
                {
                    RoluriDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Message = StringSaveSuccess;
                persistenceResult.Status = StatusEnum.Saved;
            }
            catch (Exception ex)
            {
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
                result.Add(new DbObject { Name = "@Descriere", Value = this.Descriere, FriendlyName = "Descriere" });
                return result;
            }
        }
    }
}
