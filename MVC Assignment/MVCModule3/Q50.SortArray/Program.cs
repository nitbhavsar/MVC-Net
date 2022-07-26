using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Q50.SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 21, 9, 5, 4 };

            arr = arr.OrderByDescending(c => c).ToArray();
            foreach (int value in arr)
            {
                Console.WriteLine( value + " " );
            }
            Console.Read();

        }
    }
}
