using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateCircumference();
            Console.WriteLine("Lab 10");
            Console.WriteLine("Welcome to Circle Tester");
            Console.WriteLine("Enter radius :");
            double Radius = double.Parse(Console.ReadLine());

            NewCircumference();
            {
                Circle cl = new Circle();
                Console.WriteLine("Circumference : " + cl.CalculateCircumference());
            }
           
        }
    }
}

