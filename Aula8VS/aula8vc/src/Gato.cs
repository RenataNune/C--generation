using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace PraticaAula8.src
{
    internal class Gato
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        public Gato()
        {

        }

        public Gato(string _nome, string _cor, int _tamanho)
        {
            Nome = _nome;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public void dormir()
        {
            Console.WriteLine("ZZZZzzzzzzzZZZz");
        }

        public void comer(string comida)
        {
            Console.WriteLine($"estou comendo {comida}");
        }

        public string ronronar()
        {
            return "ronroneando";
        }
    }
}