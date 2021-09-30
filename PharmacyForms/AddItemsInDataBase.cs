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
            { Name = "Анальгин", Description = "Обезболивающее сильное", PurchasingPrice = 200, RetailPrice = 330, Quantity = 10, Category = category1 };
            Product product12 = new Product()
            { Name = "Некст", Description = "Обезболивающее сильное", PurchasingPrice = 300, RetailPrice = 350, Quantity = 15, Category = category1};
            Product product13 = new Product()
            { Name = "Брал", Description = "Обезболивающее сильное", PurchasingPrice = 350, RetailPrice = 520, Quantity = 16, Category = category1 };
            Product product14 = new Product()
            { Name = "Тералив", Description = "Обезболивающее сильное", PurchasingPrice = 440, RetailPrice = 675, Quantity = 66, Category = category1 };
            Product product15 = new Product()
            { Name = "Нурофен", Description = "Таблетки", PurchasingPrice = 280, RetailPrice = 510, Quantity = 55, Category = category1 };
            Product product16 = new Product()
            { Name = "Артрозилен", Description = "Гель", PurchasingPrice = 500, RetailPrice = 720, Quantity = 43, Category = category1 };
            Product product17 = new Product()
            { Name = "Ихтиол суппозитории", Description = "200 мг 10 шт", PurchasingPrice = 720, RetailPrice = 830, Quantity = 88, Category = category1 };
            Product product18 = new Product()
            { Name = "Аленталь", Description = "таблетки 100 мг 20 шт", PurchasingPrice = 744, RetailPrice = 970, Quantity = 48, Category = category1 };
            Product product19 = new Product()
            { Name = "Аспирин", Description = "Таблетки", PurchasingPrice = 150, RetailPrice = 290, Quantity = 81, Category = category1 };
            Product product110 = new Product()
            { Name = "Ибупрофен", Description = "Таблетки", PurchasingPrice = 250, RetailPrice = 398, Quantity = 46, Category = category1 };
            Product product111 = new Product()
            { Name = "Нимесулид", Description = "Таблетки", PurchasingPrice = 780, RetailPrice = 840, Quantity = 15, Category = category1 };
            Product product112 = new Product()
            { Name = "Нанопласт", Description = "Пластырь", PurchasingPrice = 120, RetailPrice = 150, Quantity = 59, Category = category1 };
            Product product113 = new Product()
            { Name = "Флексопрофен", Description = "Раствор для инъекций", PurchasingPrice = 345, RetailPrice = 499, Quantity = 36, Category = category1 };
            Product product114 = new Product()
            { Name = "Долгит", Description = "Крем", PurchasingPrice = 250, RetailPrice = 400, Quantity = 144, Category = category1 };
            Product product115 = new Product()
            { Name = "Нурофен Экспресс", Description = "Таблетки", PurchasingPrice = 280, RetailPrice = 400, Quantity = 14, Category = category1 };
            Product product116 = new Product()
            { Name = "Найз", Description = "Таблетки", PurchasingPrice = 138, RetailPrice = 308, Quantity = 159, Category = category1 };
            Product product117 = new Product()
            { Name = "Вольтарен Эмульгель", Description = "Гель", PurchasingPrice = 289, RetailPrice = 499, Quantity = 65, Category = category1 };
            Product product118 = new Product()
            { Name = "Нимесил", Description = "Гранулы для приготовления суспензии", PurchasingPrice = 365, RetailPrice = 478, Quantity = 598, Category = category1 };
            Product product119 = new Product()
            { Name = "Мелоксикам", Description = "Таблетки", PurchasingPrice = 456, RetailPrice = 558, Quantity = 69, Category = category1 };
            Product product120 = new Product()
            { Name = "Кетонал", Description = "Капсулы", PurchasingPrice = 495, RetailPrice = 699, Quantity = 158, Category = category1 };

            //...

            Product product21 = new Product()
            { Name = "Парацетамол", Description = "Жаропонижающее", PurchasingPrice = 200, RetailPrice = 420, Quantity = 53, Category = category2 };
            Product product22 = new Product()
            { Name = "Ибуклин", Description = "Жаропонижающее", PurchasingPrice = 470, RetailPrice = 710, Quantity = 44, Category = category2};
            Product product23 = new Product()
            { Name = "Максиколд", Description = "Максиколд рино чай", PurchasingPrice = 920, RetailPrice = 1000, Quantity = 100, Category = category2 };
            Product product24 = new Product()
            { Name = "Solpadeine", Description = "Таблетки", PurchasingPrice = 430, RetailPrice = 690, Quantity = 35, Category = category2};
            Product product25 = new Product()
            { Name = "Пенталгин", Description = "Жаропонижающее", PurchasingPrice = 330, RetailPrice = 410, Quantity = 30, Category = category2 };
            Product product26 = new Product()
            { Name = "Панадол", Description = "Один из самых известных и часто применяемых жаропонижающих препаратов.", PurchasingPrice = 330, RetailPrice = 510, Quantity = 67, Category = category2 };
            Product product27 = new Product()
            { Name = "Калпол", Description = "аксимальные дозы: разовая – 1 г, суточная – 4 г. Детям в возрасте 6–12 лет рекомендуется принимать зараз 250–500 мг препарата. ", PurchasingPrice = 350, RetailPrice = 520, Quantity = 34, Category = category2 };
            Product product28 = new Product()
            { Name = "Эффералган", Description = "Разовые дозы при ректальном применении у детей в возрасте 6–12 лет – 250–500 мг, 1–5 лет – 125–250 мг. ", PurchasingPrice = 450, RetailPrice = 640, Quantity = 60, Category = category2};
            Product product29 = new Product()
            { Name = "Ринза", Description = "Таблетки", PurchasingPrice = 468, RetailPrice = 610, Quantity = 46, Category = category2 };
            Product product210 = new Product()
            { Name = "Аспирин", Description = "Таблетки", PurchasingPrice = 56, RetailPrice = 128, Quantity = 165, Category = category2 };
            Product product211 = new Product()
            { Name = "Панадол", Description = "Таблетки", PurchasingPrice = 448, RetailPrice = 500, Quantity = 16, Category = category2 };
            Product product212 = new Product()
            { Name = "Мигренол", Description = "Таблетки", PurchasingPrice = 38, RetailPrice = 55, Quantity = 89, Category = category2 };
            Product product213 = new Product()
            { Name = "Парален экстра", Description = "Таблетки", PurchasingPrice = 594, RetailPrice = 785, Quantity = 15, Category = category2 };
            Product product214 = new Product()
            { Name = "Юниспаз", Description = "Таблетки", PurchasingPrice = 459, RetailPrice = 665, Quantity = 154, Category = category2 };
            Product product215 = new Product()
            { Name = "Панадеин", Description = "Таблетки", PurchasingPrice = 365, RetailPrice = 500, Quantity = 23, Category = category2 };
            Product product216 = new Product()
            { Name = "Гриппостад", Description = "Таблетки", PurchasingPrice = 495, RetailPrice = 601, Quantity = 36, Category = category2 };
            Product product217 = new Product()
            { Name = "Далерон С", Description = "Таблетки", PurchasingPrice = 369, RetailPrice = 503, Quantity = 236, Category = category2 };
            Product product218 = new Product()
            { Name = "Фебрицед", Description = "Таблетки", PurchasingPrice = 598, RetailPrice = 689, Quantity = 26, Category = category2 };
            Product product219 = new Product()
            { Name = "Цитрамон", Description = "Таблетки", PurchasingPrice = 36, RetailPrice = 50, Quantity = 239, Category = category2 };
            Product product220 = new Product()
            { Name = "Буфферин", Description = "Таблетки", PurchasingPrice = 956, RetailPrice = 1299, Quantity = 2, Category = category2 };

            // ...

            Product product31 = new Product()
            { Name = "Супрадин", Description = "Таблетки шипучие", PurchasingPrice = 120, RetailPrice = 150, Quantity = 10, Category = category3 };
            Product product32 = new Product()
            { Name = "Суперум", Description = "Витамин Д3 2000ме(50 мкг)капсулы", PurchasingPrice = 480, RetailPrice = 550, Quantity = 10, Category = category3 };
            Product product33 = new Product()
            { Name = "Берокка", Description = "Таблеткишипучие", PurchasingPrice = 440, RetailPrice = 530, Quantity = 60, Category = category3 };
            Product product34 = new Product()
            { Name = "Токоферол", Description = "Раствор для приема внутрь 30%", PurchasingPrice = 680, RetailPrice = 850, Quantity = 50, Category = category3 };
            Product product35 = new Product()
            { Name = "Биотредин", Description = "Таблетки сублингвальные", PurchasingPrice = 760, RetailPrice = 830, Quantity = 40, Category = category3 };
            Product product36 = new Product()
            { Name = "Витамин С", Description = "Таблетки шипучие", PurchasingPrice = 700, RetailPrice = 860, Quantity = 30, Category = category3 };
            Product product37 = new Product()
            { Name = "Витамин Е", Description = "Раствор масляный 10% ", PurchasingPrice = 860, RetailPrice = 940, Quantity = 44, Category = category3 };
            Product product38 = new Product()
            { Name = "Витамир витамин Е ", Description = "Таблетки", PurchasingPrice = 740, RetailPrice = 810, Quantity = 55, Category = category3 };
            Product product39 = new Product()
            { Name = "Лимонтар", Description = "Таблетки растворимые", PurchasingPrice = 230, RetailPrice = 350, Quantity = 12, Category = category3 };
            Product product310 = new Product()
            { Name = "Аскорутин Фармстандарт", Description = "Фармстандарт таблетки", PurchasingPrice = 1100, RetailPrice = 1380, Quantity = 10, Category = category3 };
            Product product311 = new Product()
            { Name = "Дуовит", Description = "Таблетки", PurchasingPrice = 2000, RetailPrice = 2200, Quantity = 10, Category = category3};
            Product product312 = new Product()
            { Name = "Пентовит", Description = "Таблетки", PurchasingPrice = 128, RetailPrice = 299, Quantity = 16, Category = category3 };
            Product product313 = new Product()
            { Name = "Пиковит", Description = "Сироп", PurchasingPrice = 698, RetailPrice = 868, Quantity = 167, Category = category3 };
            Product product314 = new Product()
            { Name = "Ревит", Description = "Драже", PurchasingPrice = 45, RetailPrice = 67, Quantity = 197, Category = category3 };
            Product product315 = new Product()
            { Name = "Селмевит", Description = "Таблетки", PurchasingPrice = 299, RetailPrice = 403, Quantity = 145, Category = category3 };
            Product product316 = new Product()
            { Name = "Токоферола ацетат", Description = "Капсулы", PurchasingPrice = 24, RetailPrice = 31, Quantity = 198, Category = category3 };
            Product product317 = new Product()
            { Name = "Триовит", Description = "Капсулы", PurchasingPrice = 466, RetailPrice = 768, Quantity = 14, Category = category3 };
            Product product318 = new Product()
            { Name = "Фолиевая кислота", Description = "Таблетки", PurchasingPrice = 44, RetailPrice = 83, Quantity = 175, Category = category3 };
            Product product319 = new Product()
            { Name = "Ангиовит", Description = "Таблетки", PurchasingPrice = 243, RetailPrice = 339, Quantity = 26, Category = category3 };
            Product product320 = new Product()
            { Name = "Компливит", Description = "Таблетки", PurchasingPrice = 228, RetailPrice = 350, Quantity = 965, Category = category3 };

            // ...

            Product product41 = new Product()
            { Name = "Суматролид Солюшн Таблетс", Description = "Таблетки", PurchasingPrice = 1200, RetailPrice = 1390, Quantity = 50, Category = category4 };
            Product product42 = new Product()
            { Name = "Кларитромицин Верте", Description = "Таблетки покрытые оболочкой", PurchasingPrice = 300, RetailPrice = 550, Quantity = 40, Category = category4 };
            Product product43 = new Product()
            { Name = "Кларитромицин", Description = "Капсулы", PurchasingPrice = 2000, RetailPrice = 2300, Quantity = 17, Category = category4 };
            Product product44 = new Product()
            { Name = "Абактал", Description = "Таблетки покрытые оболочкой", PurchasingPrice = 1400, RetailPrice = 1800, Quantity = 10, Category = category4 };
            Product product45 = new Product()
            { Name = "Азитромицин Верте", Description = "Капсулы", PurchasingPrice = 1200, RetailPrice = 1600, Quantity = 19, Category = category4 };
            Product product46 = new Product()
            { Name = "Амоксиклав", Description = "Порошок", PurchasingPrice = 570, RetailPrice = 790, Quantity = 15, Category = category4 };
            Product product47 = new Product()
            { Name = "Левомикон", Description = "Мазь", PurchasingPrice = 118, RetailPrice = 189, Quantity = 58, Category = category4 };
            Product product48 = new Product()
            { Name = "Кларитромицин", Description = "Капсулы", PurchasingPrice = 208, RetailPrice = 350, Quantity = 65, Category = category4 };
            Product product49 = new Product()
            { Name = "Абактал", Description = "Таблетки", PurchasingPrice = 308, RetailPrice = 449, Quantity = 5, Category = category4 };
            Product product410 = new Product()
            { Name = "Амоксиклав", Description = "Таблетки", PurchasingPrice = 408, RetailPrice = 569, Quantity = 75, Category = category4 };
            Product product411= new Product()
            { Name = "Аргосульфан", Description = "Мазь", PurchasingPrice = 593, RetailPrice = 701, Quantity = 85, Category = category4 };
            Product product412 = new Product()
            { Name = "Бисептол", Description = "Таблетки", PurchasingPrice = 37, RetailPrice = 59, Quantity = 756, Category = category4 };
            Product product413 = new Product()
            { Name = "Гентамицил", Description = "Мазь", PurchasingPrice = 131, RetailPrice = 298, Quantity = 62, Category = category4 };
            Product product414 = new Product()
            { Name = "Диоксидин", Description = "Раствор для инъекций", PurchasingPrice = 564, RetailPrice = 685, Quantity = 67, Category = category4 };
            Product product415 = new Product()
            { Name = "Левомеколь", Description = "Мазь", PurchasingPrice = 187, RetailPrice = 300, Quantity = 659, Category = category4 };
            Product product416 = new Product()
            { Name = "Линкомицина", Description = "Раствор ампулы", PurchasingPrice = 138, RetailPrice = 385, Quantity = 45, Category = category4 };
            Product product417 = new Product()
            { Name = "Метрогил", Description = "Гель", PurchasingPrice = 236, RetailPrice = 495, Quantity = 7, Category = category4 };
            Product product418 = new Product()
            { Name = "Монурал", Description = "Порошок для раствора", PurchasingPrice = 855, RetailPrice = 926, Quantity = 15, Category = category4 };
            Product product419 = new Product()
            { Name = "Нолицин", Description = "Таблетки", PurchasingPrice = 256, RetailPrice = 397, Quantity = 89, Category = category4 };
            Product product420 = new Product()
            { Name = "Норбактин", Description = "Таблетки", PurchasingPrice = 239, RetailPrice = 369, Quantity = 85, Category = category4 };

            // ...

            Product product51 = new Product()
            { Name = "Альфарон", Description = "Таблетки", PurchasingPrice = 139, RetailPrice = 990, Quantity = 17, Category = category5 };
            Product product52 = new Product()
            { Name = "Циклоферон", Description = "Таблетки", PurchasingPrice = 764, RetailPrice = 936, Quantity = 11, Category = category5 };
            Product product53 = new Product()
            { Name = "Тилорон", Description = "Таблетки", PurchasingPrice = 300, RetailPrice = 430, Quantity = 20, Category = category5 };
            Product product54 = new Product()
            { Name = "Кагоцел", Description = "Таблетки", PurchasingPrice = 754, RetailPrice = 844, Quantity = 21, Category = category5 };
            Product product55 = new Product()
            { Name = "Виферон", Description = "Таблетки", PurchasingPrice = 370, RetailPrice = 590, Quantity = 74, Category = category5 };
            Product product56 = new Product()
            { Name = "Гриппферон", Description = "Таблетки", PurchasingPrice = 2100, RetailPrice = 2770, Quantity = 44, Category = category5 };
            Product product57 = new Product()
            { Name = "Арбидол", Description = "Капсулы", PurchasingPrice = 549, RetailPrice = 780, Quantity = 568, Category = category5 };
            Product product58 = new Product()
            { Name = "Тамифлю", Description = "Капсулы", PurchasingPrice = 1589, RetailPrice = 1990, Quantity = 28, Category = category5 };
            Product product59 = new Product()
            { Name = "Синекод", Description = "Сироп", PurchasingPrice = 410, RetailPrice = 690, Quantity = 64, Category = category5 };
            Product product510 = new Product()
            { Name = "Виброцил", Description = "Капли", PurchasingPrice = 349, RetailPrice = 500, Quantity = 856, Category = category5 };
            Product product511 = new Product()
            { Name = "Отривин", Description = "Спрей", PurchasingPrice = 185, RetailPrice = 205, Quantity = 654, Category = category5 };
            Product product512 = new Product()
            { Name = "Терафлю", Description = "Порошок", PurchasingPrice = 599, RetailPrice = 709, Quantity = 1256, Category = category5 };
            Product product513 = new Product()
            { Name = "Релпакс", Description = "Таблетки", PurchasingPrice = 494, RetailPrice = 605, Quantity = 5, Category = category5 };
            Product product514 = new Product()
            { Name = "Африн", Description = "Спрей назальный", PurchasingPrice = 312, RetailPrice = 374, Quantity = 72, Category = category5 };
            Product product515 = new Product()
            { Name = "АнтиГриппин", Description = "Таблетки шипучие", PurchasingPrice = 390, RetailPrice = 500, Quantity = 7, Category = category5 };
            Product product516 = new Product()
            { Name = "Антифлу кидс", Description = "Порошок", PurchasingPrice = 265, RetailPrice = 300, Quantity = 45, Category = category5 };
            Product product517 = new Product()
            { Name = "Арепливир", Description = "Таблетки", PurchasingPrice = 5709, RetailPrice = 7500, Quantity = 2, Category = category5 };
            Product product518 = new Product()
            { Name = "Оксолин", Description = "Мазь", PurchasingPrice = 125, RetailPrice = 330, Quantity = 746, Category = category5 };
            Product product519 = new Product()
            { Name = "Календулы настойка", Description = "Настойка", PurchasingPrice = 29, RetailPrice = 49, Quantity = 698, Category = category5 };
            Product product520 = new Product()
            { Name = "Эвкалипт", Description = "Настойка", PurchasingPrice = 41, RetailPrice = 50, Quantity = 236, Category = category5 };


            db.Products.AddRange(product11, product12, product13, product14, product15, product16, product17, product18, product19, product110, product111, product112, product113, product114, product115, product116, product117, product118, product119, product120);
            db.Products.AddRange(product21, product22, product23, product24, product25, product26, product27, product28, product29, product210, product211, product212, product213, product214, product215, product216, product217, product218, product219, product220);
            db.Products.AddRange(product31, product32, product33, product34, product35, product36, product37, product38, product39, product310, product311, product312, product313, product314, product315, product316, product317, product318, product319, product320);
            db.Products.AddRange(product41, product42, product43, product44, product45, product46, product47, product48, product49, product410, product411, product412, product413, product314, product415, product416, product417, product418, product419, product420);
            db.Products.AddRange(product51, product52, product53, product54, product55, product56, product57, product58, product59, product510, product511, product512, product513, product514, product515, product516, product517, product518, product519, product520);


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
