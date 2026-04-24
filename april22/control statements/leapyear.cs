using System;
class leapyear
{
  public static void Main()
  {
    Console.WriteLine("Enter the Year: ");
    int year = Convert.ToInt32(Console.ReadLine());
    if(year % 400 == 0)
    {
      Console.WriteLine("{0} is a leap year",year);
    }
    else if(year % 4 ==0 && year %100 != 0) 
    {
      Console.WriteLine("{0} is a leap year",year);
    }
    else
    {
      Console.WriteLine("{0} is not a leap Year",year);
    }
  }
}