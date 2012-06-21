using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco.Administration
{
    public class Setare : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public string AdminPassword { get; set; }
        public int MyFirmaId { get; set; }
        public Firma MyFirma
        {
            get
            {
                return Firma.GetAll().FirstOrDefault(p => p.ID == MyFirmaId);
            }
        }
        #endregion [MEMBERS]

        #region [GestiuneObject]
        public override PersistenceResult Save()
        {
            var pr = new PersistenceResult();
            try
            {
                SetareDataHelper.GetInstance().Update(PropertiesNamesWithValues, 0);
                pr.Status = Enums.StatusEnum.Saved;
                pr.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                pr.ExceptionOccurred = ex;
                pr.Status = Enums.StatusEnum.Errors;
                pr.Message = StringSaveFail;
            }
            return pr;
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
                result.Add(new DbObject { Name = "@AdminPassword", Value = this.AdminPassword, FriendlyName = "Parola administrator" });
                result.Add(new DbObject { Name = "@MyFirmaId", Value = this.MyFirmaId, FriendlyName = "Firma mea" });
                return result;
            }
        }
        #endregion [GestiuneObject]

        private static Setare setareItem = null;
        public static Setare GetSetare()
        {
            if (setareItem == null)
            {
                setareItem = SetareDataHelper.GetInstance().GetAll().Cast<Setare>().FirstOrDefault();
            }
            return setareItem;
        }
    }
}
