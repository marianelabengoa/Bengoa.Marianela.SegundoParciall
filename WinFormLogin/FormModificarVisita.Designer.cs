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
            btnModificar = new Button();
            btnEliminar = new Button();
            lstPac = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(57, 639);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(225, 69);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(690, 639);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(225, 69);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(992, 639);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 69);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstPac
            // 
            lstPac.FormattingEnabled = true;
            lstPac.ItemHeight = 48;
            lstPac.Location = new Point(12, 12);
            lstPac.Name = "lstPac";
            lstPac.Size = new Size(1248, 580);
            lstPac.TabIndex = 3;
            // 
            // FormModificarVisita
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 745);
            Controls.Add(lstPac);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAceptar);
            Name = "FormModificarVisita";
            Text = "FormModificarVisita";
            Load += FormModificarVisita_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lstPac;
    }
}