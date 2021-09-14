using PhamacyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms
{
    public class AddItemsInDataBase
    {
        PharmacyContext db = new PharmacyContext();
        public void Add()
        {
            Category category1 = new Category() { Name = "Обезбливающее" };
            Category category2 = new Category() { Name = "Жаропонижающее" };
            db.Categories.AddRange(category1, category2);

            User user1 = new User() { Login = "Max", Password = "1234", Role = Roles.Client };
            User user2 = new User() { Login = "Alinka", Password = "3333", Role = Roles.Director };
            db.Users.AddRange(user1, user2);

            Order order1 = new Order() { DateSale = new DateTime(2015, 7, 20), User = user1 };
            Order order2 = new Order() { DateSale = new DateTime(2016, 12, 11),User = user2 };
            db.Orders.AddRange(order1, order2);
           
            Product product1 = new Product() 
            { Name = "Анальгин", Description = "Обезболивающее сильное", PurchasingPrice = 200, RetailPrice = 150, Quantity = 10, Category = category1, Orders = new List<Order>() { order1 } };
            Product product2 = new Product() 
            { Name = "Некст", Description = "Обезболивающее сильное", PurchasingPrice = 300, RetailPrice = 200, Quantity = 15, Category = category1, Orders = new List<Order>() { order1 } };
            Product product3 = new Product() 
            { Name = "Брал", Description = "Обезболивающее сильное", PurchasingPrice = 350, RetailPrice = 220, Quantity = 16, Category = category1, Orders = new List<Order>() { order1 } };
            Product product4 = new Product() 
            { Name = "Парацетамол", Description = "Жаропонижующее", PurchasingPrice = 400, RetailPrice = 220, Quantity = 20, Category = category2, Orders = new List<Order>() { order2 } };
            Product product5 = new Product() 
            { Name = "Ибуклин", Description = "Жаропонижующее", PurchasingPrice = 330, RetailPrice = 210, Quantity = 30, Category = category2, Orders = new List<Order>() { order2} };
            db.Products.AddRange(product1, product2, product3,product4,product5);

            db.SaveChanges();
        }
    }
}
