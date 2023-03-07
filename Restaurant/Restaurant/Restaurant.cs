using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public class Restaurant
    {
        public string Name { get; set; }
        public int MaxCapacity { get; private set; }
        public int CurrentCapacity { get; set; }

        public Restaurant(string name, int maxCapacity, int currentCapacity)
        {
            this.Name = name;
            this.MaxCapacity = maxCapacity;
            this.CurrentCapacity = currentCapacity;
        }
    }
}