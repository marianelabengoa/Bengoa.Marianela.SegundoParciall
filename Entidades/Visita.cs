using System;
using System.Text;

namespace Entidades
{
    public class Visita : Persona
    {
        /// <summary>
        /// inicio las variables
        /// </summary>
        public string paciente;
        public int numeroHabitacion;
        public string parentesco;

        /// <summary>
        /// constructores
        /// </summary>
        /// 
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="paciente"></param>
        public Visita(string nombre, string apellido, int edad, int dni, string paciente) : base(nombre, apellido, edad, dni)
        {
            this.paciente = paciente;
        }

        public Visita(string nombre, string apellido, int edad, int dni, string paciente, int numeroHabitacion) : this(nombre, apellido, edad, dni, paciente)
        {
            this.numeroHabitacion = numeroHabitacion;
        }

        public Visita(string nombre, string apellido, int edad, int dni, string paciente, int numeroHabitacion, string parentesco) : this(nombre, apellido, edad, dni, paciente, numeroHabitacion)
        {
            this.parentesco = parentesco;
        }
        /// <summary>
        /// simula ser atendido
        /// </summary>
        /// <returns></returns>
        public override string RealizarAccion()
        {
            return ($"{this.nombre} esta visitando a {this.paciente}");
        }
        /// <summary>
        /// muestra los datos especificos de la visita
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("paciente: " + this.paciente);
            sb.AppendLine("numero habitacion: " + this.numeroHabitacion);
            sb.AppendLine("parentesco: " + this.parentesco);

            sb.ToString();
            return sb.ToString();
        }
        /// <summary>
        /// muestra los datosde la visita
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public override string Mostrar(string nombre, string apellido, int edad, int dni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("paciente: " + this.paciente);
            sb.AppendLine("numero habitacion: " + this.numeroHabitacion);
            sb.AppendLine("parentesco: " + this.parentesco);

            sb.ToString();
            return base.Mostrar(nombre, apellido, edad, dni) + sb;
        }
        /// <summary>
        /// verifica que el obj sea visita
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Visita)
            {
                return this == (Visita)obj;
            }
            return retorno;
        }
        /// <summary>
        /// valida que no tnegan el mismo nombre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Visita a, Visita b)
        {
            if (a.nombre == b.nombre & a.apellido == b.apellido)
            {
                return false;
            }
            else { return true; }
        }
        /// <summary>
        /// valida queno tengan el mismo nombre ni sean null
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Visita a, Visita b)
        {
            if (a is null || b is null)
            {
                return true;
            }

            return a.nombre != b.nombre || a.apellido != b.apellido;
        }

    }
}

