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

        public abstract string NumeCompact { get; }

        public abstract PersistenceResult Save();

        public abstract PersistenceResult Delete();

        public bool Contains(string text)
        {
            if (text == string.Empty)
            {
                return true;
            }
            //string[] items = text.ToLower().Split(' ');
            //foreach (var item in items)
            //{
            foreach (var prop in PropertiesNamesWithValues)
            {
                if (prop.Value == null) continue;
                if (prop.Value.GetType() == typeof(int)) continue;
                if (prop.Value.ToString().ToLower().Contains(text)) return true;
            }
            //}
            return false;
        }

        public string GetErrorString()
        {
            string errorString = "";

            foreach (var item in PropertiesNamesWithValues)
            {
                if (item.Value == null)
                {
                    errorString += String.Format("Introduceti o valoare pentru {0}!", item.FriendlyName) + Environment.NewLine;
                    continue;
                }
                if (item.Value.GetType() == typeof(string))
                {
                    var check = (string)item.Value;
                    if (check.Trim() == string.Empty)
                    {
                        errorString += String.Format("Introduceti o valoare pentru {0}!", item.FriendlyName) + Environment.NewLine;
                    }
                    continue;
                }
                if (item.Value.GetType() == typeof(decimal))
                {
                    var check = (decimal)item.Value;
                    if (check <= 0m)
                    {
                        errorString += String.Format("Introduceti o valoare pentru {0}!", item.FriendlyName) + Environment.NewLine;
                    }
                    continue;
                }
                if (item.Value.GetType() == typeof(int))
                {
                    var check = (int)item.Value;
                    if (check == 0)
                    {
                        errorString += String.Format("Alegeti o valoare pentru {0}!", item.FriendlyName) + Environment.NewLine;
                    }
                    continue;
                }
            }
            return errorString;
        }

        public abstract List<DbObject> PropertiesNamesWithValues { get; }

        protected const string StringSaveSuccess = "Salvare efectuata cu succes!";

        protected const string StringSaveFail = "Au aparut erori in timpul salvarii! Verificati datele!";
    }
}
