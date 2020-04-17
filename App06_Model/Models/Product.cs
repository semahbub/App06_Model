using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App06_Model.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string MUnit { get; set; }
        [Range(1, 99999)]
        public double UnitPrice { get; set; }
        [Range(1, 99999)]
        public double Quantity { get; set; }
    }
}
