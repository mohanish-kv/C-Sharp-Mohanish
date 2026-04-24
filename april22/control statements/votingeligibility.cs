using System;
using System.Security.Cryptography;
class votingeligibility
{
  public static void Main()
  {

    int cy = DateTime.Now.Year;
    Console.WriteLine("Enter your year of birth");
    int by = Convert.ToInt32(Console.ReadLine());

    int age = cy-by;
    Console.WriteLine("Your age is {0}",age);
    if (age>0 && age < 18)
    {
      Console.WriteLine("You can not vote");
    }
    else if (age >= 8)
    {
      Console.WriteLine("You can vote");
    }
    else
    {
      Console.WriteLine("Invalid age");
    }
    
  }
}