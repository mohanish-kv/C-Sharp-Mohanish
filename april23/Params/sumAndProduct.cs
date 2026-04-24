using System;

class Param
{
  static int Sum(params int[] numbers)
  {
    int sum =0;
    foreach (int num in numbers)
    {
      sum += num;
    }
    return sum;
  }
  static int Product(params int[] numbers)
  {
    int product =1;
    foreach (int num in numbers)
    {
      product *= num;
    }
    return product;
  }

  static void Main(String[] args)
  {
    Console.WriteLine(Sum(10,20,30));
    Console.WriteLine(Product(10,20,30));
  }
}
