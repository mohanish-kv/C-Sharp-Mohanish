using System;

class SwappingWithoutThird
{
    static void Main()
    {
      //int a =10;
      //int b = 7;
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before Swap : a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After Swap : a = {0}, b = {1}", a, b);
    }
}