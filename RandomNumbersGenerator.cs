using System;
using System.Numerics;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user for number of needed random numbers
            Console.WriteLine("How many random numbers you want:");
            int numNumbers = int.Parse(Console.ReadLine());
            
            //prompt for lower bound
            Console.WriteLine("Lower bound:");
            int lowerBound = int.Parse(Console.ReadLine());
            
            //prompt for upper bound
            Console.WriteLine("Upper bound:");
            int upperBound = int.Parse(Console.ReadLine());
            
            //check for correct user input
            if (lowerBound > upperBound)
            {
                Console.WriteLine("Incorrect range.");
                return;
            }
            
            //creating array for the random numbers
            Random rNum = new Random();
            int[] numArray = new int[numNumbers];
            
            //loop for generating random numbers
            for(int i = 0; i < numNumbers; i++)
            {
                //generating random number between lower and upper bound
                numArray[i] = rNum.Next(0,100);
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
