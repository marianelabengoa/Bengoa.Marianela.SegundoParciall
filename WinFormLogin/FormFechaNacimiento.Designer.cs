namespace WinFormLogin
{
    partial class FormFechaNacimiento
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
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAceptarFecha = new Button();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(71, 324);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(152, 55);
            txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(312, 324);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(145, 55);
            txtMes.TabIndex = 1;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(540, 324);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(205, 55);
            txtAño.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 76);
            label1.Name = "label1";
            label1.Size = new Size(709, 48);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la fecha de nacimiento del paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 222);
            label2.Name = "label2";
            label2.Size = new Size(72, 48);
            label2.TabIndex = 4;
            label2.Text = "Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 222);
            label3.Name = "label3";
            label3.Size = new Size(86, 48);
            label3.TabIndex = 5;
            label3.Text = "Mes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 222);
            label4.Name = "label4";
            label4.Size = new Size(84, 48);
            label4.TabIndex = 6;
            label4.Text = "Año";
            // 
            // btnAceptarFecha
            // 
            btnAceptarFecha.Cursor = Cursors.Hand;
            btnAceptarFecha.Location = new Point(265, 505);
            btnAceptarFecha.Name = "btnAceptarFecha";
            btnAceptarFecha.Size = new Size(225, 69);
            btnAceptarFecha.TabIndex = 7;
            btnAceptarFecha.Text = "Aceptar";
            btnAceptarFecha.UseVisualStyleBackColor = true;
            btnAceptarFecha.Click += btnAceptarFecha_Click;
            // 
            // FormFechaNacimiento
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(btnAceptarFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Name = "FormFechaNacimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fecha de nacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAceptarFecha;
    }
}