using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20.Factorial
{
    internal class factorial
    {
        
        internal void fact()
        {
            int fact = 1, n = 0 ;
            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine("The factorial of {0} is: {1}", n, fact);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            factorial fc = new factorial();
            fc.fact();
            Console.Read();
        }
    }
}
