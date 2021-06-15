using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public String name;
        public int salary;

        public override string ToString()
        {
            return "Name: " + name + "\nSalary: " + salary;
        }
    }
}
