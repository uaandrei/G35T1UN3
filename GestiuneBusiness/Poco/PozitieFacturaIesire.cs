using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class PozitieFacturaIesire : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdFacturaIesire { get; set; }
        public int IdStoc { get; set; }
        public FacturaIesire FacturaIesireObject
        {
            get
            {
                return FacturaIesire.GetAll().FirstOrDefault(p => p.ID == IdFacturaIesire);
            }
        }
        public Stoc StocObject
        {
            get
            {
                return Stoc.GetAll().FirstOrDefault(p => p.ID == IdStoc);
            }
        }
        #endregion

        private List<PozitieFacturaIesire> pozitieFacturaIesire = null;
        public List<PozitieFacturaIesire> GetAll()
        {
            if (pozitieFacturaIesire == null) pozitieFacturaIesire = new List<PozitieFacturaIesire>();// TODO: data helper pt asta
            return pozitieFacturaIesire;
        }

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

        protected override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@IdFacturaIesire", Value = this.IdFacturaIesire, FriendlyName = "Factura iesire" });
                result.Add(new DbObject { Name = "@IdStoc", Value = this.IdStoc, FriendlyName = "Stoc" });
                return result;
            }
        }
    }
}
