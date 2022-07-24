using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. 1+4+9+16+25+…..

            //int n = 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i * i+"  ");
            }
            Console.WriteLine("\n");
            //b. 1+1+2+3+5+8+…..

            int a = 0, b = 1, c;

            for (int i = 0; i <= 10; i++)
            {
                c = a + b;

                Console.Write(c+"  ");

                a = b;
                b = c;
            }
            Console.WriteLine("\n");

            //c. 1+5+14+30+55+…..
            int x = 1;
            for (int i = 0; i <= 10; i++)
            {
                int y = x + (i * i);
                Console.Write(y + "  ");

                x = y;
            }
            Console.Read();
        }
    }
}
