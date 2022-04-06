using System;

namespace Projimc1
{
    class Program
    {
        static void Main(string[] args)
        {

            float altura, peso, imc;

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + "!" + "Vamos calcular seu IMC! Qual o seu peso? ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura em metros?");
            altura = float.Parse(Console.ReadLine());


            imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Abaixo do peso recomendado. ");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Peso normal. ");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Seu imc é: " + imc + "." + "Sobrepeso. ");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Obesidade.");
            }

        }
    }
}

