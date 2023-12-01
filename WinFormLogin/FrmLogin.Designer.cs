namespace WinFormLogin
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtClave = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(317, 474);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(225, 69);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 85);
            label1.Name = "label1";
            label1.Size = new Size(141, 48);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 272);
            label2.Name = "label2";
            label2.Size = new Size(105, 48);
            label2.TabIndex = 2;
            label2.Text = "Clave";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(286, 174);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 55);
            txtUser.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(286, 349);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(300, 55);
            txtClave.TabIndex = 4;
            txtClave.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 577);
            Controls.Add(txtClave);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtClave;
    }
}