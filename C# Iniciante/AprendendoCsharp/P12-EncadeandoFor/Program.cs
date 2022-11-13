using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 12 - Chaining For");

        for(int contadorlinha = 0; contadorlinha < 10; contadorlinha++)
        {
            for(int contadorColuna = 0; contadorColuna <= contadorlinha; contadorColuna++)
            {
                Console.Write("*");
          /*      if (contadorColuna >= contadorlinha) // quanto a quantidade de colunas for igual a linha vai parar o laço
                {
                    break;
                }*/
            }
            Console.WriteLine(); // Pula linha
        }

        Console.WriteLine("Please Press Enter for Exit");
        Console.ReadLine();
    }
}