namespace WinFormLogin
{
    partial class FormDoctores
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
            btnAceptarDoctores = new Button();
            lstDoctores = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAceptarDoctores
            // 
            btnAceptarDoctores.Cursor = Cursors.Hand;
            btnAceptarDoctores.Location = new Point(457, 667);
            btnAceptarDoctores.Name = "btnAceptarDoctores";
            btnAceptarDoctores.Size = new Size(225, 69);
            btnAceptarDoctores.TabIndex = 0;
            btnAceptarDoctores.Text = "Aceptar";
            btnAceptarDoctores.UseVisualStyleBackColor = true;
            btnAceptarDoctores.Click += btnAceptarDoctores_Click;
            // 
            // lstDoctores
            // 
            lstDoctores.FormattingEnabled = true;
            lstDoctores.ItemHeight = 48;
            lstDoctores.Location = new Point(12, 183);
            lstDoctores.Name = "lstDoctores";
            lstDoctores.Size = new Size(1201, 436);
            lstDoctores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 33);
            label1.Name = "label1";
            label1.Size = new Size(1021, 48);
            label1.TabIndex = 2;
            label1.Text = "Estos son los doctores que se encuentran en el establemiciento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 116);
            label2.Name = "label2";
            label2.Size = new Size(667, 48);
            label2.TabIndex = 3;
            label2.Text = "Seleccione cual debe atender al paciente";
            // 
            // FormDoctores
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1225, 786);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstDoctores);
            Controls.Add(btnAceptarDoctores);
            Name = "FormDoctores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctores";
            Load += FormDoctores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptarDoctores;
        private ListBox lstDoctores;
        private Label label1;
        private Label label2;
    }
}