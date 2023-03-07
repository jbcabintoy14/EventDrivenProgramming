using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming1
{
    public class Customer : People
    {
        public double Balance { get; private set; }
        public Customer(string name, double balance) : base(name, false)
        {
            this.Balance = balance;
        }
    }
}
