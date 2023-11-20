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
    public partial class FormObraSocial : Form
    {
        private EObraSocial obraSocial;

        public FormObraSocial()
        {
            InitializeComponent();
        }

        private void btnAceptarObra_Click(object sender, EventArgs e)
        {
            string obra = txtObraSocial.Text;

            if (Enum.TryParse(typeof(EObraSocial), obra, out object obraSocialEnum))
            {
                obraSocial = (EObraSocial)obraSocialEnum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Obra social no válida. Intente nuevamente.");
            }
        }

        public EObraSocial ObtenerObra()
        {
            return obraSocial;
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
    }
}
