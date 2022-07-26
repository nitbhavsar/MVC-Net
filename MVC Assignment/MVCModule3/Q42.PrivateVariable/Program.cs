using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.PrivateVariable
{
    class PvtVar 
    {
        private int a = 10;
        private int b = 20;
       
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}",a,b,a*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PvtVar p = new PvtVar();
            p.Multiplication(10,3);
            Console.Read();

        }
    }
}
