using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    public class Dish : MenuItem
    {
        public DishType Type { get; private set; }

        public Dish(string name, DishType type, double price) : base(name, price)
        {
            this.Type = type;
        }
    }
}
