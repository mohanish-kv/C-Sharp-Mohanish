using System;

class elif
{
  public static void Main()
  {
    Console.WriteLine("Enter your grade 0-100 :");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 79)
    {
      Console.WriteLine("Passed with distinction");
    }
    else if (a >= 35 && a < 80)
    {
      Console.WriteLine("you have Passed");
    }
    else
    {
      Console.WriteLine("You havent passed");
    }
  }
}