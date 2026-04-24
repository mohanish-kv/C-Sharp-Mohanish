using System;
class Switch
{
    public static void Main()
  {
    for(int i=1;i<=5;i++)
      {
        switch(i)
        {
          case 2:
          Console.WriteLine("Skipping 2");
          break;
          case 4:
          Console.WriteLine("Skipping 4");
          break;
          default:
          Console.WriteLine("value:"+i);
          break;
        }
      }
  }
}