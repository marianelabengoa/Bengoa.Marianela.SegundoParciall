using System;
using System.Text;

namespace Entidades
{
    public class Paciente : Persona
    {
        /// <summary>
        /// defino las valiables
        /// </summary>
        public DateTime fechaNacimiento;

        public EObraSocial obraSocial;

        public int numeroHabitacion
        {
            get;
            set;
        }
        /// <summary>
        /// defino constructores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="numeroHabitacion"></param>
        public Paciente(string nombre, string apellido, int edad, int dni, int numeroHabitacion) : base(nombre, apellido, edad, dni)
        {
            this.numeroHabitacion = numeroHabitacion;
            this.fechaNacimiento = DateTime.MinValue;
            this.obraSocial = EObraSocial.noPosee;
        }

        public Paciente(string nombre, string apellido, int edad, int dni, int numeroHabitacion, EObraSocial obraSocial) : this(nombre, apellido, edad, dni, numeroHabitacion)
        {
            this.fechaNacimiento = DateTime.MinValue;
            this.obraSocial = obraSocial;
        }

        public Paciente(string nombre, string apellido, int edad, int dni, int numeroHabitacion, EObraSocial obraSocial, DateTime fechaNacimiento) : this(nombre, apellido, edad, dni, numeroHabitacion, obraSocial)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public Paciente()
        {

        }
        /// <summary>
        /// metodo que simula que el paciente esta siendo atendido
        /// </summary>
        /// <returns></returns>
        public override string RealizarAccion()
        {
            return($"{this.nombre} esta siendo atendido");
        }
        /// <summary>
        /// sobrecarga metodo tostring que muestra los datos del paciente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("nombre : " + this.nombre);
            sb.AppendLine("apellido: " + this.apellido);
            sb.AppendLine("edad: " + this.edad);
            sb.AppendLine("dni: " + this.dni);
            sb.AppendLine("obra social: " + this.obraSocial);
            sb.AppendLine("numero habitacion: " + this.numeroHabitacion);
            if(fechaNacimiento != DateTime.MinValue)
            {
                sb.AppendLine("fecha nacimiento: " + this.fechaNacimiento);
            }

            return sb.ToString();
        }
        /// <summary>
        /// metodo mostrar que muestra los datos del paciente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public override string Mostrar()
        {
            
            return base.Mostrar();

        }
        /// <summary>
        /// sobrecarga metodo equals que valida wu los pacientes no tengan los mismos datos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Paciente);
        }
        /// <summary>
        /// sobrecarga operador == que valida que los pacientes no tengan e mismo nombre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Paciente a, Paciente b)
        {
            if (a.nombre == b.nombre & a.apellido == b.apellido)
            {
                return true;
            }
            else { return false; }
        }
        /// <summary>
        /// sobrecarga operador == que valida que los pacientes no tengan e mismo nombre ni sean null
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Paciente a, Paciente b)
        {
            if (a is null || b is null)
            {
                return true;
            }

            return a.nombre != b.nombre || a.apellido != b.apellido; 
        }




    }
}
