using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCModule3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

                Console.Write("Enter the First Number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine("{0} is a Max Number", a);
                }
                else
                {
                    Console.WriteLine("{0} is a Max Number", b);
                }
            Console.Read();
        }
    }
}
