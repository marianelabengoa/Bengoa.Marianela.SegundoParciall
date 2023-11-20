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

    public partial class FormDoctores : Form
    {
        private List<Doctor> doctores;
        Doctor doctor = null;
        public FormDoctores()
        {
            InitializeComponent();
            this.doctores = new List<Doctor>();
            Agregar(doctores);

        }


        private void btnAceptarDoctores_Click(object sender, EventArgs e)
        {

            ObtenerDoctor();

        }

        private List<Doctor> Agregar(List<Doctor> lista)
        {
            Doctor doctor = new Doctor("Martin", "Hernandez", 45, 20123666, "Dermatologia");
            Doctor doctor2 = new Doctor("Raul", "Juarez", 23, 42335886, "Nutricionista", 2100, Euniversidad.UAI);
            Doctor doctor3 = new Doctor("Rodrigo", "Perez", 33, 42335886, "Clinico", 3000);
            Doctor doctor4 = new Doctor("Luis", "Carrizo", 41, 42326886, "Psiquiatra", 2000, Euniversidad.UCA);
            Doctor doctor5 = new Doctor("Juan", "Diaz", 41, 42326886, "Oftalmólogo", 2000, Euniversidad.UCA);
            Doctor doctor6 = new Doctor("Silvio", "Rojas", 41, 42326886, "Gastroenterólogo", 2000, Euniversidad.UCA);
            Doctor doctor7 = new Doctor("Oscar", "Lizarraga ", 41, 42326886, "Neurólogo", 2000, Euniversidad.UCA);

            lista.Add(doctor);
            lista.Add(doctor2);
            lista.Add(doctor3);
            lista.Add(doctor4);
            lista.Add(doctor5);
            lista.Add(doctor6);
            lista.Add(doctor7);

            return lista;
        }

        public Doctor ObtenerDoctor()
        {
            int indice = this.lstDoctores.SelectedIndex;

            if (indice == -1)
            {
                return null;
            }

            Doctor doctor = this.doctores[indice];
            this.DialogResult = DialogResult.OK;
            this.Close();
            return doctor;
        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            foreach (Doctor doctor in doctores)
            {
                this.lstDoctores.Items.Add(doctor.ToString());
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
    }
}
