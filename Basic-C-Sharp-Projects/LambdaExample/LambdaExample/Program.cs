using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Leonard",
                Id = 1
            };
            Employee emp2 = new Employee()
            {
                FirstName = "Dan",
                LastName = "Jones",
                Id = 2
            };
            Employee emp3 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Buck",
                Id = 3
            };
            Employee emp4 = new Employee()
            {
                FirstName = "Bill",
                LastName = "Russell",
                Id = 4
            };
            Employee emp5 = new Employee()
            {
                FirstName = "Al",
                LastName = "Horford",
                Id = 5
            };
            Employee emp6 = new Employee()
            {
                FirstName = "Tom",
                LastName = "Brady",
                Id = 6
            };
            Employee emp7 = new Employee()
            {
                FirstName = "Jayson",
                LastName = "Tatum",
                Id = 7
            };
            Employee emp8 = new Employee()
            {
                FirstName = "David",
                LastName = "Pastrnak",
                Id = 8
            };
            Employee emp9 = new Employee()
            {
                FirstName = "Kyrie",
                LastName = "Irving",
                Id = 9
            };
            Employee emp10 = new Employee()
            {
                FirstName = "Jackie",
                LastName = "Bradley Jr.",
                Id = 10
            };

            List<Employee> employees = new List<Employee>()
            {
                emp1,
                emp2,
                emp3,
                emp4,
                emp5,
                emp6,
                emp7,
                emp8,
                emp9,
                emp10
            };

            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            List<Employee> newJoeList = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee emp in newJoeList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            List<Employee> overFiveList = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee newEmp in overFiveList)
            {
                Console.WriteLine(newEmp.FirstName + " " + newEmp.LastName + " #" + newEmp.Id);
            }

            Console.Read();
        }
    }
}
