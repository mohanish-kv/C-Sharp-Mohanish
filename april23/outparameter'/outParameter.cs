using System;

class OutParameter
{
  public static void Sum(int a, int b, out int res)
  {
    res = a + b;
  }
  public static void Main()
  {
    int a,b,c;
    a=10;
    b=20;
    Sum(a,b,out c);
    Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
  }
}