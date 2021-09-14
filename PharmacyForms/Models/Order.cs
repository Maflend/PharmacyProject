﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamacyLibrary.Models
{
    public class Order
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime DateSale { get; set; }
        public virtual User User { get; set; }
        public List<Product> Products { get; set; }

    }
}
