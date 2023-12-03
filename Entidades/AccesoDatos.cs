using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadena_connexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static AccesoDatos()
        {
            AccesoDatos.cadena_connexion = Properties.Resources.miConexion;
            //cadena_connexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Pacientes;Integrated Security=True;Trust Server Certificate=True";
        }
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_connexion);
        }
        public bool PruebaConexion()
        {
            bool ret = false;

            try
            {
                this.conexion.Open();
                ret = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return ret;
        }

        public List<Paciente> ObtenerListaDato(Paciente paciente)
        {
            List<Paciente> lista = new List<Paciente>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Nombre, Apellido, Edad, DNI, NumeroHabitacion, ObraSocial, FechaNacimiento from tabla_pacientes";
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    //Paciente paciente = pac
                    paciente.Nombre = this.lector[0].ToString();
                    paciente.Apellido = this.lector[1].ToString();
                    paciente.Edad = (int)this.lector[2];
                    paciente.Dni = (int)this.lector[3];
                    paciente.numeroHabitacion = (int)this.lector[4];
                    paciente.obraSocial = (EObraSocial)this.lector[5];
                    paciente.fechaNacimiento = (DateTime)this.lector[6];

                    lista.Add(paciente);
                }

                lector.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }

        public bool AgregarDato(Paciente paciente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"insert into dato (cadena, entero, flotante) values({dato.cadena}, {dato.entero}, {dato.flotante})";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
    }
}
