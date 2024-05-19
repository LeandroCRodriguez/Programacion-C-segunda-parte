namespace Clase_5_Ejercicio_1
{
    partial class FormSaludo
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
            lb_mensaje = new Label();
            lb_titulo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lb_mensaje
            // 
            lb_mensaje.AutoSize = true;
            lb_mensaje.Location = new Point(207, 111);
            lb_mensaje.Name = "lb_mensaje";
            lb_mensaje.Size = new Size(37, 15);
            lb_mensaje.TabIndex = 0;
            lb_mensaje.Text = "Titulo";
            // 
            // lb_titulo
            // 
            lb_titulo.AutoSize = true;
            lb_titulo.Location = new Point(429, 111);
            lb_titulo.Name = "lb_titulo";
            lb_titulo.Size = new Size(54, 15);
            lb_titulo.TabIndex = 1;
            lb_titulo.Text = "Mensaje ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(252, 40);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 2;
            label1.Text = "Hola Windows Form";
            // 
            // FormSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lb_titulo);
            Controls.Add(lb_mensaje);
            Name = "FormSaludo";
            Text = "FormSaludo";
            Load += FormSaludo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mensaje;
        private Label lb_titulo;
        private Label label1;
    }
}