using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. Solve the following patterns
            int h = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  " + h++);

                }
                Console.WriteLine("\n");
            }

            //b. Solve the following patterns:
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" " + "*");
                    }
                    else
                    {
                        Console.Write(" " + "#");
                    }
                }
                Console.WriteLine("\n");
            }
            //c. Solve the following patterns
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" " + "#");
                    }
                    else
                    {
                        Console.Write(" " + "*");
                    }
                }
                Console.WriteLine("\n");
            }

            //d. Solve the following patterns

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  " + i);

                }
                Console.WriteLine("\n");
            }

            //e. Solve the following patterns
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine("\n");
            }

            //f. Solve the following patterns
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine("\n");
            }
            Console.Read();

        }
    }
}
