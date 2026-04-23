using System;

class Triangle
{
    public static void Main()
    {
        Console.WriteLine("Enter side a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double perimeter = a + b + c;
        double s = perimeter / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine("Perimeter of triangle = {0}", perimeter);
        Console.WriteLine("Area of triangle = {0}", area);
    }
}
