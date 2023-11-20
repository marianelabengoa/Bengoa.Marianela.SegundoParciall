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
    public partial class FormParentesco : Form
    {
        private string parentesco;
        public FormParentesco()
        {
            InitializeComponent();
        }

        private void btnParentesco_Click(object sender, EventArgs e)
        {
            string parentesco = txtParentesco.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }
        public string ObtenerParentesco()
        {
            return parentesco;
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
