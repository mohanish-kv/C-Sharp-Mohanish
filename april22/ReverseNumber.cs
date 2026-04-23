using System;
class Reverse
{
  public static void Main()
  {
    Console.WriteLine("Enter the number to be reversed");
    int num = Convert.ToInt32(Console.ReadLine());
    int r = 0;
    while (num > 0)
    {
      int r = num%10;
      Console.Write(r);
      num = num/10;
    }
   /*
    while (num > 0)
    {
      r = r*10;
      r = r+(num%10);
      num = num/10;
    }
    */
    Console.WriteLine("reverse is "+r);
  }
  
}