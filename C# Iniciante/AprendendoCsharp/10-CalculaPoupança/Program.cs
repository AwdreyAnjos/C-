using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 10 - Calculate Savings");

        double investimento = 1000;
        int meses = 1;
        // Rendimento de 0.5% (0.005) ao mês

        /* 
         for (int i = 0; i < meses; i++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("Investimento do mês " + i + " é R$" + investimento);
        }
        */

        while (meses <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("Investimento do mês " + i + " é R$" + investimento);
            // mes = mes + 1
            meses++;
        }


        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}