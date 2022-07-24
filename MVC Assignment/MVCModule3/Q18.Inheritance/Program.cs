using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18.Inheritance
{
    public class MathsOps
    {
        public int x, y, z;
        public void GetData()
        {
            Console.Write("Enter the First Number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Sum : MathsOps
    {
        public void sum()
        {
            z = x + y;
            Console.WriteLine("Value of X is:\t\t\t{0}",x);
            Console.WriteLine("Value of Y is:\t\t\t{0}",y);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Summation of both Numbers is:\t{0}",z);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Sum addition = new Sum();
            addition.GetData();
            addition.sum();

            Console.Read();

        }
    }
}
