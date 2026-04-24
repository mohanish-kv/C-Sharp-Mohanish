using System;
class AreaAndPerimeter
{
  public static void Main()
  {
    Console.WriteLine("Enter the radius of the circle: ");
    double r = Convert.ToInt32(Console.ReadLine());
    double area = 3.14*r*r;
    double peri = 2*3.14*r;
    Console.WriteLine("Area of circle with radius {0} is {1} and perimeter is {2}",r,area,peri);
  }
}