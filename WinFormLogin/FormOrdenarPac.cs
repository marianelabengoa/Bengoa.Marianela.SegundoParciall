/*using Entidades;
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
            //this.lista = pacientes;
            lstPacOrd.DataSource = pacientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstPacOrd.DataSource = lista.OrdenarPorEdadAscendente;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstPacOrd.DataSource=lista.OrdenarPorEdadDescendente;
        }
    }
}
*/

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormLogin
{
    public partial class FormOrdenarPac : Form
    {
        private List<Paciente> lista;

        public FormOrdenarPac(ListaPacientes pacientes)
        {
            InitializeComponent();

            // Convierte la ListaPacientes a una lista de Paciente
            //this.lista = pacientes;

            // Asigna la lista al DataSource del ListBox
            lstPacOrd.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ordena la lista por edad ascendente
            lista = lista.OrderBy(p => p.Edad).ToList();

            // Actualiza el DataSource del ListBox
            lstPacOrd.DataSource = null;
            lstPacOrd.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ordena la lista por edad descendente
            lista = lista.OrderByDescending(p => p.Edad).ToList();

            // Actualiza el DataSource del ListBox
            lstPacOrd.DataSource = null;
            lstPacOrd.DataSource = lista;
        }
    }
}
