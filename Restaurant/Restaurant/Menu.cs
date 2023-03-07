using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public class Menu
    {
        private List<MenuItem> menuItems;
        public double Price { get; set; }
        public List<MenuItem> MenuItems
        {
            get
            {
                return new List<MenuItem>(menuItems);
            }
        }

        public Menu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }
    }
}