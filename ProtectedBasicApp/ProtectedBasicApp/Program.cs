using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SubEmployee aSubEmployee = new SubEmployee("adasds","24155");
            aSubEmployee.getSalary();
            aSubEmployee.getSalary();
            Employee anEmployee = new Employee();
            anEmployee.getSalary();
        }
    }
}
