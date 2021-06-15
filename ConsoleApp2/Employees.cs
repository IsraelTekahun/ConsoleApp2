using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employees
    {
        private List<Employee> employees;
        private int nrOFEmployees;

        public Employees()
        {
            employees = new List<Employee>();
            nrOFEmployees = 0;
        }

        public void addEmployee(String name, int salary)
        {
            Employee employee = new Employee();
            employee.name = name;
            employee.salary = salary;

            employees.Add(employee);
            nrOFEmployees++;
        }



        public void displayEmployees()
        {

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("................");
            }
        }
        public int getNrOfEmployees()
        {
            return nrOFEmployees;
        }


    }

}
