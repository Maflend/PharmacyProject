using Microsoft.EntityFrameworkCore;
using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=PharmacyProject;Trusted_Connection=True;"); // MAX
            // optionsBuilder.UseSqlServer(@"Server=COM-118-12\SQLEXPRESS;Database=PharmacyProject;Trusted_Connection=True;"); // Univer
           // optionsBuilder.UseSqlServer(@"Server=DESKTOP-NI19A83\SQLEXPRESS01;Database=PharmacyProject;Trusted_Connection=True;"); // ALINA
        }

    }
}
