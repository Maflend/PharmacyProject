using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Controllers
{
    public class UserController
    {
        PharmacyContext db = new PharmacyContext();
        /// <summary>
        /// Adds a user to the database.
        /// </summary>
        /// <param name="user"></param>
        public void Post(User user)
        {
            User u = new User();
            u.Login = user.Login;
            u.Password = user.Password;
            u.Role = user.Role;
            db.Add(u);
            db.SaveChanges();
        }
        /// <summary>
        /// Returns user by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(int id) // Проверить id перед вызовом метода
        {
            User user = new User();
            user = db.Users.FirstOrDefault(i => i.Id == id);
            return user;
        }
        /// <summary>
        /// Returns all users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }
        /// <summary>
        /// Authorizes the user.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Login(string login, string password)
        {
            var userWithLoginAndPassword = db.Users.Where(u => u.Login == login && u.Password == password).Select(u => u).SingleOrDefault();
            return userWithLoginAndPassword;
        }
        /// <summary>
        /// If a user with such a login exists, it will return false.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool isRegistered(string login)
        {
            if(!db.Users.Any(l=>l.Login == login))
            {
                return true;
            }
            return false;
            
        }
        public List<User> FindByLogin(string input)
        {
            var users = db.Users.Where(u => u.Login.StartsWith(input)).ToList();
            return users;
        }
        public bool Update(User user)
        {
            var currentuser = db.Users.FirstOrDefault(u=>u.Id == user.Id);
            if(currentuser != null)
            {
                if(!db.Users.Any(u=>u.Login == user.Login))
                {
                    currentuser.Login = user.Login;
                    currentuser.Role = user.Role;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
           
        }
        public bool Delete(int id)
        {
            var user = GetById(id);
            if(user != null && user.Role != Roles.Admin)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
