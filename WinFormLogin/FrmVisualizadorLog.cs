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
    public partial class FrmVisualizadorLog : Form
    {
        public FrmVisualizadorLog()
        {
            InitializeComponent();
        }
        public void MostrarLog(string logContent)
        {
            richTextBox1.Clear();
            string[] lineas = logContent.Split('\n');

            // Agrega cada línea al control TextBox
            foreach (string linea in lineas)
            {
                richTextBox1.AppendText(linea + Environment.NewLine);
            }
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

        private void FrmVisualizadorLog_Load(object sender, EventArgs e)
        {

        }
    }
}
