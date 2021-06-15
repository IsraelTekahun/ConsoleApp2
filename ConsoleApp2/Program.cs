using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Uppgift 1
                Vilka klasser bör ingå i programmet?
                Vi behöver två klasser. En klass (Employees) för att lagra alla anställda och en annan (Employee) för en anställd.

                Uppgift 2
                Vilka attribut och metoder bör ingå i dessa klasser?
                I Employees ingår två fält. Det ena fältet(List < Employee > employees) är en lista som lagrar anställda och det andra(int nrOFEmployees) räknar antalet anställda som finns.
                I Employee ingår också två fält. En sträng för att behålla namn och en int för att behålla lön.
            */


            Employees employees = new Employees();

            String name = " ";
            String strSalary = "";
            int salary = 1;

            Console.WriteLine("Enter empity name and zero salary to quit");
            Console.WriteLine();

            while (name != "" && salary != 0)
            {   

                try
                {
                    Console.Write("Enter employee name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter employee salary: ");
                    strSalary = Console.ReadLine();
                    salary = Convert.ToInt32(strSalary);

                    employees.addEmployee(name, salary);
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input given, quiting ...");
                }
            }



            Console.WriteLine();
            if(employees.getNrOfEmployees() > 0)
            {
                Console.WriteLine("The employees and thier salaries are: ");
                Console.WriteLine();
                employees.displayEmployees();
            } else
            {
                Console.WriteLine("You do not have any employees");
            }
;
        }
    }
}
