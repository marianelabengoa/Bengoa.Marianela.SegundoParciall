namespace WinFormLogin
{
    partial class fromModoPago
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
            btnIngresoModoPago = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModoPago = new TextBox();
            SuspendLayout();
            // 
            // btnIngresoModoPago
            // 
            btnIngresoModoPago.Location = new Point(335, 565);
            btnIngresoModoPago.Name = "btnIngresoModoPago";
            btnIngresoModoPago.Size = new Size(225, 69);
            btnIngresoModoPago.TabIndex = 0;
            btnIngresoModoPago.Text = "Aceptar";
            btnIngresoModoPago.UseVisualStyleBackColor = true;
            btnIngresoModoPago.Click += btnIngresoModoPago_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(847, 48);
            label1.TabIndex = 1;
            label1.Text = "El paciente va a pagar con debito,credito, oefectivo?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 184);
            label2.Name = "label2";
            label2.Size = new Size(163, 48);
            label2.TabIndex = 2;
            label2.Text = "F: Efetivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 262);
            label3.Name = "label3";
            label3.Size = new Size(172, 48);
            label3.TabIndex = 3;
            label3.Text = "C: credito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 347);
            label4.Name = "label4";
            label4.Size = new Size(166, 48);
            label4.TabIndex = 4;
            label4.Text = "D: debito";
            // 
            // txtModoPago
            // 
            txtModoPago.Location = new Point(361, 438);
            txtModoPago.Name = "txtModoPago";
            txtModoPago.Size = new Size(165, 55);
            txtModoPago.TabIndex = 5;
            // 
            // fromModoPago
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 681);
            Controls.Add(txtModoPago);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresoModoPago);
            Name = "fromModoPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresoModoPago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModoPago;
    }
}