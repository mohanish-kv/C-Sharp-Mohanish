using System;

class Param
{
    static void Name(string name = "Guest")
    {
        Console.WriteLine("Hello, " + name);
    }

    static void Main(string[] args)
    {
        Name("Alice");
        Name();
    }
}
