using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Current date:\n{dateTime.DayOfWeek} {dateTime.Day}/{dateTime.Month}/{dateTime.Year}\n");
            Console.WriteLine($"Local time:\n{dateTime.Hour}:{dateTime.Minute}");
        }
    }
}
