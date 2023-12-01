namespace WinFormLogin
{
    partial class FormObraSocial
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
            txtObraSocial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAceptarObra = new Button();
            SuspendLayout();
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(245, 337);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(300, 55);
            txtObraSocial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 35);
            label1.Name = "label1";
            label1.Size = new Size(559, 48);
            label1.TabIndex = 1;
            label1.Text = "ingrese la obra social del paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 143);
            label2.Name = "label2";
            label2.Size = new Size(433, 144);
            label2.TabIndex = 2;
            label2.Text = "IOMA - OSECAC - OSDE -\r\nGaleno - Omint - noPosee\r\n\r\n";
            // 
            // btnAceptarObra
            // 
            btnAceptarObra.Cursor = Cursors.Hand;
            btnAceptarObra.Location = new Point(279, 477);
            btnAceptarObra.Name = "btnAceptarObra";
            btnAceptarObra.Size = new Size(225, 69);
            btnAceptarObra.TabIndex = 3;
            btnAceptarObra.Text = "Aceptar";
            btnAceptarObra.UseVisualStyleBackColor = true;
            btnAceptarObra.Click += btnAceptarObra_Click;
            // 
            // FormObraSocial
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 621);
            Controls.Add(btnAceptarObra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObraSocial);
            Name = "FormObraSocial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Obra Social";
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void BtnAceptarObra_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private TextBox txtObraSocial;
        private Label label1;
        private Label label2;
        private Button btnAceptarObra;
    }
}