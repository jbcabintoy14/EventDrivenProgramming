using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    public class Beverage : MenuItem
    {
        public BeverageType Type { get; private set; }

        public Beverage(string name, BeverageType type, double price) : base(name, price)
        {
            this.Type = type;
        }
    }
}
