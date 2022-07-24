using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21.DataHiding
{
    public class Company
    {
        public void EmpDetails()
        {
            Console.WriteLine("The total number of emps are 10");
        }
    }

    public class Employee: Company
    {
        public void EmpDetails()
        {
            int salary;
            string EmpName;
            Console.WriteLine("Employee Name:");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name:\t\t{0}",EmpName);
            Console.WriteLine("Employee Salary:\t\t{0}",salary);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpDetails();
            Console.Read();

        }
    }
}
