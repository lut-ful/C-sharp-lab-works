﻿namespace selfPractice
{
    /*
    class Vehichle
    {
        public string brand ="Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehichle
    {
        public string modleName = "Mustang";

    }
    public abstract class Animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("Zzz");    
        }
    }
    public class Dog:Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The dog barks: woof woof");
        }
    }

    public class DemoEncap
    {
        private string studentName;
        private int studentAge;
        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myCar=new Car();
            myCar.honk();
            Console.WriteLine($"{myCar.brand} {myCar.modleName}");
            
            try
            {
                int[] myNumbers = { 1, 3, 3 };
                Console.WriteLine((myNumbers[2]));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Dog dog = new Dog();
            dog.animalsound();
            dog.sleep();
            
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            int[][] arr1 =
            {
                new int[]{1,3,5,7,9},
                new int[]{2,4,6,8}
            };
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
    */
    public class Program
    {
        public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations)
        {
            try
            {
                for (int i = 0; i < inclinations.Length; i++)
                {
                    initialSpeed -= (initialSpeed*MathF.Cos(inclinations[i]));
                }
            }
            catch
            {
                Console.WriteLine("problm faced");
            }
            return initialSpeed;
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine(CalculateFinalSpeed(60, new int[] { 0, 30, 0, -45, 0 }));
            Console.WriteLine(Math.Acos(0));
            Console.WriteLine(MathF.Cos(90));

            Console.WriteLine(Math.Asin(0.2));
            Console.WriteLine(Math.Sin(2));

            Console.WriteLine(Math.Atan(-5));
            Console.WriteLine(Math.Tan(1));

        }
    }
}
