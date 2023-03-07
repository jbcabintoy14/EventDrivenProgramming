using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    public class Employee : People
    {
        public double Salary { get; set; }
        public Employee(string name, double salary) : base(name, true)
        {
            this.Salary = salary;
        }
    }
}
