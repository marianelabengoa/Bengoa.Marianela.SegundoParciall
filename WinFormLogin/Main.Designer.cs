namespace WinFormLogin
{
    partial class Main
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            txtNumHabitacion = new TextBox();
            btnIngresar = new Button();
            btnCancelIngreso = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 49);
            label1.Name = "label1";
            label1.Size = new Size(382, 57);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 153);
            label2.Name = "label2";
            label2.Size = new Size(152, 48);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 333);
            label3.Name = "label3";
            label3.Size = new Size(152, 48);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 527);
            label4.Name = "label4";
            label4.Size = new Size(82, 48);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 721);
            label5.Name = "label5";
            label5.Size = new Size(98, 48);
            label5.TabIndex = 4;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 907);
            label6.Name = "label6";
            label6.Size = new Size(376, 48);
            label6.TabIndex = 5;
            label6.Text = "Numero de habitacion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(333, 233);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 55);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(333, 403);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 55);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(333, 602);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(300, 55);
            txtDni.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(333, 790);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(300, 55);
            txtEdad.TabIndex = 9;
            // 
            // txtNumHabitacion
            // 
            txtNumHabitacion.Location = new Point(333, 972);
            txtNumHabitacion.Name = "txtNumHabitacion";
            txtNumHabitacion.Size = new Size(300, 55);
            txtNumHabitacion.TabIndex = 10;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(151, 1104);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(225, 69);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Aceptar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelIngreso
            // 
            btnCancelIngreso.Cursor = Cursors.Hand;
            btnCancelIngreso.Location = new Point(571, 1104);
            btnCancelIngreso.Name = "btnCancelIngreso";
            btnCancelIngreso.Size = new Size(225, 69);
            btnCancelIngreso.TabIndex = 12;
            btnCancelIngreso.Text = "Cancelar";
            btnCancelIngreso.UseVisualStyleBackColor = true;
            btnCancelIngreso.Click += btnCancelIngreso_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(966, 1250);
            Controls.Add(btnCancelIngreso);
            Controls.Add(btnIngresar);
            Controls.Add(txtNumHabitacion);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected Label label5;
        protected Label label6;
        protected TextBox txtNombre;
        protected TextBox txtApellido;
        protected TextBox txtDni;
        protected TextBox txtEdad;
        protected TextBox txtNumHabitacion;
        protected Button btnIngresar;
        protected Button btnCancelIngreso;
    }
}