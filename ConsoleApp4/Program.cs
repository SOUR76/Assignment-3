using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        if (int.TryParse(Console.ReadLine(), out int Limit) && Limit >= 2)
        {
            PrintPrime(Limit);
        }
    }
    static void PrintPrime(int Limit)
    {
        bool[] Prime = new bool[Limit + 1];
        for (int i = 2; i <= Limit; i++)
        {
            Prime[i] = true;
        }
        for (int i = 2; i <= Math.Sqrt(Limit); i++)
        {
            if (Prime[i])
            {
                for (int j = i * i; j <= Limit; j += i)
                {
                    Prime[j] = false;
                }
            }
        }
        Console.WriteLine($"Prime numbers up to {Limit}");
        for (int i = 2; i <= Limit; i++)
        {
            if (Prime[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}