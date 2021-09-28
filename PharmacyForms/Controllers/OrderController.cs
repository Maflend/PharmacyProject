using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Controllers
{
    public class OrderController
    {
        PharmacyContext db = new PharmacyContext();
        public bool Post(Order order)
        {
            var user = ContextStatic.PharmacyContext.Users.FirstOrDefault(i => i.Id == CurrentUserStatic.Id);
            var sale = SaleStatic.Sales.Select(l => l);
            if (user != null)
            {
                Order or = new Order();
                or.Sales = SaleStatic.Sales;
                or.User = user;
                or.DateSale = order.DateSale;
                ContextStatic.PharmacyContext.Orders.Add(or);
                ContextStatic.PharmacyContext.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Order> GetAll()
        {
            //var order = db.Orders.Where(o => o.User.Login == CurrentUserStatic.Login).SelectMany(o => o.Sales, (o, s) => new { o, s }).Select(os => os).ToList();
            var order = db.Orders.Where(o => o.User.Login == CurrentUserStatic.Login).Select(o => o).ToList();
            if (order != null)
                return order;
            return null;

        }
    }
}
