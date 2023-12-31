﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

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
            //AccesoDatos.cadena_connexion = Properties.Resources.miConexion;
            cadena_connexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Pacientes;Integrated Security=True;Trust Server Certificate=True";
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
                throw new MySqlException( "Error en la conexion", ex);
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

        public ListaPacientes ObtenerListaPacientes()
        {
            ListaPacientes lista = new ListaPacientes();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                //this.comando.CommandText = "select Nombre, Apellido, Edad, DNI, NumeroHabitacion, ObraSocial, FechaNacimiento from tabla_pacientes";
                this.comando.CommandText = "SELECT Nombre, Apellido, Edad, DNI, NumeroHabitacion FROM tabla_pacientes";
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Nombre = this.lector[0].ToString();
                    paciente.Apellido = this.lector[1].ToString();
                    paciente.Edad = (int)this.lector[2];
                    paciente.Dni = (int)this.lector[3];
                    paciente.numeroHabitacion = (int)this.lector[4];
                    //paciente.obraSocial = (EObraSocial)this.lector[5];
                    //paciente.fechaNacimiento = (DateTime)this.lector[6];

                    lista.Agregar(paciente);
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


        /*public bool AgregarPaciente(Paciente paciente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Pacientes (Nombre, Apellido, Edad, DNI, numeroHabitacion, ObraSocial, FechaNacimiento) VALUES (@Nombre, @Apellido, @Edad, @Dni, @numeroHabitacion, @obraSocial, @fechaNacimiento)";

                // Use parameters to avoid SQL injection
                this.comando.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                this.comando.Parameters.AddWithValue("@Edad", paciente.Edad);
                this.comando.Parameters.AddWithValue("@Dni", paciente.Dni);
                this.comando.Parameters.AddWithValue("@numeroHabitacion", paciente.numeroHabitacion);
                this.comando.Parameters.AddWithValue("@obraSocial", paciente.obraSocial);
                this.comando.Parameters.AddWithValue("@fechaNacimiento", paciente.fechaNacimiento);

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
                // Handle or log the exception
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }*/
        public bool AgregarPaciente(Paciente paciente)
        {
            bool retorno = false;
            try
            {
                // Open the connection
                this.conexion.Open();

                // Create a SqlCommand with parameters
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "INSERT INTO tabla_pacientes (Nombre, Apellido, DNI, Edad, NumeroHabitacion) " +
                                           "VALUES (@nombre, @apellido, @dni, @edad, @numeroHabitacion)";
                this.comando.Parameters.AddWithValue("@nombre", paciente.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", paciente.Apellido);
                this.comando.Parameters.AddWithValue("@dni", paciente.Dni);
                this.comando.Parameters.AddWithValue("@edad", paciente.Edad);
                this.comando.Parameters.AddWithValue("@numeroHabitacion", paciente.numeroHabitacion);
                this.comando.Connection = this.conexion;

                // Execute the query
                int filasAfectadas = this.comando.ExecuteNonQuery();

                // Check if any rows were affected
                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }

    }
}
