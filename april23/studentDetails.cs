using System;

class StudentDetails
{
    static void StudentDetail(params object[] data)
    {
        int marks = 0;
        string name = "";

        foreach (object item in data)
        {
            if (item is int)
                marks += (int)item;
            else if (item is string)
                name = (string)item;
        }

        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Total Marks        : " + marks);
        Console.WriteLine("--------------------------------");
    }

    static void Main()
    {

        StudentDetail("Ram", 25, 30, 28);
        StudentDetail("Krish", 29);
        StudentDetail(100, "John");
    }
}