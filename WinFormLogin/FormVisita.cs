﻿using Entidades;
using System;
using System.Collections;
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
    public partial class FormVisita : Main
    {
        public List<Visita> listaVisitas;

        //public static List<Visita> Lista { get; internal set; }

        // public List<Visita> listaVisitas { get; set; }

        public FormVisita()
        {
            InitializeComponent();
            listaVisitas = new List<Visita>();
            this.txtNumHabitacion.Hide();
            label6.Visible = false;
        }


        protected override void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarNoVacio(txtNombre.Text, "Nombre") && ValidarNoVacio(txtApellido.Text, "Apellido") && ValidarNumerico(txtDni.Text, "DNI") && ValidarNumerico(txtEdad.Text, "Edad"))
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                Visita visita = null;

                int n = 1;

                FormNomPac fnp = new FormNomPac();
                DialogResult r = fnp.ShowDialog();


                if (r == DialogResult.OK)
                {
                    DialogResult confirm = MessageBox.Show("¿conoce el numero de habitacion del paciente que visita?", "confirm", MessageBoxButtons.YesNo);


                    if (confirm == DialogResult.Yes)
                    {
                        this.Hide();
                        formNumHabitacion frmNumHab = new formNumHabitacion();
                        DialogResult resultt = frmNumHab.ShowDialog();

                        if (resultt == DialogResult.OK)
                        {
                            int numHabitacion = frmNumHab.ObtenerNumhab();
                            frmNumHab.Close();

                            DialogResult conf = MessageBox.Show("¿Desea ingresar que parenteco tiene con el paciente?", "confirm", MessageBoxButtons.YesNo);


                            if (conf == DialogResult.Yes)
                            {
                                this.Hide();
                                FormParentesco frmParentesco = new FormParentesco();
                                DialogResult resulta = frmParentesco.ShowDialog();

                                if (resulta == DialogResult.OK)
                                {
                                    string parentesco = frmParentesco.ObtenerParentesco();
                                    frmParentesco.Close();
                                    visita = new Visita(nombre, apellido, edad, dni, $"{fnp.nombre} {fnp.apellido}", numHabitacion, parentesco);
                                }
                            }
                            else
                            {
                                visita = new Visita(nombre, apellido, edad, dni, $"{fnp.nombre} {fnp.apellido}", numHabitacion);
                            }
                        }
                    }
                    else
                    {
                        visita = new Visita(nombre, apellido, edad, dni, $"{fnp.nombre} {fnp.apellido}");

                    }

                    float monto = visita.Pagar(visita);

                    if (visita != null)
                    {
                        MessageBox.Show($"La visita debe pagar ${monto}");
                    }

                    MessageBox.Show(visita.Mostrar());
                    string accion = visita.RealizarAccion();
                    MessageBox.Show(accion);


                listaVisitas.Add(visita);
                this.DialogResult = DialogResult.OK;
                this.Close();
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

        private void FormVisita_Load(object sender, EventArgs e)
        {

        }

        private void btnVerVis_Click(object sender, EventArgs e)
        {
            FormModificarVisita formModificarVisita = new FormModificarVisita(listaVisitas);
            formModificarVisita.Show();
        }
        public List<Visita> Lista()
        {
            return listaVisitas;
        }
    }
}
