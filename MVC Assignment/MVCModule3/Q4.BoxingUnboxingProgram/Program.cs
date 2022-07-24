using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4.BoxingUnboxingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 10;

            //Implicit Conversion or Boxing

            object j = i;

            Console.WriteLine("The Value of j is {0}",j);

            //Explicit Conversion or Unboxing 

            int x = (int)j;

            Console.WriteLine("The Value of x is {0}",x);

            Console.Read();

        }
    }
}
