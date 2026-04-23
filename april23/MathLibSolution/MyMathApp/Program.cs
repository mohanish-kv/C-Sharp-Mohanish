using System;
using MathLib;

namespace MyMathApp
{
    class Program
    {
        static void Main()
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Sum(10, 20));
            Console.WriteLine(c.Product(10, 20));
            Console.WriteLine(c.Difference(10, 20));
            Console.WriteLine(c.Divide(10, 20));
        }
    }
}