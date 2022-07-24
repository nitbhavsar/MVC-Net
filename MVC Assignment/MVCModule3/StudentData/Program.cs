using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class StudentName
    {
        String StudName = "";

        public void name()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Student Name:");
                StudName = Console.ReadLine();
            }
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create program to take 5 students details using structure

            StudentName s = new StudentName();
            s.name();
            Console.Read();

        }
    }
}
