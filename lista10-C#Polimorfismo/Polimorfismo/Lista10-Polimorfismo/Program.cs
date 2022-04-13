using System;
using System.Collections.Generic;
using animal.src;

namespace animal.src

{
    class Program
    {
        static void Main(string[] args)
        {
            //nova forma de implementar listas
            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Mingau", "Branca", "Felino"),
                    new Cachorro("Cachorro Luck", "Preto", "Canídio"),
                    new Cachorro("Cachorro Niki", "Preto e Branco", "Canídio"),
                    new Gato("Gato Léo", "Cinza", "Felino"),
                    new Macaco("George", "Marrom", "Primata")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Meu whiskas!");
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Uhuuu HAHAHA!");
                }
            }
        }
    }
}