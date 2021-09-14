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
        public void Post(User user)
        {
            User u = new User();
            u.Login = user.Login;
            u.Password = user.Password;
            u.Role = u.Role;
            db.Add(u);
            db.SaveChanges();
        }
        public User GetById(int id) // Проверить id перед вызовом метода
        {
            User user = new User();
            user = db.Users.FirstOrDefault(i => i.Id == id);
            return user;
        }
        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }
    }
}
