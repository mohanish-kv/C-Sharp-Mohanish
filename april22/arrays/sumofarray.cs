using System;

class SumOfArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Sum of array elements = " + sum);
    }
}