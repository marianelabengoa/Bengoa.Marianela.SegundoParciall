namespace WinFormLogin
{
    partial class FormModificarVisita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lstPac = new ListBox();
            btnAceptarCambio = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtDNI = new TextBox();
            txtNumHab = new TextBox();
            txtParentesco = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(20, 282);
            btnAceptar.Margin = new Padding(1, 1, 1, 1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 22);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(244, 282);
            btnModificar.Margin = new Padding(1, 1, 1, 1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(79, 22);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(362, 282);
            btnEliminar.Margin = new Padding(1, 1, 1, 1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 22);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstPac
            // 
            lstPac.FormattingEnabled = true;
            lstPac.ItemHeight = 15;
            lstPac.Location = new Point(4, 4);
            lstPac.Margin = new Padding(1, 1, 1, 1);
            lstPac.Name = "lstPac";
            lstPac.Size = new Size(439, 259);
            lstPac.TabIndex = 3;
            // 
            // btnAceptarCambio
            // 
            btnAceptarCambio.Cursor = Cursors.Hand;
            btnAceptarCambio.Location = new Point(537, 282);
            btnAceptarCambio.Margin = new Padding(1, 1, 1, 1);
            btnAceptarCambio.Name = "btnAceptarCambio";
            btnAceptarCambio.Size = new Size(176, 22);
            btnAceptarCambio.TabIndex = 4;
            btnAceptarCambio.Text = "Aceptar modificaciones";
            btnAceptarCambio.UseVisualStyleBackColor = true;
            btnAceptarCambio.Click += btnAceptarCambio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 68);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(588, 62);
            txtNombre.Margin = new Padding(1, 1, 1, 1);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 103);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 135);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 169);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 202);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 11;
            label6.Text = "Numero habitacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 238);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 12;
            label7.Text = "Parentesco";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(588, 96);
            txtApellido.Margin = new Padding(1, 1, 1, 1);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(588, 133);
            txtEdad.Margin = new Padding(1, 1, 1, 1);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(155, 23);
            txtEdad.TabIndex = 15;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(588, 169);
            txtDNI.Margin = new Padding(1, 1, 1, 1);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(155, 23);
            txtDNI.TabIndex = 16;
            // 
            // txtNumHab
            // 
            txtNumHab.Location = new Point(588, 200);
            txtNumHab.Margin = new Padding(1, 1, 1, 1);
            txtNumHab.Name = "txtNumHab";
            txtNumHab.Size = new Size(155, 23);
            txtNumHab.TabIndex = 19;
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(588, 238);
            txtParentesco.Margin = new Padding(1, 1, 1, 1);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.Size = new Size(155, 23);
            txtParentesco.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(564, 17);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 21;
            label9.Text = "Informacion";
            // 
            // FormModificarVisita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(756, 308);
            Controls.Add(label9);
            Controls.Add(txtParentesco);
            Controls.Add(txtNumHab);
            Controls.Add(txtDNI);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnAceptarCambio);
            Controls.Add(lstPac);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAceptar);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormModificarVisita";
            Text = "Visitas en el establecimiento";
            Load += FormModificarVisita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lstPac;
        private Button btnAceptarCambio;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtDNI;
        private TextBox txtNumHab;
        private TextBox txtParentesco;
        private Label label9;
    }
}