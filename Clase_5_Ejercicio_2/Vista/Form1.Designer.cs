namespace Vista
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
            gb_usuario = new GroupBox();
            num_edad = new NumericUpDown();
            lb_edad = new Label();
            lb_direccion = new Label();
            lb_nombre = new Label();
            tb_Direccion = new TextBox();
            tb_nombre = new TextBox();
            gb_genero = new GroupBox();
            rb_nobinario = new RadioButton();
            rb_femenino = new RadioButton();
            rb_masculino = new RadioButton();
            gb_cursos = new GroupBox();
            cb_JavaScript = new CheckBox();
            cb_CMasMas = new CheckBox();
            cb_CSharp = new CheckBox();
            lb_paises = new ListBox();
            btn_ingresar = new Button();
            gb_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            gb_genero.SuspendLayout();
            gb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gb_usuario
            // 
            gb_usuario.Controls.Add(num_edad);
            gb_usuario.Controls.Add(lb_edad);
            gb_usuario.Controls.Add(lb_direccion);
            gb_usuario.Controls.Add(lb_nombre);
            gb_usuario.Controls.Add(tb_Direccion);
            gb_usuario.Controls.Add(tb_nombre);
            gb_usuario.Location = new Point(34, 36);
            gb_usuario.Name = "gb_usuario";
            gb_usuario.Size = new Size(200, 155);
            gb_usuario.TabIndex = 0;
            gb_usuario.TabStop = false;
            gb_usuario.Text = "Detalles del usuario";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(81, 115);
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(100, 23);
            num_edad.TabIndex = 5;
            // 
            // lb_edad
            // 
            lb_edad.AutoSize = true;
            lb_edad.Location = new Point(16, 117);
            lb_edad.Name = "lb_edad";
            lb_edad.Size = new Size(33, 15);
            lb_edad.TabIndex = 4;
            lb_edad.Text = "Edad";
            // 
            // lb_direccion
            // 
            lb_direccion.AutoSize = true;
            lb_direccion.Location = new Point(16, 73);
            lb_direccion.Name = "lb_direccion";
            lb_direccion.Size = new Size(57, 15);
            lb_direccion.TabIndex = 3;
            lb_direccion.Text = "Direccion";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Location = new Point(16, 25);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(51, 15);
            lb_nombre.TabIndex = 2;
            lb_nombre.Text = "Nombre";
            // 
            // tb_Direccion
            // 
            tb_Direccion.Location = new Point(81, 70);
            tb_Direccion.Name = "tb_Direccion";
            tb_Direccion.Size = new Size(100, 23);
            tb_Direccion.TabIndex = 1;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(81, 22);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(100, 23);
            tb_nombre.TabIndex = 0;
            // 
            // gb_genero
            // 
            gb_genero.Controls.Add(rb_nobinario);
            gb_genero.Controls.Add(rb_femenino);
            gb_genero.Controls.Add(rb_masculino);
            gb_genero.Location = new Point(308, 36);
            gb_genero.Name = "gb_genero";
            gb_genero.Size = new Size(154, 120);
            gb_genero.TabIndex = 1;
            gb_genero.TabStop = false;
            gb_genero.Text = "Genero";
            // 
            // rb_nobinario
            // 
            rb_nobinario.AutoSize = true;
            rb_nobinario.Location = new Point(18, 83);
            rb_nobinario.Name = "rb_nobinario";
            rb_nobinario.Size = new Size(81, 19);
            rb_nobinario.TabIndex = 2;
            rb_nobinario.TabStop = true;
            rb_nobinario.Text = "No binario";
            rb_nobinario.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            rb_femenino.AutoSize = true;
            rb_femenino.Location = new Point(18, 54);
            rb_femenino.Name = "rb_femenino";
            rb_femenino.Size = new Size(78, 19);
            rb_femenino.TabIndex = 1;
            rb_femenino.TabStop = true;
            rb_femenino.Text = "Femenino";
            rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            rb_masculino.AutoSize = true;
            rb_masculino.Location = new Point(18, 26);
            rb_masculino.Name = "rb_masculino";
            rb_masculino.Size = new Size(80, 19);
            rb_masculino.TabIndex = 0;
            rb_masculino.TabStop = true;
            rb_masculino.Text = "Masculino";
            rb_masculino.UseVisualStyleBackColor = true;
            // 
            // gb_cursos
            // 
            gb_cursos.Controls.Add(cb_JavaScript);
            gb_cursos.Controls.Add(cb_CMasMas);
            gb_cursos.Controls.Add(cb_CSharp);
            gb_cursos.Location = new Point(308, 187);
            gb_cursos.Name = "gb_cursos";
            gb_cursos.Size = new Size(154, 109);
            gb_cursos.TabIndex = 2;
            gb_cursos.TabStop = false;
            gb_cursos.Text = "Cursos";
            // 
            // cb_JavaScript
            // 
            cb_JavaScript.AutoSize = true;
            cb_JavaScript.Location = new Point(21, 72);
            cb_JavaScript.Name = "cb_JavaScript";
            cb_JavaScript.Size = new Size(78, 19);
            cb_JavaScript.TabIndex = 2;
            cb_JavaScript.Text = "JavaScript";
            cb_JavaScript.UseVisualStyleBackColor = true;
            // 
            // cb_CMasMas
            // 
            cb_CMasMas.AutoSize = true;
            cb_CMasMas.Location = new Point(21, 47);
            cb_CMasMas.Name = "cb_CMasMas";
            cb_CMasMas.Size = new Size(50, 19);
            cb_CMasMas.TabIndex = 1;
            cb_CMasMas.Text = "C++";
            cb_CMasMas.UseVisualStyleBackColor = true;
            // 
            // cb_CSharp
            // 
            cb_CSharp.AutoSize = true;
            cb_CSharp.Location = new Point(21, 22);
            cb_CSharp.Name = "cb_CSharp";
            cb_CSharp.Size = new Size(41, 19);
            cb_CSharp.TabIndex = 0;
            cb_CSharp.Text = "C#";
            cb_CSharp.UseVisualStyleBackColor = true;
            // 
            // lb_paises
            // 
            lb_paises.FormattingEnabled = true;
            lb_paises.ItemHeight = 15;
            lb_paises.Items.AddRange(new object[] { "Argentina", "Chile ", "Paraguay" });
            lb_paises.Location = new Point(34, 225);
            lb_paises.Name = "lb_paises";
            lb_paises.Size = new Size(200, 109);
            lb_paises.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(308, 324);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(154, 31);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 368);
            Controls.Add(btn_ingresar);
            Controls.Add(lb_paises);
            Controls.Add(gb_cursos);
            Controls.Add(gb_genero);
            Controls.Add(gb_usuario);
            Name = "Form1";
            Text = "Form1";
            gb_usuario.ResumeLayout(false);
            gb_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            gb_genero.ResumeLayout(false);
            gb_genero.PerformLayout();
            gb_cursos.ResumeLayout(false);
            gb_cursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_usuario;
        private NumericUpDown num_edad;
        private Label lb_edad;
        private Label lb_direccion;
        private Label lb_nombre;
        private TextBox tb_Direccion;
        private TextBox tb_nombre;
        private GroupBox gb_genero;
        private GroupBox gb_cursos;
        private RadioButton rb_nobinario;
        private RadioButton rb_femenino;
        private RadioButton rb_masculino;
        private CheckBox cb_JavaScript;
        private CheckBox cb_CMasMas;
        private CheckBox cb_CSharp;
        private ListBox lb_paises;
        private Button btn_ingresar;
    }
}