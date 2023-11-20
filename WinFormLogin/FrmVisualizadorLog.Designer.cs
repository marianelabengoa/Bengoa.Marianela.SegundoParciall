namespace WinFormLogin
{
    partial class FrmVisualizadorLog
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
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Location = new Point(90, 40);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(2692, 55);
            txtLog.TabIndex = 0;
            // 
            // FrmVisualizadorLog
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2834, 754);
            Controls.Add(txtLog);
            Name = "FrmVisualizadorLog";
            Text = "FrmVisualizadorLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLog;
    }
}