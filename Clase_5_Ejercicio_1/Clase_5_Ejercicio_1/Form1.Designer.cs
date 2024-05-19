namespace Clase_5_Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_nombre = new TextBox();
            tb_apellido = new TextBox();
            lb_nombre = new Label();
            lb_apellido = new Label();
            bt_saludar = new Button();
            SuspendLayout();
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(221, 224);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(100, 23);
            tb_nombre.TabIndex = 0;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(474, 224);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(100, 23);
            tb_apellido.TabIndex = 1;
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nombre.Location = new Point(221, 175);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(53, 15);
            lb_nombre.TabIndex = 2;
            lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            lb_apellido.AutoSize = true;
            lb_apellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_apellido.Location = new Point(474, 175);
            lb_apellido.Name = "lb_apellido";
            lb_apellido.Size = new Size(52, 15);
            lb_apellido.TabIndex = 3;
            lb_apellido.Text = "Apellido";
            // 
            // bt_saludar
            // 
            bt_saludar.Location = new Point(358, 271);
            bt_saludar.Name = "bt_saludar";
            bt_saludar.Size = new Size(93, 42);
            bt_saludar.TabIndex = 4;
            bt_saludar.Text = "Saludar";
            bt_saludar.UseVisualStyleBackColor = true;
            bt_saludar.Click += bt_saludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_saludar);
            Controls.Add(lb_apellido);
            Controls.Add(lb_nombre);
            Controls.Add(tb_apellido);
            Controls.Add(tb_nombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nombre;
        private TextBox tb_apellido;
        private Label lb_nombre;
        private Label lb_apellido;
        private Button bt_saludar;
    }
}