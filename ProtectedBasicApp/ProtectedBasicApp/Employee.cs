using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedBasicApp
{
    class Employee
    {
        public string Name { get; set; }
        public string RegNo { get; set; }

        public double getSalary()
        {
            return 1;
        }

        protected double getBonus()
        {
            return 1;
        }

        private void M()
        {
            
        }
    }
}
