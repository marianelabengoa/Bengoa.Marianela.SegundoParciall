namespace WinFormLogin
{
    partial class FormParentesco
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
            txtParentesco = new TextBox();
            btnParentesco = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(770, 48);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el parentesco que tiene con el paciente";
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(187, 122);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.Size = new Size(480, 55);
            txtParentesco.TabIndex = 1;
            // 
            // btnParentesco
            // 
            btnParentesco.Cursor = Cursors.Hand;
            btnParentesco.Location = new Point(315, 284);
            btnParentesco.Name = "btnParentesco";
            btnParentesco.Size = new Size(225, 69);
            btnParentesco.TabIndex = 2;
            btnParentesco.Text = "Aceptar";
            btnParentesco.UseVisualStyleBackColor = true;
            btnParentesco.Click += btnParentesco_Click;
            // 
            // FormParentesco
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 403);
            Controls.Add(btnParentesco);
            Controls.Add(txtParentesco);
            Controls.Add(label1);
            Name = "FormParentesco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parentesco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtParentesco;
        private Button btnParentesco;
    }
}