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

    Console.WriteLine("Your age cateogary is: ");
    if (age>0 && age < 4)
    {
      Console.WriteLine("Infant");
    }
    else if(age>=4 && age<13)
    {
      Console.WriteLine("Kid");
    }
    else if (age>12 && age<20)
    {
      Console.WriteLine("Teen");
    }
    else if (age>19 && age <35)
    {
      Console.WriteLine("Adult");
    }
    else if (age>34 && age < 60)
    {
       Console.WriteLine("Middle Age");
    }
    else if( age > 59)
    {
       Console.WriteLine("Senior Citizen");
    }
    else
    {
       Console.WriteLine("Invalid age");
    }
  }
}