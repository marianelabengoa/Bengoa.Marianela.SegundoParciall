using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLogin
{
    public partial class FormModificarVisita : Form
    {
        private GenericsListaEspera<Visita> lista;
        public FormModificarVisita(GenericsListaEspera<Visita> listVisita)
        {
            InitializeComponent();
            this.lista = listVisita;
            //lstPac.DataSource = listVisita;
        }

        private void FormModificarVisita_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show("hola");
            try
            {
                // Asegúrate de que listaVisitas no sea null
                if (formVisita.listaVisitas != null)
                {
                    foreach (Visita visita in formVisita.listaVisitas)
                    {
                        MessageBox.Show(visita.ToString());
                        Console.WriteLine(visita.Mostrar);
                        this.lstPac.Items.Add(visita.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("no");
                }
            }
            catch (NullReferenceException ex)
            {
                // Maneja la excepción (puedes mostrar un mensaje, registrarla, etc.)
                MessageBox.Show($"Se produjo una excepción: {ex.Message}");
            }*/
            /*this.lstPac.Items.Clear();
            foreach (Visita visita in lista)
            {
                lstPac.Items.Add(visita.ToString());
            }*/
            this.Actualizar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPac.SelectedIndex != -1)
            {
                int indice = this.lstPac.SelectedIndex;


                Visita visita = lista.Lista[indice];

                txtNombre.Text = visita.Nombre;
                txtApellido.Text = visita.Apellido;
                txtDNI.Text = visita.Dni.ToString();
                txtEdad.Text = visita.Edad.ToString();
                if (visita.numeroHabitacion != null)
                { 
                    txtNumHab.Text = visita.numeroHabitacion.ToString();
                }
                if(visita.parentesco!=null)
                {

                    txtParentesco.Text = visita.parentesco;
                }

                if(btnAceptar.DialogResult == DialogResult.OK)
                {
                    /*visita.Nombre=txtNombre.Text;
                    visita.Apellido=txtApellido.Text;
                    visita.Dni=int.Parse(txtDNI.Text);
                    visita.Edad=int.Parse(txtEdad.Text);
                    visita.numeroHabitacion=int.Parse(txtNumHab.Text);
                    visita.parentesco=txtParentesco.Text;*/
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int dni = int.Parse(txtDNI.Text);
                    int edad = int.Parse(txtEdad.Text);
                    int numeroHabitacion = int.Parse(txtNumHab.Text);
                    string parentesco = txtParentesco.Text;
                    Visita nuevaVisita =new Visita(nombre, apellido, edad, dni, visita.paciente, numeroHabitacion, parentesco);
                    this.lista.Lista[indice]=nuevaVisita;
                    
                    this.Actualizar();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Elimina el elemento seleccionado de la lista
            //lista.Remove((Visita)lstPac.SelectedItem);

            // Actualiza el ListBox con la lista actualizada
            //lstPac.DataSource = null;
            //lstPac.DataSource = lista;
            if (lstPac.SelectedIndex != -1)
            {
                int indice = this.lstPac.SelectedIndex;
                lista.Lista.RemoveAt(indice);
                this.Actualizar();
            }
        }
        
        private void Actualizar()
        {
            this.lstPac.Items.Clear();
            foreach (Visita visita in lista.ListaEspera())
            {
                lstPac.Items.Add(visita.Mostrar());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCambio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
