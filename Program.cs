using System;

namespace Juego_de_Guerra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Soldado atacador1 = new Soldado("Soldado 1");
            atacador1.PrintName();
            atacador1.Atacar();
            Console.ReadKey();
        }
    }
}
