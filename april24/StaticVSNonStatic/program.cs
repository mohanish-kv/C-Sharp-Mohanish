using System;

namespace StaticVSNonStatic
{
  class program
  {
    int number = 10;//instance member
    static string name ="Ram";//static member
    static void Main(string[] args)
    {
      //Console.WriteLine(number);// error: An object reference is required for the non-static field, method, or property 'program.number'
      // program p = new program();// creating object of class program
      // Console.WriteLine(p.number);// calling instance member using object reference
      Console.WriteLine(new program().number);// anonymous object to call instance member
      Console.WriteLine(name);
      Console.ReadKey();
    }
  }
}