using ProjetoClass.L8.src;
using System;

namespace ProjetoClass.L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rappers");
            Rappers SnoopDogg = new Rappers("SnoopDogg", "Cantor", 50);
            Rappers DrDre = new Rappers("DrDre", "produtor musical", 57);
            Rappers NateDogg = new Rappers("NateDogg", "Cantor", 41);

            Console.WriteLine($"Rapper 1 é o {SnoopDogg.Nome} Profissão {SnoopDogg.Profissão} Idade {SnoopDogg.Idade}");
            Console.WriteLine($"Rapper 2 é o {DrDre.Nome} Profissão {DrDre.Profissão} idade {DrDre.Idade}");
            Console.WriteLine($"Rapper 3 é o {NateDogg.Nome} Profissão {NateDogg.Profissão} idade {NateDogg.Idade}");
            
            NateDogg.cantar("For my niggas who be thinkin we soft, we dont play");
            SnoopDogg.cantar("Snoop Dogg Dolls");
            string retorno = DrDre.dança();
            Console.WriteLine(retorno);

        }
    }
}
