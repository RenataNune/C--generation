using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("entre com o valor deseja somar:");
                valor += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Somatoria: {valor}");

        }

         
 
    }
}
