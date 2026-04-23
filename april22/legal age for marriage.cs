using System;

class marriage
{
  public static void Main()
  {
    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your gender: \n1. Male \n2. Female ");
    int i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
      case 1:
        if (age > 20)
        {
          Console.WriteLine("You are eligible to marry");
        }
        else
        {
          Console.WriteLine("You not are eligible to marry");
        }
      break;
      case 2:
      if (age > 17)
        {
          Console.WriteLine("You are eligible to marry");
        }
        else
        {
          Console.WriteLine("You not are eligible to marry");
        }
      break;
      default:
        Console.WriteLine("Invalid input");
      break;


    }

    
  }
}