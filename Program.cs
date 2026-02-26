using System;
using MathLibrary;

namespace Library_Referencing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMath Math = new clsMath();
            Console.WriteLine(Math.Sum(10, 20));
            Console.ReadKey();

        }
    }
}
