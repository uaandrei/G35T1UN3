using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class PozitieFacturaIntrare : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdFacturaIntrare { get; set; }
        public int IdStoc { get; set; }
        public FacturaIntrare FacturaIntrareObject
        {
            get
            {
                return FacturaIntrare.GetAll().FirstOrDefault(p => p.ID == IdFacturaIntrare);
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

        private static List<PozitieFacturaIntrare> pozitieFacturaIntrare = null;
        public static List<PozitieFacturaIntrare> GetAll()
        {
            if (pozitieFacturaIntrare == null) pozitieFacturaIntrare = new List<PozitieFacturaIntrare>();// TODO: data helper pt asta
            return pozitieFacturaIntrare;
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
                result.Add(new DbObject { Name = "@IdFacturaIntrare", Value = this.IdFacturaIntrare, FriendlyName = "Factura intrare" });
                result.Add(new DbObject { Name = "@IdStoc", Value = this.IdStoc, FriendlyName = "Stoc" });
                return result;
            }
        }
    }
}
