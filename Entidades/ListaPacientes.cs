using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaPacientes
    {
        /// <summary>
        /// defino lista
        /// </summary>
        protected List<Paciente> pacientes;
        /// <summary>
        /// constructor que inicializa la lista
        /// </summary>
        public ListaPacientes() 
        {
            this.pacientes = new List<Paciente>();
        }
        /// <summary>
        /// sobrecarga metodo tostring que muestra los datos de los pacientes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            foreach (Paciente paciente in this.pacientes)
            {
                sb.AppendLine(paciente.ToString());
            }
            
            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga operador == que valida si la lista ya contiene ese paciente
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator ==(ListaPacientes lista, Paciente paciente)
        {
            return lista.pacientes.Contains(paciente);
        }
        /// <summary>
        /// operador != que valida si la lista no tiene al paciente
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator !=(ListaPacientes lista, Paciente paciente)
        {
            return !(lista == paciente);
        }

        /// <summary>
        /// sobrecarga operador + que agrega al paciente solo si no lo contiene
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator +(ListaPacientes lista, Paciente paciente)
        {
            if (lista.pacientes.Contains(paciente))
            {
                return false;
            }
            else
            {
                lista.pacientes.Add(paciente);
                return true;
            }
        }
        /// <summary>
        /// sobrecarga operador - que elimina si ya lo tiene
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator -(ListaPacientes lista, Paciente paciente)
        {
            if (lista.pacientes.Contains(paciente))
            {
                lista.pacientes.Remove(paciente);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// metodo que me permite ordenar las edades de manera ascendente
        /// </summary>
        /// <returns></returns>
        public List<Paciente> OrdenarPorEdadAscendente()
        {
            return pacientes.OrderBy(paciente => paciente.Edad).ToList();
        }
        /// <summary>
        /// metodo que me permite ordenar las edades de manera descendente
        /// </summary>
        /// <returns></returns>
        public List<Paciente> OrdenarPorEdadDescendente()
        {
            return pacientes.OrderByDescending(paciente => paciente.Edad).ToList();
        }

        public IEnumerator<Paciente> GetEnumerator()
        {
            return pacientes.GetEnumerator();
        }

        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
        /// <summary>
        /// indexador
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Paciente this[int index]
        {
            get
            {
                if (index >= 0 && index < pacientes.Count)
                {
                    return pacientes[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fuera de rango");
                }
            }
        }

        public bool Verificar()
        {
            if (pacientes.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
