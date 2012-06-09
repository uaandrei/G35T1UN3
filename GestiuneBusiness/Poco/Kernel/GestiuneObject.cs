using System;
using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Interfaces;

namespace GestiuneBusiness.Poco.Kernel
{
    public abstract class GestiuneObject : IDataPersistence
    {
        public int ID { get; set; }

        public abstract PersistenceResult Save();

        public abstract PersistenceResult Delete();

        protected abstract List<DbObject> PropertiesNamesWithValues { get; }

        protected const string StringSaveSuccess = "Salvare efectuata cu success!";

        protected const string StringSaveFail = "Au aparut erori in timpul salvarii!";
    }
}
