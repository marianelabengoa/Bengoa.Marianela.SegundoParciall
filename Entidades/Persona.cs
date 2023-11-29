using System.Text;

namespace Entidades
{
    public abstract class Persona : Object
    {
        /// <summary>
        /// declaro las variables
        /// </summary>
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected int dni;

        public string Nombre
        {
            get { return nombre; } 
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public int Dni
        {
            get 
            {
                if (dni > 13000000)
                {
                    return dni;
                }
                else
                {
                    return 0;
                }
            }
            set { dni = value; }
        }

        public int Edad
        {
            
            get 
            {
                if (edad > 0)
                {
                    return edad;
                }
                else
                {
                    return 0;
                }
            }

            set { edad = value; }
        }
        /// <summary>
        /// constructores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int dni) :this(nombre, apellido)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, int edad, int dni):this(nombre, apellido, dni)
        {
            this.edad = edad;  
        }
        /// <summary>
        /// muestra los datos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("nombre: " + this.nombre);
            sb.Append("apellido: " + this.apellido);
            sb.Append("edad: " + this.edad);
            sb.Append("DNI " + this.dni);

            return sb.ToString();
        }
        /// <summary>
        /// verifica que sea persona
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Persona)
            {
                return this == (Persona)obj;
            }
            return retorno;
        }
        /// <summary>
        /// segun quien lo herede realizara una accion u otra
        /// </summary>
        /// <returns></returns>
        public abstract string RealizarAccion();
        /// <summary>
        /// muestra los datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return ("nombre: " + this.nombre + ", apellido: " + this.apellido + ", edad: " + this.edad + ", DNI " + this.dni);
        }
        /// <summary>
        /// segun la obra social cambia el preciode la consulta
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual float Pagar(Paciente p)
        {
            float monto = 1000.0f;

            if(p.obraSocial== EObraSocial.Galeno)
            {
                monto -= (monto * 30) / 100;
            }
            else if(p.obraSocial == EObraSocial.Omint)
            {
                monto -= (monto * 20) / 100;
            }
            else if (p.obraSocial == EObraSocial.OSECAC)
            {
                monto -= (monto * 25) / 100;
            }
            else if (p.obraSocial == EObraSocial.OSDE)
            {
                monto -= (monto * 50) / 100;
            }
            else if (p.obraSocial == EObraSocial.IOMA)
            {
                monto -= (monto * 5) / 100;
            }
            return monto;
        }
        /// <summary>
        /// las visitas deben pagar
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public virtual float Pagar(Visita v)
        {
            return 1500.0f;
        }

    }
}
