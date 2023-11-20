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
    public partial class FormNomPac : Form
    {
        public FormNomPac()
        {
            InitializeComponent();
            
        }

        private void txtVisitaPacNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarnom_Click(object sender, EventArgs e)
        {
            string nombre = txtVisitaPacNombre.Text;
            string apellido = txtVisitaPacApellido.Text;
            Main main = new Main();

            foreach (Paciente p in Main.lista)
            {
                if (p.Nombre == nombre & p.Apellido == apellido)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("este paciente no se encuentra en el hospital");
                }
            }
        }
    }
}
