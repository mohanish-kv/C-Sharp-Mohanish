using System;

class Calculator
{
  public static void Main()
  {
    Console.WriteLine("Enter first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Select operation: \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division ");
    int i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
      case 1:
       int sum = num1+num2;
       Console.WriteLine("sum is "+sum);
      break;
      case 2:
       int diff = num1-num2;
       Console.WriteLine("Difference is "+diff);
      break;
      case 3:
       int product = num1*num2;
       Console.WriteLine("Product is "+product);
      break;
      case 4:
        if (num2 == 0)
        {
          Console.WriteLine("Zero division error, second number must be greater than 0");
        }
        else
        {
         int result = num1/num2;
         Console.WriteLine("quotient is "+result);
        }
      break;
      default:
        Console.WriteLine("Invalid input");
      break;

    }

    
  }
}