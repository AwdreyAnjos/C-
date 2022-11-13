using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 5 - Caracters and Texts");
        
        char letra = 'a'; // Para atribuir a uma variável 1 caractere
        Console.WriteLine(letra);

        letra = (char)65; // Atribuindo um caractere pela tabela ASCII
        Console.WriteLine(letra);

        letra = (char)(65 + 1); // Somando Baseado na tabela ASCII
        Console.WriteLine(letra);

        string primeiraFrase = "Alura = Technology Course"; // Para receber um texto
        Console.WriteLine(primeiraFrase);

        string cursos = @"Curses Alura:  
- GO 
- C# 
- PYTHON 
- HTML";  // @ é para atribuir a quebra de linha no texto
        Console.WriteLine(cursos); 

        Console.WriteLine("Please Press Enter for Exit...");
        Console.ReadLine();
    }
}