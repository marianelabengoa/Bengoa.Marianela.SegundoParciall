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
    /*public partial class FormFechaNacimiento : Form
    {
        private int dia;
        private int mes;
        private int año;
        public FormFechaNacimiento()
        {
            InitializeComponent();
        }

        private void btnAceptarFecha_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDia.Text, out dia) &&
                int.TryParse(txtMes.Text, out mes) &&
                int.TryParse(txtAño.Text, out año))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Fecha de nacimiento no válida. Intente nuevamente.");
            }

        }
        public DateTime ObtenerFecha()
        {
            return new DateTime(año, mes, dia);
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

    }*/
    public partial class FormFechaNacimiento : Form
    {
        private int dia;
        private int mes;
        private int año;

        public FormFechaNacimiento()
        {
            InitializeComponent();
        }

        private void btnAceptarFecha_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDia.Text, out dia) &&
                int.TryParse(txtMes.Text, out mes) &&
                int.TryParse(txtAño.Text, out año) &&
                ValidarFecha())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Fecha de nacimiento no válida. Intente nuevamente.");
            }
        }

        private bool ValidarFecha()
        {
            // Check if the day, month, and year values are within valid ranges
            if (mes < 1 || mes > 12 || año < 1900 || año > DateTime.Now.Year)
            {
                MessageBox.Show("Fecha de nacimiento no válida. Verifique los valores ingresados.");
                return false;
            }

            int[] diasPorMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Check for leap year and update February days
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                diasPorMes[2] = 29;
            }

            if (dia < 1 || dia > diasPorMes[mes])
            {
                MessageBox.Show("Fecha de nacimiento no válida. Verifique los valores ingresados.");
                return false;
            }

            return true;
        }

        public DateTime ObtenerFecha()
        {
            return new DateTime(año, mes, dia);
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
