using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class MaterialDish
    {
        public Material Material { get; set; }
        public Dish Dish { get; set; }
        public string MaterialId { get; set; }
        public string DishId { get; set; }
        public int Quantity { get; set; }
    }
}
