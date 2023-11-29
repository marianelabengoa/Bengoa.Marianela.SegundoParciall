﻿using Entidades;
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
        private bool parpadeoActivo = false;
        private CancellationTokenSource cancellationTokenSource;
        private Main mainForm;
        List<Visita> listaV;
        private delegate void ActualizarLabelDelegate();
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
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                carruselTask?.Wait(); 
                carruselTask?.Dispose();
            }
            DetenerParpadeo();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Detiene la tarea cuando se cierra el formulario
                carruselTask?.Dispose();
                DetenerParpadeo();
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
            IniciarCarrusel();
            IniciarParpadeo();
        }
        private void MostrarImagenActual()
        {
            if (indiceActual >= 0 && indiceActual < imagenes.Length)
            {
                pictureBox1.ImageLocation = imagenes[indiceActual];
            }
        }
        private void SiguienteImagen()
        {
            indiceActual++;

            if (indiceActual >= imagenes.Length)
            {
                indiceActual = 0;
            }

            MostrarImagenActual();
        }
        private void IniciarCarrusel()
        {
            carruselTask = Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(2000); // Espera 2 segundos (ajusta según sea necesario)

                    Invoke((Action)SiguienteImagen);
                }
            });
        }
        private void Parpadear()
        {
            while (parpadeoActivo)
            {
                ActualizarLabel();

                if (lblBienvenido.Visible==false)
                {
                    Task.Delay(200).Wait();
                }
                else
                {
                    Task.Delay(300).Wait();
                }
            }
        }
        private void ActualizarLabel()
        {
            if (lblBienvenido.InvokeRequired)
            {
                lblBienvenido.BeginInvoke(new ActualizarLabelDelegate(ActualizarLabel));
            }
            else
            {
                lblBienvenido.Visible = !lblBienvenido.Visible;
            }
        }
        
        private async void IniciarParpadeo()
        {
            cancellationTokenSource = new CancellationTokenSource();

            try
            {
                parpadeoActivo = true;

                await Task.Run(() => Parpadear(), cancellationTokenSource.Token);
            }
            catch (TaskCanceledException)
            {
            }
        }
        private void DetenerParpadeo()
        {
            parpadeoActivo = false;
            cancellationTokenSource.Cancel();
        }
    }
}




/*
 using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParpadeoLabel
{
    public partial class Form1 : Form
    {
        private bool parpadeoActivo = false;
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Iniciar el parpadeo cuando se carga el formulario
            IniciarParpadeo();
        }

        private async void IniciarParpadeo()
        {
            cancellationTokenSource = new CancellationTokenSource();

            try
            {
                parpadeoActivo = true;

                // Inicia un bucle en un hilo separado usando Task.Run
                await Task.Run(async () =>
                {
                    while (parpadeoActivo)
                    {
                        // Alternar la visibilidad del Label
                        label1.Visible = !label1.Visible;

                        // Esperar un tiempo antes de alternar de nuevo
                        await Task.Delay(500); // Puedes ajustar el tiempo de espera según tus preferencias
                    }
                }, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException)
            {
                // No hacer nada si la tarea se cancela
            }
        }

        private void DetenerParpadeo()
        {
            // Detener el parpadeo estableciendo la bandera a false y cancelando la tarea
            parpadeoActivo = false;
            cancellationTokenSource.Cancel();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asegurarse de detener el parpadeo antes de cerrar el formulario
            DetenerParpadeo();
        }
    }
}

 */