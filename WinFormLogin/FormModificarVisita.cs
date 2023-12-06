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
        FrmLogin frml = new FrmLogin();
        public static GenericsListaEspera<Visita> lista;
        public FormModificarVisita(GenericsListaEspera<Visita> listVisita)
        {
            InitializeComponent();
            lista = listVisita;
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

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Elimina el elemento seleccionado de la lista
            //lista.Remove((Visita)lstPac.SelectedItem);

            // Actualiza el ListBox con la lista actualizada
            //lstPac.DataSource = null;
            //lstPac.DataSource = lista;
            if (FrmLogin.i == 3)
            {
                if (lstPac.SelectedIndex != -1)
                {
                    int indice = this.lstPac.SelectedIndex;
                    lista.Lista.RemoveAt(indice);
                    this.Actualizar();
                }
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
