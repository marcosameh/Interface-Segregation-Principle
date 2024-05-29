using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class PermanentEmployee : IEmployee,IProfitShareEmployee
    {
        public double CalculateProfitShare()
        {
            return 50;
        }

        public double getSalary()
        {
            return 10;
        }
    }
}
