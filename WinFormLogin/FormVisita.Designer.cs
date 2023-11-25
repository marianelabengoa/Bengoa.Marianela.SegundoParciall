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
            SuspendLayout();
            // 
            // FormVisita
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(876, 1361);
            Name = "FormVisita";
            Text = "FormVisita";
            Load += FormVisita_Load;
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
        private Button btnVerVis;
    }
}