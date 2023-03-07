using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Draft
{
    public abstract class MenuItem
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}