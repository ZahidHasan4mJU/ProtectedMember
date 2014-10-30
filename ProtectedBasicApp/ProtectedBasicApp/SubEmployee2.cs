using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedBasicApp
{
    class SubEmployee2:Employee
    {
        public string SerialNo { get; set; }

        public SubEmployee2()
        {
            getSalary();
            getBonus();
            
        }
    }
}
