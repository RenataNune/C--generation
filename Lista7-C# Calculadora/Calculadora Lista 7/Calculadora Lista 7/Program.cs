using System;

namespace Calculadora
{
   //Mallu estava na escolinha, e sua professora estava para aplicar uma prova de matemática
   //com operações básicos.A professora falou que seria possível utilizar uma calculadora.
   //Então Malluzinha começou a imaginar como seria desenvolver uma calculadora com os
   //seguintes requisitos:
   //1. Ter operadores aritméticos básicos: soma, subtração, multiplicação e divisão;
   //2. A calculadora deve ter um botão para ligar e desligar, não pode parar de rodar
   //enquanto o botão de desligar não for ativado;
    internal class Program
    {
        static void Main(string[] args)
        {
            string desligar = "0";

            Console.WriteLine("Calculadora");
            Console.WriteLine("Para iniciar digite 'c': ");
            string ligar = Console.ReadLine();
            if (ligar == ("c"))
            {
                while (desligar != "ce")
                {
                    Console.Write("digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("digite o operador: ");
                    string operador = Console.ReadLine();

                    Console.Write("digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine("resultado: " + somar(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine("resultado: " + subtrair(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine("resultado: " + multiplicar(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine("resultado: " + dividir(num1, num2));
                            break;
                    }
                    Console.WriteLine("Para desligar digite aperte 'ce', para continuar digite 'cont'");
                    desligar = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Volte mais tarde");
            }

            Console.WriteLine("obrigado por usar a nossa calculadora!");
        }

        public static string somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualAZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}