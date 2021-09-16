using PhamacyLibrary.Models;
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
        public void Post (Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
