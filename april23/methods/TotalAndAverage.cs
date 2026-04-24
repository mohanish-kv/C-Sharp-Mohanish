using System;

class StudentMarks
{
    static void CalculateTotalAndAverage(int[] marks, out int total, out double average)
    {
        total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        average = (double)total / marks.Length;
    }

    static void Main()
    {
        int[] marks = new int[5];

        Console.WriteLine("Enter marks for 5 subjects:");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total;
        double average;

        CalculateTotalAndAverage(marks, out total, out average);

        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Average Marks = " + average);
    }
}
