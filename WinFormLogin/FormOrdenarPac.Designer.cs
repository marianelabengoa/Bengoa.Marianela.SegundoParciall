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
            btnAceptar.Location = new Point(49, 637);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(225, 69);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnAsc
            // 
            btnAsc.Location = new Point(656, 637);
            btnAsc.Name = "btnAsc";
            btnAsc.Size = new Size(396, 69);
            btnAsc.TabIndex = 1;
            btnAsc.Text = "Ordenar ascendente";
            btnAsc.UseVisualStyleBackColor = true;
            btnAsc.Click += button2_Click;
            // 
            // btnDes
            // 
            btnDes.Location = new Point(1122, 637);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(389, 69);
            btnDes.TabIndex = 2;
            btnDes.Text = "Odenar descendente";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += button3_Click;
            // 
            // lstPacOrd
            // 
            lstPacOrd.FormattingEnabled = true;
            lstPacOrd.ItemHeight = 48;
            lstPacOrd.Location = new Point(12, 12);
            lstPacOrd.Name = "lstPacOrd";
            lstPacOrd.Size = new Size(1536, 532);
            lstPacOrd.TabIndex = 3;
            // 
            // FormOrdenarPac
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1562, 772);
            Controls.Add(lstPacOrd);
            Controls.Add(btnDes);
            Controls.Add(btnAsc);
            Controls.Add(btnAceptar);
            Name = "FormOrdenarPac";
            Text = "FormOrdenarPac";
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