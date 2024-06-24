using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tutorial
{
    internal class readinput
    {
        public readinput()
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Enter your age ");
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"You are {age} years old");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            
        }
    }
}
