using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class PartTimeEmployee : IEmployee
    {
       
        public double getSalary()
        {
            return 0;
        }
    }
}
