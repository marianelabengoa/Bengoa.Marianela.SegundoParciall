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
    public partial class FormOrdenarPac : Form
    {
        private ListaPacientes lista;
        public FormOrdenarPac(ListaPacientes pacientes)
        {
            InitializeComponent();
            this.lista = pacientes;
            //lstPacOrd.DataSource = pacientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Paciente> l = lista.OrdenarPorEdadAscendente().ToList();
            Actualizar2(l);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ListaPacientes pacientes = lista.OrdenarPorEdadDescendente();
            //lista = pacientes;
            //this.lista = lista.OrdenarPorEdadAscendente();
            //lista.OrdenarPorEdadDescendente();
            List<Paciente> l =lista.OrdenarPorEdadDescendente().ToList();
            Actualizar2(l);
        }
        private void Actualizar()
        {
            this.lstPacOrd.Items.Clear();
            foreach (Paciente paciente in lista.Obtener())
            {
                lstPacOrd.Items.Add(paciente.Mostrar());
            }
        }
        private void Actualizar2(List<Paciente> lista)
        {
            this.lstPacOrd.Items.Clear();
            foreach (Paciente paciente in lista)
            {
                lstPacOrd.Items.Add(paciente.Mostrar());
            }
        }


        private void lstPacOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormOrdenarPac_Load(object sender, EventArgs e)
        {
            Actualizar();

        }
        public void Actualizar3()
        {

        }
    }
}

