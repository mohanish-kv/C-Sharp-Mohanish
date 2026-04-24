using System;

class MatrixMultiplication
{
    static void Main()
    {
        int i, j, k;

        Console.Write("Enter number of rows of Matrix A: ");
        int r1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns of Matrix A: ");
        int c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of rows of Matrix B: ");
        int r2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns of Matrix B: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        // Check multiplication condition
        if (c1 != r2)
        {
            Console.WriteLine("Matrix multiplication not possible");
            return;
        }

        int[,] A = new int[r1, c1];
        int[,] B = new int[r2, c2];
        int[,] C = new int[r1, c2];


        Console.WriteLine("Enter elements of Matrix A:");
        for (i = 0; i < r1; i++)
            for (j = 0; j < c1; j++)
                A[i, j] = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter elements of Matrix B:");
        for (i = 0; i < r2; i++)
            for (j = 0; j < c2; j++)
                B[i, j] = Convert.ToInt32(Console.ReadLine());


        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c2; j++)
            {
                C[i, j] = 0;
                for (k = 0; k < c1; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
    
        Console.WriteLine("Resultant Matrix:");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

}