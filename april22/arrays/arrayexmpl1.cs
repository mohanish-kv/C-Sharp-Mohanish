using System;
class Arr
{
  static void Main()
  {
    int[] arr =  new int[5]{10,20,30,40,50};
    Console.WriteLine("Elements of Array are: ");
    for(int i =0; i < arr.Length ; i++)
    {
      Console.WriteLine(arr[i]);
    }
  }
}