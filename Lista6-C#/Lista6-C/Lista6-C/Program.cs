using System;

namespace Tabuada
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual tabuada você gotaria de ver? ");
            int tab = Convert.ToInt16(Console.ReadLine());
            for (int e = 1; e <= 10; e++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    Console.WriteLine(tab + " x " + c + " = " + tab * c);
                }


                Console.Read();
            }

        }
    }
}