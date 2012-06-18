using System.Collections.Generic;
using System.Linq;
using GestiuneBusiness.Poco.Administration;

namespace GestiuneBusiness.Logic
{
    public class UserAuthentication
    {
        public List<Drept> GetRights(Utilizator user)
        {
            var rightList = RolDrept.GetAll().Where(p => p.IdRol == user.IdRol).Select(p => p.DreptObject).ToList();
            return rightList;
        }

        public Utilizator Authenticate(string username, string password)
        {
            var user = Utilizator.GetAll().Where(p => p.Nume == username && p.Parola == password).FirstOrDefault();
            return user;
        }
    }
}
