using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21.ReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I am working as an accountant";

           string str2 = str.Replace("an accountant", "a programmer");

            Console.WriteLine(str);
           Console.WriteLine(str2);
            Console.Read();
        }
    }
}
