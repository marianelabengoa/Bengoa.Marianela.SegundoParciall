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
    public partial class FormEvaluacion : Form, IEvaluacion
    {
        private int totalEvaluaciones = 0;
        private int sumaSatisfaccion = 0;
        public FormEvaluacion()
        {
            InitializeComponent();
        }


        private void FormEvaluacion_Load(object sender, EventArgs e)
        {
        }

        public void MostrarResultado(int nivel)
        {
            totalEvaluaciones++;
            sumaSatisfaccion += nivel;

            float promedio = (float)sumaSatisfaccion / totalEvaluaciones;

            // Mostrar el resultado en un cuadro de mensaje
            MessageBox.Show($"Gracias por tu evaluación. Nivel de satisfacción: {nivel}\nPromedio actual: {promedio:F2}", "Resultado de la evaluación");

            // Escribir el promedio en un archivo de texto
            EscribirPromedioEnArchivo(promedio);
        }

        public void EscribirPromedioEnArchivo(float promedio)
        {
            string path = @"..\..\..\Promedio_evaluacion.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine($"Promedio de satisfacción: {promedio:F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo: {ex.Message}", "Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.MostrarResultado(1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.MostrarResultado(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.MostrarResultado(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.MostrarResultado(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.MostrarResultado(5);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
