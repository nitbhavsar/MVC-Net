using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            string num = Console.ReadLine();
            char [] ch = num.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine("The ASCII value of {0}: {1}",ch[i],((int)ch[i]));
            }
           
            Console.Read();
        }
    }
}
