using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Challenge - Aliquot if's");

        double salario = 3300.0;

        if (salario >= 1900.0 & salario <= 2800.0)
        {
            double ir = 7.5;
            double deduzir =  142.0;
            Console.WriteLine("Sua aliquota é de " + ir + "%, você pode deduzir até R$" + deduzir);
        }
        else if (salario >= 2800.01 & salario <= 3751.0)
        {
            double ir = 15.0;
            double deduzir = 350.0;
            Console.WriteLine("Sua aliquota é de " + ir + "%, você pode deduzir até R$" + deduzir);
        }
        else if (salario >= 3751.0 & salario <= 4664.0)
        {
            double ir = 22.5;
            double deduzir = 636.0;
            Console.WriteLine("Sua aliquota é de " + ir + "%, você pode deduzir até R$" + deduzir);
        }
        else
            Console.WriteLine("»»» VALOR SEM PAREÊTRO DO IR «««");

        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}