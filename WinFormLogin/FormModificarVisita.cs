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
        private List<Visita> lista;
        public FormModificarVisita(List<Visita> listVisita)
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


                Visita visita = this.lista[indice];
                lista.RemoveAt(indice);
                this.Actualizar();
            }
        }
        /**private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstPac.SelectedIndex != -1)
            {
                // Remove the selected item from the list
                int indice = lstPac.SelectedIndex;
                Visita visita = lista[indice];
                lista.Remove(visita);

                // Update the ListBox by setting the DataSource again
                lstPac.DataSource = null;
                lstPac.DataSource = lista;

                // Optionally, you can clear the selection
                lstPac.ClearSelected();
            }
            else
            {
                MessageBox.Show("Seleccione una visita para eliminar.");
            }
        }*/
        private void Actualizar()
        {
            this.lstPac.Items.Clear();
            foreach (Visita visita in lista)
            {
                lstPac.Items.Add(visita.ToString());
            }
        }
    }
}
