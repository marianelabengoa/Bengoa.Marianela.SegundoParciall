namespace WinFormLogin
{
    partial class FormOrdenarPac
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
            btnAsc = new Button();
            btnDes = new Button();
            lstPacOrd = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(17, 199);
            btnAceptar.Margin = new Padding(1, 1, 1, 1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 22);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnAsc
            // 
            btnAsc.Cursor = Cursors.Hand;
            btnAsc.Location = new Point(230, 199);
            btnAsc.Margin = new Padding(1, 1, 1, 1);
            btnAsc.Name = "btnAsc";
            btnAsc.Size = new Size(139, 22);
            btnAsc.TabIndex = 1;
            btnAsc.Text = "Ordenar ascendente";
            btnAsc.UseVisualStyleBackColor = true;
            btnAsc.Click += button2_Click;
            // 
            // btnDes
            // 
            btnDes.Cursor = Cursors.Hand;
            btnDes.Location = new Point(393, 199);
            btnDes.Margin = new Padding(1, 1, 1, 1);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(136, 22);
            btnDes.TabIndex = 2;
            btnDes.Text = "Odenar descendente";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += button3_Click;
            // 
            // lstPacOrd
            // 
            lstPacOrd.FormattingEnabled = true;
            lstPacOrd.ItemHeight = 15;
            lstPacOrd.Location = new Point(4, 4);
            lstPacOrd.Margin = new Padding(1, 1, 1, 1);
            lstPacOrd.Name = "lstPacOrd";
            lstPacOrd.Size = new Size(540, 169);
            lstPacOrd.TabIndex = 3;
            // 
            // FormOrdenarPac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(571, 234);
            Controls.Add(lstPacOrd);
            Controls.Add(btnDes);
            Controls.Add(btnAsc);
            Controls.Add(btnAceptar);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormOrdenarPac";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordenar pacientes por edad";
            Load += FormOrdenarPac_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnAsc;
        private Button btnDes;
        private ListBox lstPacOrd;
    }
}