namespace Vista
{
    partial class FormDatos
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
            lb_nombre = new Label();
            SuspendLayout();
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Location = new Point(27, 38);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(38, 15);
            lb_nombre.TabIndex = 0;
            lb_nombre.Text = "label1";
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 308);
            Controls.Add(lb_nombre);
            Name = "FormDatos";
            Text = "FormDatos";
            Load += FormDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nombre;
    }
}