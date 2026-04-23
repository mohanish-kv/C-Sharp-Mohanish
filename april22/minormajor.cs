using System;
using System.Security.Cryptography;
class CurrentYearandDob
{
  public static void Main()
  {
    //Console.WriteLine("Enter the Current year");
    //int cy = Convert.ToInt32(Console.ReadLine());
    int cy = DateTime.Now.Year;
    Console.WriteLine("Enter your year of birth");
    int by = Convert.ToInt32(Console.ReadLine());

    int age = cy-by;
    Console.WriteLine("Your age is {0}",age);
    if (age>0 && age < 18)
    {
      Console.WriteLine("You are a Minor");
    }
    else if (age >= 8)
    {
      Console.WriteLine("You are a Major");
    }
    else
    {
      Console.WriteLine("Invalid age");
    }
    
  }
}