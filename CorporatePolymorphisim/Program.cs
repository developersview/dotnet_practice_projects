using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hrRep = new HR();
            hrRep.ClockIn();
            hrRep.Work();
            hrRep.SubmitDailyReport();

            Console.WriteLine(); //Line break

            Employee employee1 = new Engineer();
            employee1.SubmitDailyReport();
            employee1.Work();
            Engineer engineer1 = employee1 as Engineer;
            if (engineer1 != null)
            {
                engineer1.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("Downcast failed.");
            }

            Console.WriteLine(); //Line break

            Employee employee2 = new Manager();
            employee2.SubmitDailyReport();
            employee2.Work();

            Console.WriteLine(); //Line break

            Employee employee3 = new Intern();
            employee3.SubmitDailyReport();
            employee3.Work();

            Console.WriteLine();

            // List of employees
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            foreach (Employee emp in employees)
            {
                emp.SubmitDailyReport();
                emp.Work();
                emp.ClockIn();
                // Check the type of the employee using 'is' operator
                if (emp is Engineer)
                {
                    Console.WriteLine("This is an Engineer.");
                }
                else if (emp is Manager)
                {
                    Console.WriteLine("This is a Manager.");
                }
                else if (emp is Intern)
                {
                    Console.WriteLine("This is an Intern.");
                }
                else
                {
                    Console.WriteLine("Unknown employee type.");
                }
                Console.WriteLine();
            }

        }
    }
}
