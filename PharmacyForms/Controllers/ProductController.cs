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
            var products = db.Products.Where(p => p.Category.Categories == categories).ToList();
            return products;
        }
        public void Post (Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public bool Delete (int id)
        {
            var product = GetById(id);
            if(product != null)
            {
                db.Remove(product);
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
    }
}
