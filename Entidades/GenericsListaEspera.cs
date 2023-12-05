using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GenericsListaEspera<T> where T : Visita
    {
        private static List<Visita> lista;
        private int capacidad;
        private static int cont;

        public GenericsListaEspera(int capacidad)
        {
            GenericsListaEspera<Visita>.lista = new List<Visita>();
            this.capacidad = capacidad;
        }

        public List<Visita> Lista { get => GenericsListaEspera<Visita>.lista; set => GenericsListaEspera<Visita>.lista = value; }


        public bool Agregar(Visita dato)
        {

            if (GenericsListaEspera<Visita>.cont < this.capacidad)
            {
                GenericsListaEspera<Visita>.lista.Add(dato);
                cont++;
                if(cont==lista.Count)
                {
                    return true;
                }
                
            }

            return false;
        }
        public bool Eliminar(Visita dato) 
        {
            GenericsListaEspera<Visita>.lista.Remove(dato);
            return true;
        }

        public List<Visita> ListaEspera()
        {
            return GenericsListaEspera<Visita>.lista;
        }
    }
}
