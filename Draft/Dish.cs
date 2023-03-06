using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public class Dish : MenuItem
    {
        public DishType Type { get; private set; }

        public Dish(string name, DishType type) : base(name)
        {
            this.Type = type;
        }
    }
}
