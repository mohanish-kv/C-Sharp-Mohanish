using System;
class SimpleCalculator
{
  public static double Add(double num1, double num2)
  {
    return num1 + num2;
  }
  public static double subtract(double num1, double num2)
  {
    return num1-num2;
  }
  public static double Multiply(double num1, double num2)
  {
    return num1*num2;
  }
  public static double Divide(double num1, double num2)
  {
    if(num2 == 0)
    {
      Console.WriteLine("Cannot divide by zero.");
      return 0;
    }
    return num1/num2;
  }
  public static void Main()
  {
    Console.WriteLine("Enter first number:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose the Operation to be performed: \n 1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
    int choice = Convert.ToInt32(Console.ReadLine());
    double result = 0;
    switch(choice)
    {
      case 1:
        result = Add(num1, num2);
        Console.WriteLine("Result: " + result);
        break;
      case 2:
        result = subtract(num1, num2);
        Console.WriteLine("Result: " + result);
        break;
      case 3:
        result = Multiply(num1, num2);
        Console.WriteLine("Result: " + result);
        break;
      case 4:
        result = Divide(num1, num2);
        Console.WriteLine("Result: " + result);
        break;
      default:
        Console.WriteLine("Invalid choice.");
        break;
    }
  }
}