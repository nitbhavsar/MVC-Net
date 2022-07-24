using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16.CallClassMethod
{
    internal class Employee
    {

        string EmpName;
        int EmpID;
        double BasicSalary, DA, HRA, GrossSalary;

        internal void GetSalary()
        {
            Console.Write("Enter the Basic Salary: ");
            BasicSalary = Convert.ToInt32(Console.ReadLine());
            DA = BasicSalary * 0.12;
            HRA = BasicSalary * 0.50;
            GrossSalary = BasicSalary + DA + HRA;
            Console.WriteLine("Basic Salary\t\t: {0} ", BasicSalary);
            Console.WriteLine("DA\t\t\t: {0} ", DA);
            Console.WriteLine("HRA\t\t\t: {0} ", HRA);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Gross Salary\t\t: {0} ", GrossSalary);
        }

        internal void GetEmpData()
        {
            Console.Write("Enter the Employee ID: ");
            EmpID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("------------------------------");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.GetEmpData();
                emp.GetSalary();
               
                Console.Read();
            }
        }
    }
}
