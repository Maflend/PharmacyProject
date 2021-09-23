using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Models
{
    public class Order
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime DateSale { get; set; }
        [Required] public virtual User User { get; set; }
        [Required] public List<Sale> Sales { get; set; }

    }
}
