using System;
namespace Juego_de_Guerra
{
    public class Canion:IAtacador
    {
        private readonly string _name;

        public Canion(string Name)
        {
            _name=Name;
        }
        public void PrintName()
        {
            Console.WriteLine("Mi nombre es {0}", _name);
        }

        public void Atacar()
        {
            Console.WriteLine("Soy el canion {0} y ataco", _name);
        }
    }
}