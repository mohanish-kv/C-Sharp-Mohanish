using System;

class Param
{
  static int Sum(params int[] numbers)
  {
    int total =0;
    foreach (int num in numbers)
    {
      total += num;
    }
    return total;
  }

  static void Main(String[] args)
  {
    Console.WriteLine(Sum(10,20,30));
  }
}
