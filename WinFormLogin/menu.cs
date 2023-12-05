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
        private bool parpadeoActivo = false;
        private CancellationTokenSource cancellationTokenSource;
        private Main mainForm;
        GenericsListaEspera<Visita> listaV;
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
            Main main = new Main();
            if (Main.lista.Verificar() == true)
            {
                FormVisita visita = new FormVisita();
                listaV = visita.Lista();
                bool pacconf = true;

                while (pacconf)
                {
                    DialogResult vis = visita.ShowDialog();

                    if (vis == DialogResult.OK)
                    {
                        DialogResult paccon = MessageBox.Show("¿Desea ingresar otra visita?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            /*using (StreamReader sr = new StreamReader(@"..\..\..\Usuarios.log"))

            {
                string logContent = sr.ReadToEnd();
                FrmVisualizadorLog visualizador = new FrmVisualizadorLog();
                visualizador.MostrarLog(logContent);
                visualizador.ShowDialog();
            }*/
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Guardar archivo de registro";
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string logFilePath = @"..\..\..\Usuarios.log";
                    File.Copy(logFilePath, saveFileDialog.FileName, true);
                    MessageBox.Show($"Archivo guardado en: {saveFileDialog.FileName}");
                }
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Main main = new Main();
            //FormOrdenarPac formOrdenarPac = new FormOrdenarPac(Main.lista);
            AccesoDatos ado = new AccesoDatos();
            FormOrdenarPac formOrdenarPac = new FormOrdenarPac(ado.ObtenerListaPacientes());

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
            this.Activated += new EventHandler(menu_Activated);
            this.Deactivate += new EventHandler(menu_Deactivate);
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

                if (lblBienvenido.Visible == false)
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
        private void menu_Activated(object sender, EventArgs e)
        {
            // La aplicación ha vuelto a estar activa, reinicia el parpadeo
            IniciarParpadeo();
        }

        private void menu_Deactivate(object sender, EventArgs e)
        {
            // La aplicación se ha desactivado, detén el parpadeo
            DetenerParpadeo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Usuarios.log"))

            {
                string logContent = sr.ReadToEnd();
                FrmVisualizadorLog visualizador = new FrmVisualizadorLog();
                visualizador.MostrarLog(logContent);
                visualizador.ShowDialog();
            }
        }
    }
}
