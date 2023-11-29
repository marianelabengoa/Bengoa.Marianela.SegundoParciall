using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static System.Windows.Forms.DataFormats;

namespace WinFormLogin
{
    public partial class Main : Form
    {
        private delegate void CambiarColorDelegate(Color color);
        private event CambiarColorDelegate CambiarColorEvent;
        public static ListaPacientes lista = new ListaPacientes();
        public Main()
        {
            InitializeComponent();
            CambiarColorEvent += CambiarColorBoton;
            btnIngresar.MouseHover += BtnIngresar_MouseBoton;
            btnCancelIngreso.MouseHover += BtnCancel_MouseBoton;
        }

        public Main(Usuario usuario) : this()
        {
            MessageBox.Show($"Bienvenido {usuario.Nombre} {usuario.Apellido}");
        }

        protected virtual void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarNoVacio(txtNombre.Text, "Nombre") && ValidarNoVacio(txtApellido.Text, "Apellido") && ValidarNumerico(txtDni.Text, "DNI") && ValidarNumerico(txtEdad.Text, "Edad") && ValidarNumerico(txtNumHabitacion.Text, "Número de Habitación"))
            {

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                int numeroHabitacion = int.Parse(txtNumHabitacion.Text);
                Paciente paciente = null;



                DialogResult obraConfirm = MessageBox.Show("¿El paciente posee obra social/prepaga?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (obraConfirm == DialogResult.Yes)
                {
                    this.Hide();
                    FormObraSocial frmobra = new FormObraSocial();
                    DialogResult result = frmobra.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        EObraSocial obraSocial = frmobra.ObtenerObra();
                        frmobra.Close();

                        DialogResult fechaaConfirm = MessageBox.Show("¿Conoce la fecha de nacimiento del paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (fechaaConfirm == DialogResult.Yes)
                        {
                            FormFechaNacimiento frmFecha = new FormFechaNacimiento();
                            DialogResult resulta = frmFecha.ShowDialog();
                            if (resulta == DialogResult.OK)
                            {
                                DateTime fechaNacimiento = frmFecha.ObtenerFecha();
                                frmFecha.Close();

                                paciente = new Paciente(nombre, apellido, edad, dni, numeroHabitacion, obraSocial, fechaNacimiento);
                            }
                            else
                            {
                                paciente = new Paciente(nombre, apellido, edad, dni, numeroHabitacion, obraSocial);
                            }
                        }
                        else
                        {

                            paciente = new Paciente(nombre, apellido, edad, dni, numeroHabitacion, obraSocial);
                        }
                    }
                    else
                    {
                        paciente = new Paciente(nombre, apellido, edad, dni, numeroHabitacion);
                    }
                }
                else
                {
                    paciente = new Paciente(nombre, apellido, edad, dni, numeroHabitacion);
                }


                if (paciente != null)
                {
                    Pagar(paciente);

                    FormDoctores doctores = new FormDoctores();
                    DialogResult r = doctores.ShowDialog();

                    if (r == DialogResult.OK)
                    {
                        Doctor doctor = doctores.ObtenerDoctor();
                        MessageBox.Show($"{doctor.RealizarAccion()}");
                        MessageBox.Show($"{paciente.RealizarAccion()}");
                    }
                }

                MessageBox.Show($"{lista}");

                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDni.Text = string.Empty;
                txtEdad.Text= string.Empty;
                txtNumHabitacion.Text = string.Empty;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void Pagar(Paciente paciente)
        {
            float monto = paciente.Pagar(paciente);
            DialogResult montoConfirm = MessageBox.Show("el paciente debe pagar un monto de " + monto, "confirm", MessageBoxButtons.OK);

            if (montoConfirm == DialogResult.OK)
            {
                fromModoPago frmModoPago = new fromModoPago(monto);
                DialogResult resultado = frmModoPago.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    monto = frmModoPago.ObtenerMonto();
                    frmModoPago.Close();

                    DialogResult montoConfirma = MessageBox.Show("el monto final es de " + monto, "confirm", MessageBoxButtons.OK);

                    if (montoConfirma == DialogResult.OK)
                    {
                        IngresoPaciente(paciente);
                    }
                }
            }
        }

        private void IngresoPaciente(Paciente paciente)
        {
            if (lista + paciente)
            {
                MessageBox.Show($"{paciente.Nombre} ha ingresado a la habitacion {paciente.numeroHabitacion} en el dia de la fecha: {DateTime.Now}");
            }
            else
            {
                MessageBox.Show("el paciente se encuentra en la habitacion");
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        protected void btnCancelIngreso_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
        }
        protected virtual bool ValidarNumerico(string input, string fieldName)
        {
            if (!int.TryParse(input, out _))
            {
                MessageBox.Show($"El valor ingresado para {fieldName} no es válido. Debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        protected virtual bool ValidarNoVacio(string text, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"El campo {fieldName} no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CambiarColorBoton(Color color)
        {
            if (btnIngresar.InvokeRequired)
            {
                // Si es necesario, invocar el método en el subproceso correcto
                btnIngresar.Invoke(new CambiarColorDelegate(CambiarColorBoton), color);
            }
            else
            {
                // Cambiar el color del botón
                btnIngresar.BackColor = color;
            }
        }
        private void BtnIngresar_MouseBoton(object sender, EventArgs e)
        {
            // Invoca el evento para cambiar el color del botón a verde
            CambiarColorEvent?.Invoke(Color.Green);
        }
        private void BtnCancel_MouseBoton(object sender, EventArgs e)
        {
            // Invoca el evento para cambiar el color del botón a verde
            CambiarColorEvent?.Invoke(Color.Red);
        }
    }
}
