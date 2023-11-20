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
    public partial class formNumHabitacion : Form
    {
        private int numHabitacion;
        public formNumHabitacion()
        {
            InitializeComponent();
        }

        private void formNumHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarNumHabitacion_Click(object sender, EventArgs e)
        {
            if (numHabitacion!= null && numHabitacion > 0)
            {
                int numHabitacion = int.Parse(txtNumHabitacion.Text);

                Main main = new Main();
                int n = 1;
                foreach (Paciente p in Main.lista)
                {
                    if (p.numeroHabitacion == numHabitacion)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("este paciente no se encuentra en el hospital");
                        n = 0;
                    }
                }

            }
        }

        public int ObtenerNumhab()
        {
            return numHabitacion;
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
