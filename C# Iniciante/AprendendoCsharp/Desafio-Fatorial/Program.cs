using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge - Factorial");
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }

        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}

   