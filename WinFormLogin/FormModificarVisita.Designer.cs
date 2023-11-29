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
            btnAceptar.Location = new Point(57, 904);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(225, 69);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(698, 904);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(225, 69);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1033, 904);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 69);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstPac
            // 
            lstPac.FormattingEnabled = true;
            lstPac.ItemHeight = 48;
            lstPac.Location = new Point(12, 12);
            lstPac.Name = "lstPac";
            lstPac.Size = new Size(1248, 820);
            lstPac.TabIndex = 3;
            // 
            // btnAceptarCambio
            // 
            btnAceptarCambio.Location = new Point(1535, 904);
            btnAceptarCambio.Name = "btnAceptarCambio";
            btnAceptarCambio.Size = new Size(503, 69);
            btnAceptarCambio.TabIndex = 4;
            btnAceptarCambio.Text = "Aceptar modificaciones";
            btnAceptarCambio.UseVisualStyleBackColor = true;
            btnAceptarCambio.Click += btnAceptarCambio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1431, 216);
            label1.Name = "label1";
            label1.Size = new Size(152, 48);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1679, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(436, 55);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1431, 329);
            label2.Name = "label2";
            label2.Size = new Size(152, 48);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1472, 433);
            label3.Name = "label3";
            label3.Size = new Size(98, 48);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1488, 541);
            label4.Name = "label4";
            label4.Size = new Size(82, 48);
            label4.TabIndex = 9;
            label4.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1322, 646);
            label6.Name = "label6";
            label6.Size = new Size(326, 48);
            label6.TabIndex = 11;
            label6.Text = "Numero habitacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1402, 762);
            label7.Name = "label7";
            label7.Size = new Size(193, 48);
            label7.TabIndex = 12;
            label7.Text = "Parentesco";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1679, 307);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(436, 55);
            txtApellido.TabIndex = 14;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(1679, 426);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(436, 55);
            txtEdad.TabIndex = 15;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(1679, 541);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(436, 55);
            txtDNI.TabIndex = 16;
            // 
            // txtNumHab
            // 
            txtNumHab.Location = new Point(1679, 639);
            txtNumHab.Name = "txtNumHab";
            txtNumHab.Size = new Size(436, 55);
            txtNumHab.TabIndex = 19;
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(1679, 762);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.Size = new Size(436, 55);
            txtParentesco.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1612, 53);
            label9.Name = "label9";
            label9.Size = new Size(304, 67);
            label9.TabIndex = 21;
            label9.Text = "Informacion";
            // 
            // FormModificarVisita
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2250, 1004);
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
            Name = "FormModificarVisita";
            Text = "FormModificarVisita";
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