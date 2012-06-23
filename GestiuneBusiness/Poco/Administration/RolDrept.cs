using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace GestiuneBusiness.Poco.Administration
{
    public class RolDrept : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdRol { get; set; }
        public int IdDrept { get; set; }
        public bool AreDrept { get; set; }
        public override string NumeCompact
        {
            get
            {
                return "RolDrept";
            }
        }

        public Drept DreptObject
        {
            get
            {
                return Drept.GetAll().FirstOrDefault(p => p.ID == this.IdDrept);
            }
        }
        public Rol RolObject
        {
            get
            {
                return Rol.GetAll().FirstOrDefault(p => p.ID == this.IdRol);
            }
        }
        #endregion

        public override PersistenceResult Save()
        {
            var persistenceResult = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = RoluriDrepturiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (rolDreptList == null)
                    {
                        rolDreptList = new List<RolDrept>();
                    }
                    rolDreptList.Add(this);
                }
                else
                {
                    RoluriDrepturiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
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

        private static List<RolDrept> rolDreptList = null;
        public static List<RolDrept> GetAll()
        {
            try
            {
                if (rolDreptList == null)
                {
                    rolDreptList = RoluriDrepturiDataHelper.GetInstance().GetAll().Cast<RolDrept>().ToList();
                }
                return rolDreptList;
            }
            catch (Exception)
            {
                return null;
            }
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
                result.Add(new DbObject { Name = "@IdDrept", Value = this.IdDrept, FriendlyName = "Drept" });
                result.Add(new DbObject { Name = "@AreDrept", Value = this.AreDrept, FriendlyName = "Are Drept" });
                result.Add(new DbObject { Name = "@IdRol", Value = this.IdRol, FriendlyName = "Rol" });
                return result;
            }
        }
    }
}
