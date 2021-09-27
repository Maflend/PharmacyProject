using PharmacyForms.Models;
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
           
            Category category1 = new Category() { Categories = Categories.Болеутоляющие };
            Category category2 = new Category() { Categories = Categories.Жаропонижающие };
            Category category3 = new Category() { Categories = Categories.Витамины};
            Category category4 = new Category() { Categories = Categories.Антибиотики };
            Category category5 = new Category() { Categories = Categories.Противовирусные };
            db.Categories.AddRange(category1, category2, category3, category4, category5);

            User user1 = new User() { Login = "MaximSolnce", Password = "Top123123", Role = Roles.Client };
            User user2 = new User() { Login = "AlinkaMalinka", Password = "Kot123FDF23", Role = Roles.Director };
            User user3 = new User() { Login = "BlueFilen", Password = "Rot333FF33", Role = Roles.Stuff };
            User user5 = new User() { Login = "Amerika", Password = "GoGo12345", Role = Roles.Stuff };
            User user6 = new User() { Login = "RusiOOOua", Password = "Tropolom123", Role = Roles.Stuff };
            User user4 = new User() { Login = "PokermanSS", Password = "Dvorf12345", Role = Roles.Client };
            User userA = new User() { Login = "Admin", Password = "Admin", Role = Roles.Admin };
            db.Users.AddRange(user1, user2,user3 ,user4,user5,user6,userA);

           

          

            Product product11 = new Product()
            { Name = "Анальгин", Description = "Обезболивающее сильное", PurchasingPrice = 200, RetailPrice = 150, Quantity = 10, Category = category1 };
            Product product12 = new Product()
            { Name = "Некст", Description = "Обезболивающее сильное", PurchasingPrice = 300, RetailPrice = 200, Quantity = 15, Category = category1};
            Product product13 = new Product()
            { Name = "Брал", Description = "Обезболивающее сильное", PurchasingPrice = 350, RetailPrice = 220, Quantity = 16, Category = category1 };
            Product product14 = new Product()
            { Name = "Тералив", Description = "Обезболивающее сильное", PurchasingPrice = 440, RetailPrice = 275, Quantity = 66, Category = category1 };
            Product product15 = new Product()
            { Name = "Нурофен", Description = "Таблетки", PurchasingPrice = 280, RetailPrice = 210, Quantity = 55, Category = category1 };
            Product product16 = new Product()
            { Name = "Артрозилен", Description = "Гель", PurchasingPrice = 500, RetailPrice = 420, Quantity = 43, Category = category1 };
            Product product17 = new Product()
            { Name = "Ихтиол суппозитории", Description = "200 мг 10 шт", PurchasingPrice = 720, RetailPrice = 530, Quantity = 88, Category = category1 };
            Product product18 = new Product()
            { Name = "Аленталь", Description = "таблетки 100 мг 20 шт", PurchasingPrice = 744, RetailPrice = 570, Quantity = 48, Category = category1 };
            Product product21 = new Product()
            // ...
            { Name = "Парацетамол", Description = "Жаропонижующее", PurchasingPrice = 400, RetailPrice = 220, Quantity = 53, Category = category2 };
            Product product22 = new Product()
            { Name = "Ибуклин", Description = "Жаропонижующее", PurchasingPrice = 770, RetailPrice = 410, Quantity = 44, Category = category2};
            Product product23 = new Product()
            { Name = "Максиколд", Description = "Максиколд рино чай", PurchasingPrice = 1220, RetailPrice = 1000, Quantity = 100, Category = category2 };
            Product product24 = new Product()
            { Name = "Solpadeine", Description = "24 таблетки", PurchasingPrice = 430, RetailPrice = 290, Quantity = 35, Category = category2};
            Product product25 = new Product()
            { Name = "Пентальгин", Description = "Жаропонижующее", PurchasingPrice = 330, RetailPrice = 210, Quantity = 30, Category = category2 };
            Product product26 = new Product()
            { Name = "Панадол", Description = "Один из самых известных и часто применяемых жаропонижающих препаратов.", PurchasingPrice = 330, RetailPrice = 210, Quantity = 67, Category = category2 };
            Product product27 = new Product()
            { Name = "Калпол", Description = "аксимальные дозы: разовая – 1 г, суточная – 4 г. Детям в возрасте 6–12 лет рекомендуется принимать зараз 250–500 мг препарата. ", PurchasingPrice = 550, RetailPrice = 120, Quantity = 34, Category = category2 };
            Product product28 = new Product()
            { Name = "Эффералган", Description = "Разовые дозы при ректальном применении у детей в возрасте 6–12 лет – 250–500 мг, 1–5 лет – 125–250 мг. ", PurchasingPrice = 550, RetailPrice = 440, Quantity = 60, Category = category2};
            // ...
            Product product31 = new Product()
            { Name = "Супрадин", Description = "Таблетки шипучие", PurchasingPrice = 120, RetailPrice = 90, Quantity = 10, Category = category3 };
            Product product32 = new Product()
            { Name = "Суперум", Description = "Витамин Д3 2000ме(50 мкг)капсулы", PurchasingPrice = 680, RetailPrice = 550, Quantity = 10, Category = category3 };
            Product product33 = new Product()
            { Name = "Берокка", Description = "Таблеткишипучие", PurchasingPrice = 440, RetailPrice = 330, Quantity = 60, Category = category3 };
            Product product34 = new Product()
            { Name = "Токоферол", Description = "Раствор для приема внутрь 30%", PurchasingPrice = 880, RetailPrice = 550, Quantity = 50, Category = category3 };
            Product product35 = new Product()
            { Name = "Биотредин", Description = "Таблетки сублингвальные", PurchasingPrice = 760, RetailPrice = 630, Quantity = 40, Category = category3 };
            Product product36 = new Product()
            { Name = "Витамин С", Description = "Таблетки шипучие", PurchasingPrice = 700, RetailPrice = 460, Quantity = 30, Category = category3 };
            Product product37 = new Product()
            { Name = "Витамин Е", Description = "Раствор масляный 10% ", PurchasingPrice = 860, RetailPrice = 740, Quantity = 44, Category = category3 };
            Product product38 = new Product()
            { Name = "Витамир витамин Е ", Description = "Таблетки", PurchasingPrice = 740, RetailPrice = 610, Quantity = 55, Category = category3 };
            Product product39 = new Product()
            { Name = "Лимонтар", Description = "Таблетки растворимые", PurchasingPrice = 230, RetailPrice = 150, Quantity = 12, Category = category3 };
            Product product331 = new Product()
            { Name = "Аскорутин Фармстандарт", Description = "Фармстандарт таблетки", PurchasingPrice = 1100, RetailPrice = 980, Quantity = 10, Category = category3 };
            Product product332 = new Product()
            { Name = "Дуовит", Description = "Таблетки", PurchasingPrice = 2000, RetailPrice = 1500, Quantity = 10, Category = category3};
            // ...
            Product product41 = new Product()
            { Name = "Суматролид Солюшн Таблетс", Description = "Таблетки", PurchasingPrice = 1200, RetailPrice = 990, Quantity = 50, Category = category4 };
            Product product42 = new Product()
            { Name = "Кларитромицин Верте", Description = "Таблетки покрытые оболочкой", PurchasingPrice = 300, RetailPrice = 150, Quantity = 40, Category = category4 };
            Product product43 = new Product()
            { Name = "Кларитромицин", Description = "Капсулы", PurchasingPrice = 2000, RetailPrice = 1500, Quantity = 17, Category = category4 };
            Product product44 = new Product()
            { Name = "Абактал", Description = "Таблетки покрытые оболочкой", PurchasingPrice = 1400, RetailPrice = 1000, Quantity = 10, Category = category4 };
            Product product45 = new Product()
            { Name = "Азитромицин Верте", Description = "Капсулы", PurchasingPrice = 1200, RetailPrice = 1000, Quantity = 19, Category = category4 };
            Product product46 = new Product()
            { Name = "Амоксиклав", Description = "Порошок", PurchasingPrice = 570, RetailPrice = 390, Quantity = 15, Category = category4 };
            // ...
            Product product51 = new Product()
            { Name = "Альфарон", Description = "Таблетки", PurchasingPrice = 139, RetailPrice = 990, Quantity = 17, Category = category5 };
            Product product52 = new Product()
            { Name = "Циклоферон", Description = "Таблетки", PurchasingPrice = 764, RetailPrice = 536, Quantity = 11, Category = category5 };
            Product product53 = new Product()
            { Name = "Тилорон", Description = "Таблетки", PurchasingPrice = 400, RetailPrice = 330, Quantity = 20, Category = category5 };
            Product product54 = new Product()
            { Name = "Кагоцел", Description = "Таблетки", PurchasingPrice = 754, RetailPrice = 544, Quantity = 21, Category = category5 };
            Product product55 = new Product()
            { Name = "Виферон", Description = "Таблетки", PurchasingPrice = 570, RetailPrice = 390, Quantity = 74, Category = category5 };
            Product product56 = new Product()
            { Name = "Гриппферон", Description = "Таблетки", PurchasingPrice = 2100, RetailPrice = 1770, Quantity = 44, Category = category5 };


            db.Products.AddRange(product11, product12, product13, product14, product15, product16, product17, product18);
            db.Products.AddRange(product21, product22, product23, product24, product25, product26, product27, product28);
            db.Products.AddRange(product31, product32, product33, product34, product35, product36, product37, product38, product39, product331, product332);
            db.Products.AddRange(product41, product42, product43, product44, product45, product46);
            db.Products.AddRange(product51, product52, product53, product54, product55, product56);


            Sale sale1 = new Sale() { Quantity = 5, Product = product11};
            Sale sale2 = new Sale() { Quantity = 14, Product = product12 };
            Sale sale3 = new Sale() { Quantity = 14, Product = product13 };
            Sale sale4 = new Sale() { Quantity = 14, Product = product11 };
            Sale sale5 = new Sale() { Quantity = 22, Product = product15 };

            db.Sales.AddRange(sale1, sale2, sale3,sale4,sale5);


            Order order1 = new Order() { DateSale = new DateTime(2015, 7, 20), User = user1, Sales = new List<Sale>() {sale1,sale2,sale3 } };
            Order order2 = new Order() { DateSale = new DateTime(2016, 12, 11), User = user2, Sales = new List<Sale>() {sale4,sale5 } };
            db.Orders.AddRange(order1, order2);
            db.SaveChanges();
        }
    }
}
