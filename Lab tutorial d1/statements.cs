using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tutorial
{
    internal class statements
    {
        public statements()
        {
            Console.WriteLine("hello, world");
            double number = 10.1234;
            Console.Write(number);
            Console.WriteLine();
            Console.WriteLine("The number is " + number);
            Console.WriteLine($"number is {number}");
            Console.WriteLine("number is {0}", number);
        }
    }
}
