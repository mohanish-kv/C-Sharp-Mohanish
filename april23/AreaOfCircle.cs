using System;

class Area
{
  public double AreaOfCircle(double r)
  {
    double area = Math.PI * r * r;
    return area;
  }
  public static void Main()
  {
    Console.WriteLine("Enter the Radius of the Circle: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    Area areaCalculator = new Area();
    double area = areaCalculator.AreaOfCircle(radius);
    Console.WriteLine("Area of the circle with radius{0} is {1}", radius, area);
  }
}