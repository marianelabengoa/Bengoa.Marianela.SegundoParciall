namespace WinFormLogin
{
    partial class FormNomPac
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
            label6 = new Label();
            label7 = new Label();
            txtVisitaPacNombre = new TextBox();
            txtVisitaPacApellido = new TextBox();
            btnAceptarnom = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 52);
            label6.Name = "label6";
            label6.Size = new Size(356, 48);
            label6.TabIndex = 13;
            label6.Text = "Nombre del paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 256);
            label7.Name = "label7";
            label7.Size = new Size(356, 48);
            label7.TabIndex = 14;
            label7.Text = "Apellido del paciente";
            // 
            // txtVisitaPacNombre
            // 
            txtVisitaPacNombre.Location = new Point(139, 141);
            txtVisitaPacNombre.Name = "txtVisitaPacNombre";
            txtVisitaPacNombre.Size = new Size(522, 55);
            txtVisitaPacNombre.TabIndex = 15;
            txtVisitaPacNombre.TextChanged += txtVisitaPacNombre_TextChanged;
            // 
            // txtVisitaPacApellido
            // 
            txtVisitaPacApellido.Location = new Point(149, 366);
            txtVisitaPacApellido.Name = "txtVisitaPacApellido";
            txtVisitaPacApellido.Size = new Size(503, 55);
            txtVisitaPacApellido.TabIndex = 16;
            // 
            // btnAceptarnom
            // 
            btnAceptarnom.Location = new Point(288, 488);
            btnAceptarnom.Name = "btnAceptarnom";
            btnAceptarnom.Size = new Size(225, 69);
            btnAceptarnom.TabIndex = 17;
            btnAceptarnom.Text = "aceptar";
            btnAceptarnom.UseVisualStyleBackColor = true;
            btnAceptarnom.Click += btnAceptarnom_Click;
            // 
            // FormNomPac
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(btnAceptarnom);
            Controls.Add(txtVisitaPacApellido);
            Controls.Add(txtVisitaPacNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FormNomPac";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private TextBox txtVisitaPacNombre;
        private TextBox txtVisitaPacApellido;
        private Button btnAceptarnom;
    }
}