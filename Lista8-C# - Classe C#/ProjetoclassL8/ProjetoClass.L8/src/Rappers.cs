using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClass.L8.src
{

    internal class Rappers
    {
        public string Nome { get; set; }
        public string Profissão { get; set; }
        public int Idade { get; set; }
        
       
        public Rappers(string _nome, string _profissão, int _idade)
        {
            Nome = _nome;
            Profissão = _profissão;
            Idade = _idade;
        }
        
        public void falar(string falar)
        {
            Console.WriteLine("For my niggas who be thinkin we soft, we dont play");
        }

        public void cantar(string falar)
        {
            Console.WriteLine($"Snoop Dogg Dolls {falar}");
        }
        public string dança()
        {
            return "Crip Walk";
        }

        internal string CripWalk()
        {
            throw new NotImplementedException();
        }
    }
}
