using System;

class Hasvalue
{
  public static void Main()
  {
    int?age = null;
    if (age.HasValue)
    {
      Console.WriteLine("has value");

    }
    else
    {
      Console.WriteLine("Has no value");
    }
  }
}