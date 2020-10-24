using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_de_Guerra
{
    public class Soldado: IAtacador
    {
        /*Hay que implementar los metodos de IATACADOR*/

        private readonly string _name;

        public Soldado(string Nombre)
        {
            _name = Nombre;
        }

        public void PrintName()
        {
            Console.WriteLine("Mi nombre es {0}", _name);
        }
        public void Atacar()
        {
            Console.WriteLine("Soy el soldado {0} que ataca", _name);
        }


    }
}