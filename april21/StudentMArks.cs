using System;

class StudentMarks
{
    public static void Main()
    {
        Console.WriteLine("Enter marks of Subject 1:");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks of Subject 2:");
        int m2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks of Subject 3:");
        int m3 = Convert.ToInt32(Console.ReadLine());

        int total = m1 + m2 + m3;
        double average = total / 3;

        Console.WriteLine("Total Marks = {0}", total);
        Console.WriteLine("Average Marks = {0}", average);
    }
}