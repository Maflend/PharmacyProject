using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Controllers
{
    public class ProductController
    {
        PharmacyContext db = new PharmacyContext();
        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(i => i.Id == id);
        }
        public List<Product> GetByCategory(Categories categories)
        {
            var products =  db.Products.Where(p => p.Category.Categories == categories).ToList();
            return products; 
        }
        public bool Post (Product product)
        {
            if(product != null)
            {
                if(!db.Products.Any(p=>p.Name == product.Name))
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool Delete (int id)
        {
            var product = GetById(id);
            if(product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Product product)
        {
            if(product != null)
            {
                var prod = db.Products.FirstOrDefault(i => i.Id == product.Id);
                if(prod != null)
                {
                    prod.Name = product.Name;
                    prod.Quantity = product.Quantity;
                    prod.Description = product.Description;
                    prod.RetailPrice = product.RetailPrice;
                    prod.PurchasingPrice = product.PurchasingPrice;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }
        public List<Product> FindByName(string name, Categories category)
        {
            var products = db.Products.Where(p => p.Name.StartsWith(name) && p.Category.Categories == category).Select(p => p).ToList(); ;
            if(products!= null)
                return products;
            return null;
        }
        //public List<Product> OrderBy(string input)
        //{
        //    var products = db.Products.OrderBy(i=>i.)
        //}
    }
}
