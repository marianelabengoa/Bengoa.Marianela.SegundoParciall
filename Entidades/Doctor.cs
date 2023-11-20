using System;
using System.Text;

namespace Entidades
{
    public class Doctor : Persona
    {
        protected Euniversidad universidad;
        public string especializacion;
        public float sueldo;

        public Doctor(string nombre, string apellido, int edad, int dni, string especializacion) : base(nombre, apellido, edad, dni)
        {
            this.especializacion = especializacion;
        }

        public Doctor(string nombre, string apellido, int edad, int dni, string especializacion, float sueldo) : this(nombre, apellido, edad, dni, especializacion)
        {
            this.sueldo = sueldo;
        }

        public Doctor(string nombre, string apellido, int edad, int dni, string especializacion, float sueldo, Euniversidad universidad) : this(nombre, apellido, edad, dni, especializacion, sueldo)
        {
            this.universidad = universidad;
        }
        /// <summary>
        /// string simula que el doctor atiende
        /// </summary>
        /// <returns></returns>
        public override string RealizarAccion()
        {
            return($"El doctor{this.nombre} esta atendiendo al paciente");
        }
        /// <summary>
        /// muestra los datos especificos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("especializacion: " +this.especializacion);
            sb.AppendLine("universidad: " + this.universidad);
            sb.AppendLine("sueldo: " + this.sueldo);
            return sb.ToString();
        }
        /// <summary>
        ///muestra todos los datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public override string Mostrar(string nombre, string apellido, int edad, int dni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("especializacion: " + this.especializacion);
            sb.AppendLine("universidad: " + this.universidad);
            sb.AppendLine("sueldo: " + this.sueldo);

            sb.ToString();
            return base.Mostrar(nombre, apellido, edad, dni) + sb;
        }
        /// <summary>
        /// valida si el objeto es doctor 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Doctor)
            {
                return this == (Doctor)obj;
            }
            return retorno;
        }
        /// <summary>
        /// valida que ambos doctores no tenga nel mismo nombre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Doctor a, Doctor b)
        {
            if (a.nombre == b.nombre & a.apellido == b.apellido)
            {
                return false;
            }
            else { return true; }
        }
        /// <summary>
        /// valida si ambos doctores tienen el mismo nombre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Doctor a, Doctor b)
        {
            if (a.nombre != b.nombre & a.apellido != b.apellido)
            {
                return true;
            }
            else { return false; }
        }
    }
}

