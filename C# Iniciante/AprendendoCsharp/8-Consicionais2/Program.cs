using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 8 - Conditional 2");

        int ageJoao = 18;
        int amountPeople = 2;

        bool supervison = amountPeople > 1;

        if (ageJoao >= 18 || amountPeople > 1)
        {
            Console.WriteLine("»» FREE ENTRY ««");
        }
        else
        {
            Console.WriteLine("»» NO ENTRY ««");
        }

        Console.WriteLine("Please Press Enter for Exit ");
        Console.ReadLine();
    }
}