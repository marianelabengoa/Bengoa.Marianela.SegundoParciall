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
    public partial class menu : Form
    {
        private string[] imagenes = { @"..\..\..\imagen11.jpg", @"..\..\..\imagen22.jpg", @"..\..\..\imagen33.jpg" };
        private int indiceActual = 0;
        private Task carruselTask;

        private Main mainForm;
        List<Visita> listaV;
        public menu()
        {
            InitializeComponent();
            mainForm = new Main();
        }

        private void btnAgregarPac_Click(object sender, EventArgs e)
        {
            AgregarPac();
        }

        private void btnAgregarVis_Click(object sender, EventArgs e)
        {
            if (Main.lista.Verificar() == true)
            {
                FormVisita visita = new FormVisita();
                listaV = visita.Lista();
                DialogResult vis = visita.ShowDialog();
            }
        }

        private void AgregarPac()
        {
            bool pacconf = true;

            while (pacconf)
            {
                DialogResult ma = mainForm.ShowDialog();

                if (ma == DialogResult.OK)
                {
                    DialogResult paccon = MessageBox.Show("¿Desea ingresar otro paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (paccon == DialogResult.Yes)
                    {
                        pacconf = true;
                    }
                    else
                    {
                        pacconf = false;
                    }
                }
                else
                {
                    pacconf = false;
                }
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
            else
            {
                carruselTask?.Wait(); // Espera a que la tarea termine antes de cerrar
                carruselTask?.Dispose();
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Detiene la tarea cuando se cierra el formulario
                carruselTask?.Dispose();
                Application.Exit();
            }
        }

        private void btnVisualizarLog_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Usuarios.log"))

            {
                string logContent = sr.ReadToEnd();
                FrmVisualizadorLog visualizador = new FrmVisualizadorLog();
                visualizador.MostrarLog(logContent);
                visualizador.ShowDialog();
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormOrdenarPac formOrdenarPac = new FormOrdenarPac(Main.lista);
            formOrdenarPac.Show();
        }

        private void btnModVis_Click(object sender, EventArgs e)
        {
            FormModificarVisita formModificarVisita = new FormModificarVisita(listaV);
            formModificarVisita.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            MostrarImagenActual();

            // Inicia la tarea del carrusel en segundo plano
            IniciarCarrusel();
        }
        private void MostrarImagenActual()
        {
            // Verifica si el índice está dentro del rango
            if (indiceActual >= 0 && indiceActual < imagenes.Length)
            {
                pictureBox1.ImageLocation = imagenes[indiceActual];
            }
        }
        private void SiguienteImagen()
        {
            // Incrementa el índice
            indiceActual++;

            // Si alcanza el final, vuelve al principio
            if (indiceActual >= imagenes.Length)
            {
                indiceActual = 0;
            }

            // Muestra la imagen actual
            MostrarImagenActual();
        }
        private void IniciarCarrusel()
        {
            carruselTask = Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(2000); // Espera 2 segundos (ajusta según sea necesario)

                    // Actualiza la UI desde el hilo principal
                    Invoke((Action)SiguienteImagen);
                }
            });
        }
            
    }
}
