using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19._3StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks of Maths:");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of Science:");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of English:");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            int sum, avg;

            sum = sub1 + sub2 + sub3;
            avg = sum * 100 / 150;

            Console.WriteLine("Marks obtained in Maths:\t {0}",sub1);
            Console.WriteLine("Marks obtained in Science:\t {0}", sub2);
            Console.WriteLine("Marks obtained in English:\t {0}", sub3);
            Console.WriteLine("============================================");
            Console.WriteLine("Total marks obtained:\t\t {0}",sum);
            Console.WriteLine("============================================");
            Console.WriteLine("Percentage obtained:\t\t {0}%", avg);

            Console.Read();

        }
    }
}
