using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str = { "Nital", "Divya", "Sagar", "Suchi", "Priyanshu" };

            Array.Sort(str);
            Array.Reverse(str);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            string str1 = "My Name is Nital";
            string str2 = "I have started learning";
            Console.WriteLine(str1.Length);

            Console.WriteLine(String.Concat(str2,"\n",str1));
            Console.WriteLine(str2.EndsWith("ing"));
            Console.WriteLine(str2.IndexOf("Nital"));
            Console.WriteLine(str1.StartsWith("My"));

            Console.WriteLine(str1.PadLeft(30).PadRight(30)+"-------------");

            /* int a, b;
             Console.WriteLine("Enter the First Number:");
             a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the Second Number:");
             b = Convert.ToInt32(Console.ReadLine());

             if (a > b)
             {
                 Console.WriteLine("The Maximum Number is {0}", a);
             }
             else
             {
                 Console.WriteLine("The Maximum Number is {0}",b);
             }
            */

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i*i+" ");
            }
            Console.WriteLine("\n");

            int x=0, y=1, z=0;
            for (int i = 0; i <=10 ; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
            

            int a, b = 0;
            
            for (int i = 1; i < 10; i++)
            {
                a = i * i;
                a += b;
                Console.WriteLine(a);
                b = a;
            }

            Console.Write("Enter the Number: ");
            int d = Convert.ToInt16(Console.ReadLine());
            int f = 1;
            for (int k = 1; k <= d; k++)
            {
                f = f * k;
            }
            Console.WriteLine("Factorial of {0} is: {1}",d,f);
            Console.Read();

        }

                
    }
}
