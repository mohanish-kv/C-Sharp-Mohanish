using System;

class salutation
{
  public static void Main()
  {
     Console.WriteLine("Enter your name:");
    string name = (Console.ReadLine());
    Console.WriteLine("Enter your gender: \n1. Male \n2. Female ");
    int i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
      case 1:
      Console.WriteLine("HELLO Mr.{0}",name);
      break;
      case 2:
      Console.WriteLine("HELLO Ms.{0}",name);
      break;
      default:
        Console.WriteLine("Invalid input");
      break;


    }

  }
}
