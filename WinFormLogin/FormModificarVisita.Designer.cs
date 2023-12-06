namespace WinFormLogin
{
    partial class FormModificarVisita
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
            btnEliminar = new Button();
            lstPac = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(122, 282);
            btnAceptar.Margin = new Padding(1);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 22);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(245, 282);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 22);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstPac
            // 
            lstPac.FormattingEnabled = true;
            lstPac.ItemHeight = 15;
            lstPac.Location = new Point(4, 4);
            lstPac.Margin = new Padding(1);
            lstPac.Name = "lstPac";
            lstPac.Size = new Size(439, 259);
            lstPac.TabIndex = 3;
            // 
            // FormModificarVisita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(449, 308);
            Controls.Add(lstPac);
            Controls.Add(btnEliminar);
            Controls.Add(btnAceptar);
            Margin = new Padding(1);
            Name = "FormModificarVisita";
            Text = "Visitas en el establecimiento";
            Load += FormModificarVisita_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnEliminar;
        private ListBox lstPac;
    }
}