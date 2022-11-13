using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 9 - Scope");

        int idadeJoao = 17;
        bool acompanhado = false;
        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "»»»» JOÃO IS ACCOMPANIED ««««";
        }else{
            textoAdicional = "»»»» JOÃO IS NOT ACCOMPANIED ««««";
        }

        if (idadeJoao >= 18 || acompanhado == true)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("»»»» ALLOWED ENTRY ««««");

        }
        else
        {
            Console.WriteLine("»»»» NO ENTRY ««««");
        }

        Console.WriteLine("Please Press Enter for Exit");
        Console.ReadLine();
    }
}