using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace GestiuneBusiness.Poco.Administration
{
    public class Drept : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string Nume { get; set; }
        public string Descriere { get; set; }
        #endregion

        private static List<Drept> dreptList = null;
        public static List<Drept> GetAll()
        {
            try
            {
                if (dreptList == null)
                {
                    dreptList = DrepturiDataHelper.GetInstance().GetAll().Cast<Drept>().ToList();
                }
                return dreptList;
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
                    this.ID = DrepturiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (dreptList == null)
                    {
                        dreptList = new List<Drept>();
                    }
                    dreptList.Add(this);
                }
                else
                {
                    DrepturiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@Descriere", Value = this.Descriere, FriendlyName = "Descriere" });
                result.Add(new DbObject { Name = "@Nume", Value = this.Nume, FriendlyName = "Nume" });
                return result;
            }
        }
    }
}
