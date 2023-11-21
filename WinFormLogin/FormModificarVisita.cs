using Entidades;
using System;
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
        public FormModificarVisita(List<Visita> listVisita)
        {
            InitializeComponent();
            lstPac.DataSource = listVisita;
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
