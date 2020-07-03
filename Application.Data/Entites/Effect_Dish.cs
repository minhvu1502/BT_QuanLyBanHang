using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public  class Effect_Dish
    {
        public Effect Effect { get; set; }
        public Dish Dish { get; set; }
        public string EffectId { get; set; }
        public string DishId { get; set; }
    }
}
