using PhamacyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms
{
    public class UserController
    {
        PharmacyContext db = new PharmacyContext();
        public void Add(User user)
        {
            User u = new User();
            u.Login = user.Login;
            u.Password = user.Password;
            u.Role = u.Role;
            db.Add(u);
            db.SaveChanges();
        }
    }
}
