using System;

class CheckPrime
{
  public static bool IsPrime(int number)
  {
    if(number <= 1)
    {
      return false;
    }
    else
    {
      for(int i =1; i <= number/2;i++)
      {
        int count = 0;
        if(number % i == 0)
        {
          count++;
        }
        if(count < 2)
        {
          return true;
        }

      }
    }
    return false;
  }
  public static void Main()
  {
    Console.WriteLine("Enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    if(IsPrime(number))
    {
      Console.WriteLine(number + " is a prime number.");
    }
    else
    {
      Console.WriteLine(number + " is not a prime number.");
    }
  }
}