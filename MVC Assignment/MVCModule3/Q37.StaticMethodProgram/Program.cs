using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q37.StaticMethodProgram
{
    public static class ArithmeticOperation
    {
        static internal int a, b, c;
        static internal int sum;

        class Program
        {
            static void Main(string[] args)
            {
               
                Console.Write("Enter the First Number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Third Number: ");
                c = Convert.ToInt32(Console.ReadLine());
                ArithmeticOperation.sum = a + b + c;
                Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,sum);
                Console.Read();
            }
        }
    }
}
