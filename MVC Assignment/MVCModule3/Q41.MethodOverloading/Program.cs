using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q41.MethodOverloading
{
    public class Addition
    {
        internal void sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2} ",a,b,a+b);
        }

        internal void sum(int a, int b, int c)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,a+b+c);
        }    
     

    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();

            a.sum(1, 2);
            a.sum(1, 2, 3);

            Console.Read();
        }
    }
}
