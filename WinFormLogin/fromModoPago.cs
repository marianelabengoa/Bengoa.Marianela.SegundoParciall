using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinFormLogin
{
    public partial class fromModoPago : Form
    {

        public float monto;
        public fromModoPago()
        {
            InitializeComponent();
        }

        public fromModoPago(float monto)
        {
            InitializeComponent();
            this.monto = monto;
        }

        private void btnIngresoModoPago_Click(object sender, EventArgs e)
        {
            string mp = txtModoPago.Text;


            if (mp == "d" || mp == "D")
            {
                monto += monto * 2 / 100;
                this.DialogResult = DialogResult.OK;
            }
            else if (mp == "c" || mp == "C")
            {
                monto += monto * 15 / 100;
                this.DialogResult = DialogResult.OK;
            }
            else if (mp == "f" || mp == "F")
            {
                monto = monto;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ingrese una opcion valida");
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();

        }

        public float ObtenerMonto()
        {
            return monto;
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

