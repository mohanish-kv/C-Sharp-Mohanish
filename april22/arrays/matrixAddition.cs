using System;

class MatrixAddition
{
    static void Main()
    {
        int[,] A = new int[2, 2];
        int[,] B = new int[2, 2];
        int[,] Sum = new int[2, 2];

        Console.WriteLine("Enter elements of Matrix A:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of Matrix B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Sum[i, j] = A[i, j] + B[i, j];
            }
        }

        Console.WriteLine("Resultant Matrix (Addition):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(Sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}