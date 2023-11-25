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
                listaV=visita.Lista();
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
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación al usuario
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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
    }
}
