using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q38.MultilevelInheritance
{
    public class Vehicle
    {
        public void asset()
        {
            Console.WriteLine("Vehicle is an Asset");
        }
    }

    public class TwoWheeler : Vehicle
    {
        public void type()
        {
            Console.WriteLine("Its s Two Wheeler");
        }
    }

    public class Jupiter : TwoWheeler
    {
        public void name()
        {
            Console.WriteLine("The name of two wheeler is Jupiter");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jupiter j = new Jupiter();
            j.type();
            j.asset();
            j.name();

            Console.Read();

        }
    }
}
