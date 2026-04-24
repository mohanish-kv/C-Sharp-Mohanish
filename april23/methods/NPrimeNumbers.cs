using System;

class CheckPrime
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.WriteLine("Give the n value:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First " + n + " prime numbers are:");

        int count = 0;
        int num = 2;

        while (count < n)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
                count++;
            }
            num++;
        }
    }
}