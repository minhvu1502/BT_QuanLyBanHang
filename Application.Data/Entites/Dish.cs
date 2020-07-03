using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class Dish
    {
        public string Id { get; set; }
        public string Request { get; set; }
        public string Name { get; set; }
        public string Making { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public CategoryDish CategoryDish { get; set; }
        public string CategoryDishId { get; set; }
        public List<Effect_Dish> EffectDishes { get; set; }
    }
}
