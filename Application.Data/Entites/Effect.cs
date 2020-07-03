using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
   public class Effect
   {
       public string Id { get; set; }
       public string Name { get; set; }
       private List<Effect_Dish> EffectDishes { get; set; }
   }
}
