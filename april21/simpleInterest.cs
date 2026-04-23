using System;

class SimpleInterest
{
    public static void Main()
    {
        Console.WriteLine("Enter Principal Amount:");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Time (in years):");
        double t = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = {0}", simpleInterest);
    }
}
