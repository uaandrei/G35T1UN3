using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.DataHelper;

namespace GestiuneBusiness.Poco
{
    public class PlataFactura : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdPlata { get; set; }
        public int IdFactura { get; set; }
        public string TipFactura { get; set; }
        public Plata PlataObject
        {
            get
            {
                return Plata.GetAll().FirstOrDefault(p => p.ID == IdPlata);
            }
        }
        public Object Factura
        {
            get
            {
                if (TipFactura == "Intrare")
                {
                    return FacturaIntrare.GetAll().FirstOrDefault(p => p.ID == IdFactura);
                }
                else
                {
                    return FacturaIesire.GetAll().FirstOrDefault(p => p.ID == IdFactura);
                }
            }
        }
        #endregion

        public override PersistenceResult Save()
        {
            var result = new PersistenceResult();
            try
            {
                if (this.ID == 0)
                {
                    this.ID = PlatiFacturiDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (plataFacturaList == null)
                    {
                        plataFacturaList = new List<PlataFactura>();
                    }
                    plataFacturaList.Add(this);
                }
                else
                {
                    PlatiFacturiDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                result.Message = StringSaveSuccess;
                result.Status = Enums.StatusEnum.Saved;
            }
            catch (Exception ex)
            {
                result.Message = StringSaveFail;
                result.Status = Enums.StatusEnum.Errors;
                result.ExceptionOccurred = ex;
            }
            return result;
        }

        public override PersistenceResult Delete()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private static List<PlataFactura> plataFacturaList = null;

        public static List<PlataFactura> GetAll()
        {
            try
            {
                if (plataFacturaList == null)
                {
                    plataFacturaList = PlatiFacturiDataHelper.GetInstance().GetAll().Cast<PlataFactura>().ToList();
                }
                return plataFacturaList;
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
                result.Add(new DbObject { Name = "@IdFactura", Value = this.IdFactura, FriendlyName = "Factura" });
                result.Add(new DbObject { Name = "@IdPlata", Value = this.IdPlata, FriendlyName = "Plata" });
                result.Add(new DbObject { Name = "@TipFactura", Value = this.TipFactura, FriendlyName = "Tip Factura" });
                return result;
            }
        }
    }
}
