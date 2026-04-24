using System;

class TwoDimArray
{
    static void Main()
    {
        // 2 rows and 3 columns
        int[,] arr = new int[2, 3]
        {
            { 10, 20, 30 },
            { 40, 50, 60 }
        };

        Console.WriteLine("Elements of 2X3 array:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
