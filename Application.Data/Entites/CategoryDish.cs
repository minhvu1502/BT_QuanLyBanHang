using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data.Entites
{
    public class CategoryDish
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
