using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodItem
    {
        public FoodItem()
        {

        }
        public FoodItem(string description, float unitPrice) : this()
        {
            Description = description;
            UnitPrice = unitPrice;
        }
        public int FoodItemID { get; set; }
        [Required]
        public string Description { get; set; }
        public float UnitPrice { get; set; }
    }
}
