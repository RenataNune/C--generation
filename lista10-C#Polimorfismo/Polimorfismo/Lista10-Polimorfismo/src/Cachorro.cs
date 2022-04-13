using System;

namespace animal.src
{
    public class Cachorro : Animal
    {
        public Cachorro() { }

        public Cachorro(string nome, string cor, string comunicacao) : base(nome, cor, comunicacao) { }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
    }
}