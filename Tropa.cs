using System;
using System.Collections.Generic;
namespace Juego_de_Guerra
{
    public class Tropa:IAtacador
    {
        private readonly string _name;
        private List<IAtacador> _tropas;

        public Tropa(string Nombre)
        {
            _name = Nombre;
            _tropas = new List<IAtacador>();
        }
        public void PrintName()
        {
            /*Mostramos el nombre de la tropa*/
            Console.WriteLine("El nombre de la tropa es {0}", _name);

            //Nombre de los Atacadores de la tropa
            foreach(var atacador in _tropas)
            {
                atacador.PrintName();
            }
        }

        public void Atacar()
        {
            Console.WriteLine("La tropa que ataca es {0}", _name);
        }

        public void AgregarAtacador(IAtacador atacador)
        {
            _tropas.Add(atacador);
        }
    }
}