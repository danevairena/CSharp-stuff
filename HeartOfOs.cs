using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = " o    o\no  o o  o\n o  o  o\n  o   o\n   o o\n    o\n";
           
            Console.WriteLine(a);
        }
    }
}

/*output
 o     o
o  o o  o
 o  o  o
  o   o
   o o
    o
*/
