using System;

namespace Juego_de_Guerra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IAtacador soldado1 = new Soldado("Soldado 1");
            IAtacador cañon1 = new Canion("Cañon 1");
            IAtacador bomba1 = new Bomba("Bomba 1");
            Tropa tropa1 = new Tropa("Tropa 1");

            tropa1.AgregarAtacador(soldado1);
            tropa1.AgregarAtacador(cañon1);

            Tropa tropa2 = new Tropa("Tropa 2");
            tropa2.AgregarAtacador(bomba1);
            tropa1.AgregarAtacador(tropa2);

            tropa1.PrintName();
            tropa1.Atacar();
            
            Console.ReadKey();
        }
    }
}
