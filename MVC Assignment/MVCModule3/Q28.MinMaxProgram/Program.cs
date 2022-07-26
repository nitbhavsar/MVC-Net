using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q28.MinMaxProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter the First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third Number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The Max Number is {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The Max Number is {0}", b);
            }
            else
            {
                Console.WriteLine("The Max Number is {0}",c);
            }

            if (a < b && a < c)
            {
                Console.WriteLine("The Min Number is {0}", a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("The Min Number is {0}", b);
            }
            else
            {
                Console.WriteLine("The Min Number is {0}", c);
            }
            Console.Read();
        }
    }
}
