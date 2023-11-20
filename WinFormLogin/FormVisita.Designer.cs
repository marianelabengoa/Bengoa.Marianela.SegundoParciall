namespace WinFormLogin
{
    partial class FormVisita
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
            btnAceptarVisita = new Button();
            txtNombreVisita = new TextBox();
            txtApellidoVisita = new TextBox();
            txtEdadVisita = new TextBox();
            txtDniVisita = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtVisitaPacNombre = new TextBox();
            txtVisitaPacApellido = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAceptarVisita
            // 
            btnAceptarVisita.Location = new Point(298, 1223);
            btnAceptarVisita.Name = "btnAceptarVisita";
            btnAceptarVisita.Size = new Size(225, 69);
            btnAceptarVisita.TabIndex = 0;
            btnAceptarVisita.Text = "Aceptar";
            btnAceptarVisita.UseVisualStyleBackColor = true;
            btnAceptarVisita.Click += btnAceptarVisita_Click;
            // 
            // txtNombreVisita
            // 
            txtNombreVisita.Location = new Point(422, 207);
            txtNombreVisita.Name = "txtNombreVisita";
            txtNombreVisita.Size = new Size(300, 55);
            txtNombreVisita.TabIndex = 1;
            // 
            // txtApellidoVisita
            // 
            txtApellidoVisita.Location = new Point(422, 379);
            txtApellidoVisita.Name = "txtApellidoVisita";
            txtApellidoVisita.Size = new Size(300, 55);
            txtApellidoVisita.TabIndex = 2;
            // 
            // txtEdadVisita
            // 
            txtEdadVisita.Location = new Point(422, 563);
            txtEdadVisita.Name = "txtEdadVisita";
            txtEdadVisita.Size = new Size(300, 55);
            txtEdadVisita.TabIndex = 3;
            // 
            // txtDniVisita
            // 
            txtDniVisita.Location = new Point(422, 732);
            txtDniVisita.Name = "txtDniVisita";
            txtDniVisita.Size = new Size(300, 55);
            txtDniVisita.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 42);
            label1.Name = "label1";
            label1.Size = new Size(550, 48);
            label1.TabIndex = 5;
            label1.Text = "ingrese la informacion de la visita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 210);
            label2.Name = "label2";
            label2.Size = new Size(152, 48);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 382);
            label3.Name = "label3";
            label3.Size = new Size(152, 48);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 563);
            label4.Name = "label4";
            label4.Size = new Size(98, 48);
            label4.TabIndex = 8;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 732);
            label5.Name = "label5";
            label5.Size = new Size(82, 48);
            label5.TabIndex = 9;
            label5.Text = "DNI";
            // 
            // txtVisitaPacNombre
            // 
            txtVisitaPacNombre.Location = new Point(422, 879);
            txtVisitaPacNombre.Name = "txtVisitaPacNombre";
            txtVisitaPacNombre.Size = new Size(300, 55);
            txtVisitaPacNombre.TabIndex = 10;
            // 
            // txtVisitaPacApellido
            // 
            txtVisitaPacApellido.Location = new Point(422, 1023);
            txtVisitaPacApellido.Name = "txtVisitaPacApellido";
            txtVisitaPacApellido.Size = new Size(300, 55);
            txtVisitaPacApellido.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 886);
            label6.Name = "label6";
            label6.Size = new Size(356, 48);
            label6.TabIndex = 12;
            label6.Text = "Nombre del paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 1026);
            label7.Name = "label7";
            label7.Size = new Size(356, 48);
            label7.TabIndex = 13;
            label7.Text = "Apellido del paciente";
            // 
            // FormVisita
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(876, 1361);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtVisitaPacApellido);
            Controls.Add(txtVisitaPacNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDniVisita);
            Controls.Add(txtEdadVisita);
            Controls.Add(txtApellidoVisita);
            Controls.Add(txtNombreVisita);
            Controls.Add(btnAceptarVisita);
            Name = "FormVisita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVisita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptarVisita;
        private TextBox txtNombreVisita;
        private TextBox txtApellidoVisita;
        private TextBox txtEdadVisita;
        private TextBox txtDniVisita;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVisitaPacNombre;
        private TextBox txtVisitaPacApellido;
        private Label label6;
        private Label label7;
    }
}