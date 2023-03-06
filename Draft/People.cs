using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public abstract class People
    {
        public string Name { get; set; }
        public bool Authorized { get; set; }
        public People(string name, bool authorized)
        {
            this.Name = name;
            this.Authorized = authorized;
        }
    }
}
