namespace ProyectoBeca
{
    partial class IngresoSistema
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_contrasenia = new System.Windows.Forms.Label();
            this.label_bienvenido = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 20);
            this.textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_bienvenido);
            this.panel1.Controls.Add(this.label_contrasenia);
            this.panel1.Controls.Add(this.label_usuario);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 216);
            this.panel1.TabIndex = 2;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(74, 107);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(43, 13);
            this.label_usuario.TabIndex = 2;
            this.label_usuario.Text = "Usuario";
            // 
            // label_contrasenia
            // 
            this.label_contrasenia.AutoSize = true;
            this.label_contrasenia.Location = new System.Drawing.Point(56, 143);
            this.label_contrasenia.Name = "label_contrasenia";
            this.label_contrasenia.Size = new System.Drawing.Size(61, 13);
            this.label_contrasenia.TabIndex = 3;
            this.label_contrasenia.Text = "Contraseña";
            // 
            // label_bienvenido
            // 
            this.label_bienvenido.AutoSize = true;
            this.label_bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenido.Location = new System.Drawing.Point(141, 27);
            this.label_bienvenido.Name = "label_bienvenido";
            this.label_bienvenido.Size = new System.Drawing.Size(164, 36);
            this.label_bienvenido.TabIndex = 4;
            this.label_bienvenido.Text = "Bienvenido";
            this.label_bienvenido.Click += new System.EventHandler(this.label_bienvenido_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(384, 234);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 3;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // IngresoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 269);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.panel1);
            this.Name = "IngresoSistema";
            this.Text = "Inicio sesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_bienvenido;
        private System.Windows.Forms.Label label_contrasenia;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Button button_aceptar;
    }
}