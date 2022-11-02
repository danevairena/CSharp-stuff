using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user for number
            Console.WriteLine("Enter number to calculate the square root:\n");
            double number = double.Parse(Console.ReadLine());
            
            //calc square root
            double squareRoot = Math.Sqrt(number);
            
            //output
            Console.WriteLine($"Square root of {number} is {squareRoot}");
        }
    }
}
