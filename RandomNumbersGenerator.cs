using System;
using System.Numerics;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers you want:");
            int numNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Lower bound:");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine("Upper bound:");
            int upperBound = int.Parse(Console.ReadLine());
            if (lowerBound > upperBound)
            {
                Console.WriteLine("Incorrect range.");
                return;
            }
            Random rNum = new Random();
            int[] numArray = new int[numNumbers];
            for(int i = 0; i < numNumbers; i++)
            {
                numArray[i] = rNum.Next(0,100);
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
