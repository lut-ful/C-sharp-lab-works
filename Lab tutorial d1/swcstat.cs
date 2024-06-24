using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tutorial
{
    internal class swcstat
    {

        int score=0;
        public swcstat()
        {
            Console.WriteLine("Enter your score ");
            score = int.Parse(Console.ReadLine());
        }
        char getgrade()
        {
            char grade=' ';
            switch(score)
            {
                case int n when (n>=90):
                    grade='A';
                    break;
                case int n when (n>=80 && n<90):
                    grade='B';
                    break;
                case int n when (n>=70 && n<80):
                    grade='C';
                    break;
                case int n when (n>=0 && n<70):
                    grade='F';
                    break;
            }
            return grade;
        }
    }
}
