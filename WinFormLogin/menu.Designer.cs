namespace WinFormLogin
{
    partial class menu
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
            btnAgregarPac = new Button();
            btnAgregarVis = new Button();
            label1 = new Label();
            btnCerrarApp = new Button();
            btnModificar = new Button();
            btnModVis = new Button();
            pictureBox1 = new PictureBox();
            lblBienvenido = new Label();
            label2 = new Label();
            btnVisualizadorLog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarPac
            // 
            btnAgregarPac.Cursor = Cursors.Hand;
            btnAgregarPac.Location = new Point(18, 83);
            btnAgregarPac.Margin = new Padding(1);
            btnAgregarPac.Name = "btnAgregarPac";
            btnAgregarPac.Size = new Size(166, 22);
            btnAgregarPac.TabIndex = 0;
            btnAgregarPac.Text = "Agregar paciente";
            btnAgregarPac.UseVisualStyleBackColor = true;
            btnAgregarPac.Click += btnAgregarPac_Click;
            // 
            // btnAgregarVis
            // 
            btnAgregarVis.Cursor = Cursors.Hand;
            btnAgregarVis.Location = new Point(199, 83);
            btnAgregarVis.Margin = new Padding(1);
            btnAgregarVis.Name = "btnAgregarVis";
            btnAgregarVis.Size = new Size(163, 22);
            btnAgregarVis.TabIndex = 1;
            btnAgregarVis.Text = "Agregar visita";
            btnAgregarVis.UseVisualStyleBackColor = true;
            btnAgregarVis.Click += btnAgregarVis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 50);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 2;
            label1.Text = "¿Que accion desea realizar?";
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.Cursor = Cursors.Hand;
            btnCerrarApp.Location = new Point(106, 168);
            btnCerrarApp.Margin = new Padding(1);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(163, 22);
            btnCerrarApp.TabIndex = 3;
            btnCerrarApp.Text = "cerrar app";
            btnCerrarApp.UseVisualStyleBackColor = true;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(18, 112);
            btnModificar.Margin = new Padding(1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(163, 22);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "modificar pac";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnModVis
            // 
            btnModVis.Cursor = Cursors.Hand;
            btnModVis.Location = new Point(199, 112);
            btnModVis.Margin = new Padding(1);
            btnModVis.Name = "btnModVis";
            btnModVis.Size = new Size(163, 22);
            btnModVis.TabIndex = 5;
            btnModVis.Text = "modificar visita";
            btnModVis.UseVisualStyleBackColor = true;
            btnModVis.Click += btnModVis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(427, 4);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 156);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(116, 16);
            lblBienvenido.Margin = new Padding(1, 0, 1, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(135, 24);
            lblBienvenido.TabIndex = 7;
            lblBienvenido.Text = "BIENVENIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 168);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // btnVisualizadorLog
            // 
            btnVisualizadorLog.Cursor = Cursors.Hand;
            btnVisualizadorLog.Location = new Point(106, 138);
            btnVisualizadorLog.Margin = new Padding(1);
            btnVisualizadorLog.Name = "btnVisualizadorLog";
            btnVisualizadorLog.Size = new Size(163, 22);
            btnVisualizadorLog.TabIndex = 9;
            btnVisualizadorLog.Text = "Visualizar log";
            btnVisualizadorLog.UseVisualStyleBackColor = true;
            btnVisualizadorLog.Click += button1_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(618, 201);
            Controls.Add(btnVisualizadorLog);
            Controls.Add(label2);
            Controls.Add(lblBienvenido);
            Controls.Add(pictureBox1);
            Controls.Add(btnModVis);
            Controls.Add(btnModificar);
            Controls.Add(btnCerrarApp);
            Controls.Add(label1);
            Controls.Add(btnAgregarVis);
            Controls.Add(btnAgregarPac);
            Margin = new Padding(1);
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPac;
        private Button btnAgregarVis;
        private Label label1;
        private Button btnCerrarApp;
        private Button btnModificar;
        private Button btnModVis;
        private PictureBox pictureBox1;
        private Label lblBienvenido;
        private Label label2;
        private Button btnVisualizadorLog;
    }
}