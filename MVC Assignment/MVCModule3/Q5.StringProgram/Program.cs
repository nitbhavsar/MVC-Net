using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5.StringProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //5. Create program to sort string in descending order

            string[] Str = { "Nital", "Divya", "Sagar", "Suchi", "Priyanshu" };

            Array.Sort(Str);
            Array.Reverse(Str);

            for (int i = 0; i < Str.Length; i++)
            {
                Console.WriteLine(Str[i]);
            }
            
            Console.Read();
           

        }
    }
}
