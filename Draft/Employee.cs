using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    public class Employee : People
    {
        public double Salary { get; set; }
        public Employee(string name, double salary) : base(name)
        {
            this.Salary = salary;
        }
    }
}
