using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_d2
{
    internal class Dog
    {
        public string name { set; get; } = null;
        public string breed { set; get; } = null;
        public int age { set; get; }=0;
        public void bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public void fetch(string obj)
        {
            Console.WriteLine($"Fetching the {obj}!");
        }
    }
}
