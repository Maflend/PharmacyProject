using Microsoft.EntityFrameworkCore;
using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PharmacyForms
{
    public class PharmacyContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public PharmacyContext()
        {
            
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = GetConnectionString();
            optionsBuilder.UseSqlServer(con);
            // Server=COM-118-12\SQLEXPRESS;Database=PharmacyProject;Trusted_Connection=True;           || Универ
            // Server=DESKTOP-NI19A83\SQLEXPRESS01;Database=PharmacyProject;Trusted_Connection=True;    || Алина
            // Server=localhost\\SQLEXPRESS;Database=PharmacyProject;Trusted_Connection=True;           || Максим
        }
        private string GetConnectionString()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            string path = "Resources\\Settings.json"; //Менять строку подключения в этом файле по пути "PharmacyProject\PharmacyProject\PharmacyForms\bin\Debug\net5.0-windows\Resources\Settings.json в поле MyConnectionStringForPharmacyProject"
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string jsonString = File.ReadAllText(path, Encoding.GetEncoding(1251));
            settings = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
            var connectionString = settings.Where(t => t.Key == "MyConnectionStringForPharmacyProject").FirstOrDefault().Value.ToString(); 
            return connectionString;
        }

    }
}
