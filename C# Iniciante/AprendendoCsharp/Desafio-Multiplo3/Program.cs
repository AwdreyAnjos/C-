using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge - multiple 3");

        for (double numero = 0; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine("This number: " + numero + " is a multiple 3");
            }
        }
        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}