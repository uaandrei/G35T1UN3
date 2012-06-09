using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneBusiness.Interfaces
{
    internal interface IDataPersistence
    {
        PersistenceResult Save();
        PersistenceResult Delete();
    }
}
