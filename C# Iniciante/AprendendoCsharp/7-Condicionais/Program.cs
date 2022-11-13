using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 7 - Conditional");
        // Show que somente pessoas maiores de 18 ou acompanhadas podem entrar

        int ageEliana = 16; // idade diana
        int amountPeople = 2; // Quantas pessoas estão acompanhando Eliana

        if (ageEliana >= 18)
        {
            Console.WriteLine("--- Free Entry ---"); 
        }
        else
        {
            if (amountPeople > 2)
            {
                Console.WriteLine("--- Realead Supervised Entry ---"); // Entrada Supervionada Liberada
            }
            else
            {
                Console.WriteLine("--- No Entry ---");
            }
            
        }

        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}