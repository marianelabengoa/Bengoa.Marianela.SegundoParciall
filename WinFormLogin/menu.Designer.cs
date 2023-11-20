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
            btnVisualizarLog = new Button();
            SuspendLayout();
            // 
            // btnAgregarPac
            // 
            btnAgregarPac.Location = new Point(50, 266);
            btnAgregarPac.Name = "btnAgregarPac";
            btnAgregarPac.Size = new Size(474, 69);
            btnAgregarPac.TabIndex = 0;
            btnAgregarPac.Text = "Agregar paciente";
            btnAgregarPac.UseVisualStyleBackColor = true;
            btnAgregarPac.Click += btnAgregarPac_Click;
            // 
            // btnAgregarVis
            // 
            btnAgregarVis.Location = new Point(568, 266);
            btnAgregarVis.Name = "btnAgregarVis";
            btnAgregarVis.Size = new Size(467, 69);
            btnAgregarVis.TabIndex = 1;
            btnAgregarVis.Text = "Agregar visita";
            btnAgregarVis.UseVisualStyleBackColor = true;
            btnAgregarVis.Click += btnAgregarVis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 117);
            label1.Name = "label1";
            label1.Size = new Size(457, 48);
            label1.TabIndex = 2;
            label1.Text = "¿Que accion desea realizar?";
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.Location = new Point(348, 488);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(467, 69);
            btnCerrarApp.TabIndex = 3;
            btnCerrarApp.Text = "cerrar app";
            btnCerrarApp.UseVisualStyleBackColor = true;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // btnVisualizarLog
            // 
            btnVisualizarLog.Location = new Point(348, 370);
            btnVisualizarLog.Name = "btnVisualizarLog";
            btnVisualizarLog.Size = new Size(467, 69);
            btnVisualizarLog.TabIndex = 4;
            btnVisualizarLog.Text = "Visualizar Log";
            btnVisualizarLog.UseVisualStyleBackColor = true;
            btnVisualizarLog.Click += btnVisualizarLog_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 578);
            Controls.Add(btnVisualizarLog);
            Controls.Add(btnCerrarApp);
            Controls.Add(label1);
            Controls.Add(btnAgregarVis);
            Controls.Add(btnAgregarPac);
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPac;
        private Button btnAgregarVis;
        private Label label1;
        private Button btnCerrarApp;
        private Button btnVisualizarLog;
    }
}