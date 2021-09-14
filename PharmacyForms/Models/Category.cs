using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamacyLibrary.Models
{
    public class Category
    {
        [Key] public int Id { get; set; }
        [Required] [MaxLength(50)] public string Name { get; set; }
        public virtual List<Product> Products{get;set;}
    }
}
