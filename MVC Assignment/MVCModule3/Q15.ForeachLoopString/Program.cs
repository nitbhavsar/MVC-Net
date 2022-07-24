using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15.ForeachLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] StudName = { "Nital", "Divya", "Sagar", "Priyanshu", "Suchi" };

            foreach (var value in StudName)
            {
                Console.WriteLine(value);
            }

            Console.Read();
        }
    }
}
