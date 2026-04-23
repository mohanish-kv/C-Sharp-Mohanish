using System;
class Readwrite
{
    static void Main()
    {
        Console.WriteLine("Please enter ur first name:");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Please enter ur last name:");
        string LAstName = Console.ReadLine();
        //Console.WriteLine("Hello"+ UserName);
        Console.WriteLine("HEllo {0} {1}",FirstName, LAstName);
    }
}