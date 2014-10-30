using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedBasicApp
{
    class SubEmployee:Employee
    {
        public string SubRegNo { get; set; }

        public SubEmployee(string name, string regNo)
        {
            getSalary();
            Name = name;
            RegNo = regNo;
            
        }
    }
}
