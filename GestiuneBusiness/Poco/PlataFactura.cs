using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;

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
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public override PersistenceResult Delete()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private static List<PlataFactura> plataFacturaList = null;

        public static List<PlataFactura> GetAll()
        {
            if (plataFacturaList == null)
            {
                plataFacturaList = new List<PlataFactura>();// TODO: data helper pt asta
            }
            return plataFacturaList;
        }

        protected override List<DbObject> PropertiesNamesWithValues
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
