using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GenericsListaEspera<Visita> //where Visita : class, new()
    {
        private List<Visita> lista;
        private int capacidad;

        public GenericsListaEspera(int capacidad)
        {
            this.lista = new List<Visita>();
            this.capacidad = capacidad;
        }

        public List<Visita> Lista { get => this.lista; set => this.lista = value; }


        public bool Agregar(Visita dato)
        {

            if (this.lista.Count < this.capacidad)
            {
                this.lista.Add(dato);
                return true;
            }

            return false;
        }
        public bool Eliminar(Visita dato) 
        {
            this.lista.Remove(dato);
            return true;
        }
    }
}
