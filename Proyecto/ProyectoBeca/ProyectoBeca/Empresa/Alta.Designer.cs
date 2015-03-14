namespace ProyectoBeca.Empresa
{
    partial class Alta
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
            this.groupBox_observaciones = new System.Windows.Forms.GroupBox();
            this.richTextBox_observaciones = new System.Windows.Forms.RichTextBox();
            this.groupBox_info_personal = new System.Windows.Forms.GroupBox();
            this.textBox_tel_numero = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_tel_caracteristica = new System.Windows.Forms.TextBox();
            this.textBox_domicilio = new System.Windows.Forms.TextBox();
            this.textBox_razon_social = new System.Windows.Forms.TextBox();
            this.label_domicilio = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.groupBox_Intereses = new System.Windows.Forms.GroupBox();
            this.richTextBox_principales_actividades = new System.Windows.Forms.RichTextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_observaciones.SuspendLayout();
            this.groupBox_info_personal.SuspendLayout();
            this.groupBox_Intereses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_observaciones
            // 
            this.groupBox_observaciones.Controls.Add(this.richTextBox_observaciones);
            this.groupBox_observaciones.Location = new System.Drawing.Point(416, 24);
            this.groupBox_observaciones.Name = "groupBox_observaciones";
            this.groupBox_observaciones.Size = new System.Drawing.Size(395, 292);
            this.groupBox_observaciones.TabIndex = 15;
            this.groupBox_observaciones.TabStop = false;
            this.groupBox_observaciones.Text = "Observaciones";
            this.groupBox_observaciones.Enter += new System.EventHandler(this.groupBox_observaciones_Enter);
            // 
            // richTextBox_observaciones
            // 
            this.richTextBox_observaciones.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_observaciones.Name = "richTextBox_observaciones";
            this.richTextBox_observaciones.Size = new System.Drawing.Size(326, 238);
            this.richTextBox_observaciones.TabIndex = 6;
            this.richTextBox_observaciones.Text = "";
            // 
            // groupBox_info_personal
            // 
            this.groupBox_info_personal.Controls.Add(this.textBox_tel_numero);
            this.groupBox_info_personal.Controls.Add(this.textBox_email);
            this.groupBox_info_personal.Controls.Add(this.textBox_tel_caracteristica);
            this.groupBox_info_personal.Controls.Add(this.textBox_domicilio);
            this.groupBox_info_personal.Controls.Add(this.textBox_razon_social);
            this.groupBox_info_personal.Controls.Add(this.label_domicilio);
            this.groupBox_info_personal.Controls.Add(this.label_mail);
            this.groupBox_info_personal.Controls.Add(this.label_razon_social);
            this.groupBox_info_personal.Controls.Add(this.label_telefono);
            this.groupBox_info_personal.Location = new System.Drawing.Point(15, 24);
            this.groupBox_info_personal.Name = "groupBox_info_personal";
            this.groupBox_info_personal.Size = new System.Drawing.Size(395, 292);
            this.groupBox_info_personal.TabIndex = 14;
            this.groupBox_info_personal.TabStop = false;
            this.groupBox_info_personal.Text = "Informacion de la empresa";
            this.groupBox_info_personal.Enter += new System.EventHandler(this.groupBox_info_personal_Enter);
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
            this.textBox_razon_social.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
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
            // groupBox_Intereses
            // 
            this.groupBox_Intereses.Controls.Add(this.richTextBox_principales_actividades);
            this.groupBox_Intereses.Location = new System.Drawing.Point(15, 322);
            this.groupBox_Intereses.Name = "groupBox_Intereses";
            this.groupBox_Intereses.Size = new System.Drawing.Size(395, 114);
            this.groupBox_Intereses.TabIndex = 16;
            this.groupBox_Intereses.TabStop = false;
            this.groupBox_Intereses.Text = "Principales actividades";
            this.groupBox_Intereses.Enter += new System.EventHandler(this.groupBox_Intereses_Enter);
            // 
            // richTextBox_principales_actividades
            // 
            this.richTextBox_principales_actividades.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_principales_actividades.Name = "richTextBox_principales_actividades";
            this.richTextBox_principales_actividades.Size = new System.Drawing.Size(326, 61);
            this.richTextBox_principales_actividades.TabIndex = 6;
            this.richTextBox_principales_actividades.Text = "";
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 20;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(585, 426);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 19;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 18;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_Intereses);
            this.Controls.Add(this.groupBox_observaciones);
            this.Controls.Add(this.groupBox_info_personal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.groupBox_observaciones.ResumeLayout(false);
            this.groupBox_info_personal.ResumeLayout(false);
            this.groupBox_info_personal.PerformLayout();
            this.groupBox_Intereses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_observaciones;
        private System.Windows.Forms.RichTextBox richTextBox_observaciones;
        private System.Windows.Forms.GroupBox groupBox_info_personal;
        private System.Windows.Forms.TextBox textBox_tel_numero;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_tel_caracteristica;
        private System.Windows.Forms.TextBox textBox_domicilio;
        private System.Windows.Forms.TextBox textBox_razon_social;
        private System.Windows.Forms.Label label_domicilio;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_razon_social;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.GroupBox groupBox_Intereses;
        private System.Windows.Forms.RichTextBox richTextBox_principales_actividades;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
    }
}