namespace ProyectoBeca.Empresa
{
    partial class Modificacion
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
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_principales_actividades = new System.Windows.Forms.GroupBox();
            this.richTextBox_principales_actividades = new System.Windows.Forms.RichTextBox();
            this.groupBox_observaciones = new System.Windows.Forms.GroupBox();
            this.richTextBox_observaciones = new System.Windows.Forms.RichTextBox();
            this.groupBox_info_empresa = new System.Windows.Forms.GroupBox();
            this.textBox_tel_numero = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_tel_caracteristica = new System.Windows.Forms.TextBox();
            this.textBox_domicilio = new System.Windows.Forms.TextBox();
            this.textBox_razon_social = new System.Windows.Forms.TextBox();
            this.label_domicilio = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.groupBox_principales_actividades.SuspendLayout();
            this.groupBox_observaciones.SuspendLayout();
            this.groupBox_info_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(665, 420);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 26;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(584, 420);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 25;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(746, 420);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 24;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_principales_actividades
            // 
            this.groupBox_principales_actividades.Controls.Add(this.richTextBox_principales_actividades);
            this.groupBox_principales_actividades.Location = new System.Drawing.Point(14, 316);
            this.groupBox_principales_actividades.Name = "groupBox_principales_actividades";
            this.groupBox_principales_actividades.Size = new System.Drawing.Size(395, 114);
            this.groupBox_principales_actividades.TabIndex = 23;
            this.groupBox_principales_actividades.TabStop = false;
            this.groupBox_principales_actividades.Text = "Principales actividades";
            this.groupBox_principales_actividades.Enter += new System.EventHandler(this.groupBox_Intereses_Enter);
            // 
            // richTextBox_principales_actividades
            // 
            this.richTextBox_principales_actividades.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_principales_actividades.Name = "richTextBox_principales_actividades";
            this.richTextBox_principales_actividades.Size = new System.Drawing.Size(326, 61);
            this.richTextBox_principales_actividades.TabIndex = 6;
            this.richTextBox_principales_actividades.Text = "";
            // 
            // groupBox_observaciones
            // 
            this.groupBox_observaciones.Controls.Add(this.richTextBox_observaciones);
            this.groupBox_observaciones.Location = new System.Drawing.Point(415, 18);
            this.groupBox_observaciones.Name = "groupBox_observaciones";
            this.groupBox_observaciones.Size = new System.Drawing.Size(395, 292);
            this.groupBox_observaciones.TabIndex = 22;
            this.groupBox_observaciones.TabStop = false;
            this.groupBox_observaciones.Text = "Observaciones";
            // 
            // richTextBox_observaciones
            // 
            this.richTextBox_observaciones.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_observaciones.Name = "richTextBox_observaciones";
            this.richTextBox_observaciones.Size = new System.Drawing.Size(326, 238);
            this.richTextBox_observaciones.TabIndex = 6;
            this.richTextBox_observaciones.Text = "";
            // 
            // groupBox_info_empresa
            // 
            this.groupBox_info_empresa.Controls.Add(this.textBox_tel_numero);
            this.groupBox_info_empresa.Controls.Add(this.textBox_email);
            this.groupBox_info_empresa.Controls.Add(this.textBox_tel_caracteristica);
            this.groupBox_info_empresa.Controls.Add(this.textBox_domicilio);
            this.groupBox_info_empresa.Controls.Add(this.textBox_razon_social);
            this.groupBox_info_empresa.Controls.Add(this.label_domicilio);
            this.groupBox_info_empresa.Controls.Add(this.label_mail);
            this.groupBox_info_empresa.Controls.Add(this.label_razon_social);
            this.groupBox_info_empresa.Controls.Add(this.label_telefono);
            this.groupBox_info_empresa.Location = new System.Drawing.Point(14, 18);
            this.groupBox_info_empresa.Name = "groupBox_info_empresa";
            this.groupBox_info_empresa.Size = new System.Drawing.Size(395, 292);
            this.groupBox_info_empresa.TabIndex = 21;
            this.groupBox_info_empresa.TabStop = false;
            this.groupBox_info_empresa.Text = "Informacion de la empresa";
            // 
            // textBox_tel_numero
            // 
            this.textBox_tel_numero.Location = new System.Drawing.Point(185, 152);
            this.textBox_tel_numero.Name = "textBox_tel_numero";
            this.textBox_tel_numero.Size = new System.Drawing.Size(147, 20);
            this.textBox_tel_numero.TabIndex = 18;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(132, 178);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 15;
            // 
            // textBox_tel_caracteristica
            // 
            this.textBox_tel_caracteristica.Location = new System.Drawing.Point(132, 152);
            this.textBox_tel_caracteristica.Name = "textBox_tel_caracteristica";
            this.textBox_tel_caracteristica.Size = new System.Drawing.Size(47, 20);
            this.textBox_tel_caracteristica.TabIndex = 14;
            // 
            // textBox_domicilio
            // 
            this.textBox_domicilio.Location = new System.Drawing.Point(132, 126);
            this.textBox_domicilio.Name = "textBox_domicilio";
            this.textBox_domicilio.Size = new System.Drawing.Size(200, 20);
            this.textBox_domicilio.TabIndex = 13;
            // 
            // textBox_razon_social
            // 
            this.textBox_razon_social.Location = new System.Drawing.Point(132, 95);
            this.textBox_razon_social.Name = "textBox_razon_social";
            this.textBox_razon_social.Size = new System.Drawing.Size(200, 20);
            this.textBox_razon_social.TabIndex = 12;
            // 
            // label_domicilio
            // 
            this.label_domicilio.AutoSize = true;
            this.label_domicilio.Location = new System.Drawing.Point(82, 129);
            this.label_domicilio.Name = "label_domicilio";
            this.label_domicilio.Size = new System.Drawing.Size(49, 13);
            this.label_domicilio.TabIndex = 4;
            this.label_domicilio.Text = "Domicilio";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(92, 181);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(32, 13);
            this.label_mail.TabIndex = 10;
            this.label_mail.Text = "Email";
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Location = new System.Drawing.Point(63, 95);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(68, 13);
            this.label_razon_social.TabIndex = 0;
            this.label_razon_social.Text = "Razon social";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(77, 155);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 9;
            this.label_telefono.Text = "Telefono";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_principales_actividades);
            this.Controls.Add(this.groupBox_observaciones);
            this.Controls.Add(this.groupBox_info_empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.groupBox_principales_actividades.ResumeLayout(false);
            this.groupBox_observaciones.ResumeLayout(false);
            this.groupBox_info_empresa.ResumeLayout(false);
            this.groupBox_info_empresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_principales_actividades;
        private System.Windows.Forms.RichTextBox richTextBox_principales_actividades;
        private System.Windows.Forms.GroupBox groupBox_observaciones;
        private System.Windows.Forms.RichTextBox richTextBox_observaciones;
        private System.Windows.Forms.GroupBox groupBox_info_empresa;
        private System.Windows.Forms.TextBox textBox_tel_numero;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_tel_caracteristica;
        private System.Windows.Forms.TextBox textBox_domicilio;
        private System.Windows.Forms.TextBox textBox_razon_social;
        private System.Windows.Forms.Label label_domicilio;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_razon_social;
        private System.Windows.Forms.Label label_telefono;
    }
}