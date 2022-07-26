using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q34.ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the {0} Number: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The {0} is : {1}",i,arr[i]);
                sum += arr[i];
            }

            Console.WriteLine("The Sum of Array is: {0}",sum);

            Console.Read();

        }
    }
}
