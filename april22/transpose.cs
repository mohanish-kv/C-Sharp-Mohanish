using System;

class MatrixTranspose
{
    static void Main()
    {
        int[,] A = new int[2, 3];
        int[,] T = new int[3, 2];

        Console.WriteLine("Enter elements of Matrix (2x3):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Transpose
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                T[j, i] = A[i, j];
            }
        }

        Console.WriteLine("Transpose Matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(T[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
