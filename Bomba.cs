using System;
namespace Juego_de_Guerra
{
    public class Bomba: IAtacador
    {
        private readonly string _name;

        public Bomba(string Name)
        {
            _name = Name;
        }

        public void PrintName()
        {
          Console.WriteLine("El nombre de la bomba es {0}", _name);  
        }

        public void Atacar()
        {
            Console.WriteLine("La bomba que ataca es {0}", _name); 
        }
    }
}