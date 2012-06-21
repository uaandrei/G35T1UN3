using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Poco
{
    public class Stoc : GestiuneBusiness.Poco.Kernel.GestiuneObject
    {
        #region [MEMBERS]
        public int IdProdus { get; set; }
        public int IdPozitieFacturaIntrare { get; set; }
        public decimal Cantitate { get; set; }
        public PozitieFacturaIntrare PozitieFacturaIntrareObject
        {
            get { return PozitieFacturaIntrare.GetAll().FirstOrDefault(p => p.ID == IdPozitieFacturaIntrare); }
        }
        public Produs ProdusObject
        {
            get
            {
                return Produs.GetAll().FirstOrDefault(p => p.ID == IdProdus);
            }
        }
        public string NumeProdus
        {
            get
            {
                return this.ProdusObject.Nume;
            }
        }
        #endregion

        public override DataHelper.Kernel.PersistenceResult Save()
        {
            PersistenceResult persistenceResult = new PersistenceResult();

            try
            {
                if (this.ID == 0) // => obiect nou
                {
                    this.ID = StocDataHelper.GetInstance().Create(PropertiesNamesWithValues);
                    if (stocList == null)
                    {
                        stocList = new List<Stoc>();
                    }
                    stocList.Add(this);
                }

                else // => obiect existent
                {
                    StocDataHelper.GetInstance().Update(PropertiesNamesWithValues, this.ID);
                }
                persistenceResult.Status = Enums.StatusEnum.Saved;
                persistenceResult.Message = StringSaveSuccess;
            }
            catch (Exception ex)
            {
                persistenceResult.Status = Enums.StatusEnum.Errors;
                persistenceResult.Message = StringSaveFail;
                persistenceResult.ExceptionOccurred = ex;
            }
            return persistenceResult;
        }

        public override DataHelper.Kernel.PersistenceResult Delete()
        {
            throw new NotImplementedException();
        }

        internal static List<Stoc> stocList = null;
        public static List<Stoc> GetAll()
        {
            try
            {
                if (stocList == null)
                {
                    stocList = StocDataHelper.GetInstance().GetAll().Cast<Stoc>().ToList();
                }
                return stocList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Id-ul pozitiei de intrare nu reflecta stocul insumat, deoarece un stoc poate contine produse din mai multe facturi de intrare.
        /// </summary>
        public static List<Stoc> GetAllGroupedByProdus(string produsName = "")
        {
            var query = from s in Stoc.GetAll()
                        where s.NumeProdus.ToLower().Contains(produsName.ToLower())
                        group s by s.IdProdus into s_nou
                        select new Stoc
                        {
                            ID = s_nou.Max(p => p.ID),
                            Cantitate = s_nou.Sum(p => p.Cantitate),
                            IdPozitieFacturaIntrare = s_nou.Select(p => p.IdPozitieFacturaIntrare).First(),
                            IdProdus = s_nou.Select(p => p.IdProdus).First()
                        };
            return query.ToList();
        }

        public override List<DbObject> PropertiesNamesWithValues
        {
            get
            {
                List<DbObject> result = new List<DbObject>();
                result.Add(new DbObject { Name = "@IdProdus", Value = this.IdProdus, FriendlyName = "Produs" });
                result.Add(new DbObject { Name = "@Cantitate", Value = this.Cantitate, FriendlyName = "Cantitate produs" });
                result.Add(new DbObject { Name = "@IdPozitieFacturaIntrare", Value = this.IdPozitieFacturaIntrare, FriendlyName = "Serie factura intrare" });
                return result;
            }
        }
    }
}
