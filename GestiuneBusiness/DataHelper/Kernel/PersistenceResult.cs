using System;
using System.Linq;
using GestiuneBusiness.Enums;

namespace GestiuneBusiness.DataHelper.Kernel
{
    public class PersistenceResult
    {
        public EnumStatus Status { get; set; }
        public string Message { get; set; }
        public Exception ExceptionOccurred { get; set; }
        public Object Result { get; set; }
    }
}

