using System;

class CopyArray
{
    static void Main()
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];

        Console.WriteLine("Enter 5 array elements:");

        // Accept elements into first array
        for (int i = 0; i < 5; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Copy elements to second array
        for (int i = 0; i < 5; i++)
        {
            arr2[i] = arr1[i];
        }

        Console.WriteLine("\nElements of first array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(arr1[i] + " ");
        }

        Console.WriteLine("\n\nElements of second array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}
