using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class MenuFoodItem
    {
        public MenuFoodItem()
        {

        }

        public MenuFoodItem(int menuId, int foodItemId) : this()
        {
            MenuId = menuId;
            FoodItemId = foodItemId;
        }

        [Required]
        public int MenuId{ get; set; }

        public Menu Menu { get; set; }

        [Required]
        public int FoodItemId { get; set; }

        public FoodItem FoodItem { get; set;}

    }
}
