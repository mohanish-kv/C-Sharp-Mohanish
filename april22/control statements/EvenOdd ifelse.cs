using System;
using System.Formats.Asn1;

class EvenOdd
{
  public static void Main()
  {
    Console.WriteLine("Enter a number: ");
    int a;
    a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
      Console.WriteLine("{0} is even",a);
    }
    else
    {
      Console.WriteLine("{0} is odd",a);
    }
  }
}