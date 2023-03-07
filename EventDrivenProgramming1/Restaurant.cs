using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    public class Restaurant
    {
        public string Name { get; set; }
        public int MaxCapacity { get; private set; }

        public List<People> People { get; private set; }

        public List<Menu> Menus { get; private set; }

        public Restaurant(string name, int maxCapacity, List<People> people, List<Menu> menus)
        {
            this.Name = name;
            this.MaxCapacity = maxCapacity;
            this.Menus = menus;
            this.People = people;
        }

        public int CurrentCapacity()
        {
            return this.People.Count;
        }
    }
}
