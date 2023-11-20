namespace WinFormLogin
{
    partial class formNumHabitacion
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
            label1 = new Label();
            txtNumHabitacion = new TextBox();
            btnAceptarNumHabitacion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(738, 48);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el numero de habitacion del paciente";
            // 
            // txtNumHabitacion
            // 
            txtNumHabitacion.Location = new Point(291, 136);
            txtNumHabitacion.Name = "txtNumHabitacion";
            txtNumHabitacion.Size = new Size(218, 55);
            txtNumHabitacion.TabIndex = 1;
            // 
            // btnAceptarNumHabitacion
            // 
            btnAceptarNumHabitacion.Location = new Point(257, 276);
            btnAceptarNumHabitacion.Name = "btnAceptarNumHabitacion";
            btnAceptarNumHabitacion.Size = new Size(287, 111);
            btnAceptarNumHabitacion.TabIndex = 2;
            btnAceptarNumHabitacion.Text = "Aceptar";
            btnAceptarNumHabitacion.UseVisualStyleBackColor = true;
            btnAceptarNumHabitacion.Click += btnAceptarNumHabitacion_Click;
            // 
            // formNumHabitacion
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 486);
            Controls.Add(btnAceptarNumHabitacion);
            Controls.Add(txtNumHabitacion);
            Controls.Add(label1);
            Name = "formNumHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formNumHabitacion";
            Load += formNumHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumHabitacion;
        private Button btnAceptarNumHabitacion;
    }
}