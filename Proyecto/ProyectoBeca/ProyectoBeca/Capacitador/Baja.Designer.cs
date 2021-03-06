﻿namespace ProyectoBeca.Capacitador
{
    partial class Baja
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
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_observaciones = new System.Windows.Forms.GroupBox();
            this.richTextBox_observaciones = new System.Windows.Forms.RichTextBox();
            this.groupBox_areas_capacitacion = new System.Windows.Forms.GroupBox();
            this.dataGridView_areas_capacitacion = new System.Windows.Forms.DataGridView();
            this.groupBox_info_personal = new System.Windows.Forms.GroupBox();
            this.comboBox_barrio = new System.Windows.Forms.ComboBox();
            this.textBox_tel_numero = new System.Windows.Forms.TextBox();
            this.textBox_cuit_cuil = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_tel_caracteristica = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_cuit_cuil = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_fecha_nac = new System.Windows.Forms.Label();
            this.label_barrio = new System.Windows.Forms.Label();
            this.radioButton_sin_verificar = new System.Windows.Forms.RadioButton();
            this.radioButton_verificando = new System.Windows.Forms.RadioButton();
            this.radioButton_verificado = new System.Windows.Forms.RadioButton();
            this.groupBox_estado = new System.Windows.Forms.GroupBox();
            this.groupBox_observaciones.SuspendLayout();
            this.groupBox_areas_capacitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_areas_capacitacion)).BeginInit();
            this.groupBox_info_personal.SuspendLayout();
            this.groupBox_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(661, 428);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(75, 23);
            this.button_borrar.TabIndex = 30;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            this.button_borrar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(742, 428);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 28;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_observaciones
            // 
            this.groupBox_observaciones.Controls.Add(this.richTextBox_observaciones);
            this.groupBox_observaciones.Location = new System.Drawing.Point(12, 308);
            this.groupBox_observaciones.Name = "groupBox_observaciones";
            this.groupBox_observaciones.Size = new System.Drawing.Size(395, 114);
            this.groupBox_observaciones.TabIndex = 26;
            this.groupBox_observaciones.TabStop = false;
            this.groupBox_observaciones.Text = "Observaciones";
            // 
            // richTextBox_observaciones
            // 
            this.richTextBox_observaciones.Enabled = false;
            this.richTextBox_observaciones.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_observaciones.Name = "richTextBox_observaciones";
            this.richTextBox_observaciones.Size = new System.Drawing.Size(326, 61);
            this.richTextBox_observaciones.TabIndex = 6;
            this.richTextBox_observaciones.Text = "";
            // 
            // groupBox_areas_capacitacion
            // 
            this.groupBox_areas_capacitacion.Controls.Add(this.dataGridView_areas_capacitacion);
            this.groupBox_areas_capacitacion.Location = new System.Drawing.Point(422, 10);
            this.groupBox_areas_capacitacion.Name = "groupBox_areas_capacitacion";
            this.groupBox_areas_capacitacion.Size = new System.Drawing.Size(400, 292);
            this.groupBox_areas_capacitacion.TabIndex = 27;
            this.groupBox_areas_capacitacion.TabStop = false;
            this.groupBox_areas_capacitacion.Text = "Areas de capacitacion";
            this.groupBox_areas_capacitacion.Enter += new System.EventHandler(this.groupBox_formacion_Enter);
            // 
            // dataGridView_areas_capacitacion
            // 
            this.dataGridView_areas_capacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_areas_capacitacion.Enabled = false;
            this.dataGridView_areas_capacitacion.Location = new System.Drawing.Point(23, 45);
            this.dataGridView_areas_capacitacion.Name = "dataGridView_areas_capacitacion";
            this.dataGridView_areas_capacitacion.Size = new System.Drawing.Size(358, 199);
            this.dataGridView_areas_capacitacion.TabIndex = 19;
            // 
            // groupBox_info_personal
            // 
            this.groupBox_info_personal.Controls.Add(this.comboBox_barrio);
            this.groupBox_info_personal.Controls.Add(this.textBox_tel_numero);
            this.groupBox_info_personal.Controls.Add(this.textBox_cuit_cuil);
            this.groupBox_info_personal.Controls.Add(this.textBox_email);
            this.groupBox_info_personal.Controls.Add(this.textBox_tel_caracteristica);
            this.groupBox_info_personal.Controls.Add(this.textBox_apellido);
            this.groupBox_info_personal.Controls.Add(this.textBox_nombre);
            this.groupBox_info_personal.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox_info_personal.Controls.Add(this.label_apellido);
            this.groupBox_info_personal.Controls.Add(this.label_mail);
            this.groupBox_info_personal.Controls.Add(this.label_cuit_cuil);
            this.groupBox_info_personal.Controls.Add(this.label_nombre);
            this.groupBox_info_personal.Controls.Add(this.label_telefono);
            this.groupBox_info_personal.Controls.Add(this.label_fecha_nac);
            this.groupBox_info_personal.Controls.Add(this.label_barrio);
            this.groupBox_info_personal.Location = new System.Drawing.Point(12, 10);
            this.groupBox_info_personal.Name = "groupBox_info_personal";
            this.groupBox_info_personal.Size = new System.Drawing.Size(395, 292);
            this.groupBox_info_personal.TabIndex = 25;
            this.groupBox_info_personal.TabStop = false;
            this.groupBox_info_personal.Text = "Informacion personal";
            // 
            // comboBox_barrio
            // 
            this.comboBox_barrio.Enabled = false;
            this.comboBox_barrio.Items.AddRange(new object[] {
            "Agronomía",
            "Almagro",
            "Balvanera",
            "Barracas",
            "Belgrano",
            "Boedo",
            "Caballito",
            "Chacarita",
            "Coghlan",
            "Colegiales",
            "Constitución",
            "Flores",
            "Floresta",
            "La Boca",
            "La Paternal",
            "Liniers",
            "Mataderos",
            "Monte Castro",
            "Monserrat (originalmente llamado Montserrat).",
            "Nueva Pompeya",
            "Núñez",
            "Palermo",
            "Parque Avellaneda",
            "Parque Chacabuco",
            "Parque Chas",
            "Parque Patricios",
            "Puerto Madero",
            "Recoleta",
            "Retiro",
            "Saavedra",
            "San Cristóbal",
            "San Nicolás",
            "San Telmo",
            "Vélez Sársfield",
            "Versalles",
            "Villa Crespo",
            "Villa del Parque",
            "Villa Devoto",
            "Villa General Mitre",
            "Villa Lugano",
            "Villa Luro",
            "Villa Ortúzar",
            "Villa Pueyrredón",
            "Villa Real",
            "Villa Riachuelo",
            "Villa Santa Rita",
            "Villa Soldati",
            "Villa Urquiza"});
            this.comboBox_barrio.Location = new System.Drawing.Point(153, 170);
            this.comboBox_barrio.Name = "comboBox_barrio";
            this.comboBox_barrio.Size = new System.Drawing.Size(200, 21);
            this.comboBox_barrio.TabIndex = 19;
            // 
            // textBox_tel_numero
            // 
            this.textBox_tel_numero.Enabled = false;
            this.textBox_tel_numero.Location = new System.Drawing.Point(206, 198);
            this.textBox_tel_numero.Name = "textBox_tel_numero";
            this.textBox_tel_numero.Size = new System.Drawing.Size(147, 20);
            this.textBox_tel_numero.TabIndex = 18;
            // 
            // textBox_cuit_cuil
            // 
            this.textBox_cuit_cuil.Enabled = false;
            this.textBox_cuit_cuil.Location = new System.Drawing.Point(153, 111);
            this.textBox_cuit_cuil.Name = "textBox_cuit_cuil";
            this.textBox_cuit_cuil.Size = new System.Drawing.Size(200, 20);
            this.textBox_cuit_cuil.TabIndex = 17;
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Location = new System.Drawing.Point(153, 224);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 15;
            // 
            // textBox_tel_caracteristica
            // 
            this.textBox_tel_caracteristica.Enabled = false;
            this.textBox_tel_caracteristica.Location = new System.Drawing.Point(153, 198);
            this.textBox_tel_caracteristica.Name = "textBox_tel_caracteristica";
            this.textBox_tel_caracteristica.Size = new System.Drawing.Size(47, 20);
            this.textBox_tel_caracteristica.TabIndex = 14;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Enabled = false;
            this.textBox_apellido.Location = new System.Drawing.Point(153, 80);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(200, 20);
            this.textBox_apellido.TabIndex = 13;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Enabled = false;
            this.textBox_nombre.Location = new System.Drawing.Point(153, 49);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox_nombre.TabIndex = 12;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Enabled = false;
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(153, 141);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_nacimiento.TabIndex = 11;
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(103, 83);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_apellido.TabIndex = 4;
            this.label_apellido.Text = "Apellido";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(113, 227);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(32, 13);
            this.label_mail.TabIndex = 10;
            this.label_mail.Text = "Email";
            // 
            // label_cuit_cuil
            // 
            this.label_cuit_cuil.AutoSize = true;
            this.label_cuit_cuil.Location = new System.Drawing.Point(86, 114);
            this.label_cuit_cuil.Name = "label_cuit_cuil";
            this.label_cuit_cuil.Size = new System.Drawing.Size(61, 13);
            this.label_cuit_cuil.TabIndex = 2;
            this.label_cuit_cuil.Text = "CUIT/CUIL";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(103, 52);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(98, 201);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 9;
            this.label_telefono.Text = "Telefono";
            // 
            // label_fecha_nac
            // 
            this.label_fecha_nac.AutoSize = true;
            this.label_fecha_nac.Location = new System.Drawing.Point(41, 143);
            this.label_fecha_nac.Name = "label_fecha_nac";
            this.label_fecha_nac.Size = new System.Drawing.Size(106, 13);
            this.label_fecha_nac.TabIndex = 3;
            this.label_fecha_nac.Text = "Fecha de nacimiento";
            // 
            // label_barrio
            // 
            this.label_barrio.AutoSize = true;
            this.label_barrio.Location = new System.Drawing.Point(111, 173);
            this.label_barrio.Name = "label_barrio";
            this.label_barrio.Size = new System.Drawing.Size(34, 13);
            this.label_barrio.TabIndex = 8;
            this.label_barrio.Text = "Barrio";
            // 
            // radioButton_sin_verificar
            // 
            this.radioButton_sin_verificar.AutoSize = true;
            this.radioButton_sin_verificar.Enabled = false;
            this.radioButton_sin_verificar.Location = new System.Drawing.Point(157, 26);
            this.radioButton_sin_verificar.Name = "radioButton_sin_verificar";
            this.radioButton_sin_verificar.Size = new System.Drawing.Size(80, 17);
            this.radioButton_sin_verificar.TabIndex = 0;
            this.radioButton_sin_verificar.TabStop = true;
            this.radioButton_sin_verificar.Text = "Sin verificar";
            this.radioButton_sin_verificar.UseVisualStyleBackColor = true;
            // 
            // radioButton_verificando
            // 
            this.radioButton_verificando.AutoSize = true;
            this.radioButton_verificando.Enabled = false;
            this.radioButton_verificando.Location = new System.Drawing.Point(157, 49);
            this.radioButton_verificando.Name = "radioButton_verificando";
            this.radioButton_verificando.Size = new System.Drawing.Size(78, 17);
            this.radioButton_verificando.TabIndex = 1;
            this.radioButton_verificando.TabStop = true;
            this.radioButton_verificando.Text = "Verificando";
            this.radioButton_verificando.UseVisualStyleBackColor = true;
            // 
            // radioButton_verificado
            // 
            this.radioButton_verificado.AutoSize = true;
            this.radioButton_verificado.Enabled = false;
            this.radioButton_verificado.Location = new System.Drawing.Point(157, 72);
            this.radioButton_verificado.Name = "radioButton_verificado";
            this.radioButton_verificado.Size = new System.Drawing.Size(72, 17);
            this.radioButton_verificado.TabIndex = 2;
            this.radioButton_verificado.TabStop = true;
            this.radioButton_verificado.Text = "Verificado";
            this.radioButton_verificado.UseVisualStyleBackColor = true;
            this.radioButton_verificado.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox_estado
            // 
            this.groupBox_estado.Controls.Add(this.radioButton_verificado);
            this.groupBox_estado.Controls.Add(this.radioButton_verificando);
            this.groupBox_estado.Controls.Add(this.radioButton_sin_verificar);
            this.groupBox_estado.Location = new System.Drawing.Point(422, 308);
            this.groupBox_estado.Name = "groupBox_estado";
            this.groupBox_estado.Size = new System.Drawing.Size(395, 114);
            this.groupBox_estado.TabIndex = 31;
            this.groupBox_estado.TabStop = false;
            this.groupBox_estado.Text = "Estado";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox_estado);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_observaciones);
            this.Controls.Add(this.groupBox_areas_capacitacion);
            this.Controls.Add(this.groupBox_info_personal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja";
            this.groupBox_observaciones.ResumeLayout(false);
            this.groupBox_areas_capacitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_areas_capacitacion)).EndInit();
            this.groupBox_info_personal.ResumeLayout(false);
            this.groupBox_info_personal.PerformLayout();
            this.groupBox_estado.ResumeLayout(false);
            this.groupBox_estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_observaciones;
        private System.Windows.Forms.RichTextBox richTextBox_observaciones;
        private System.Windows.Forms.GroupBox groupBox_areas_capacitacion;
        private System.Windows.Forms.DataGridView dataGridView_areas_capacitacion;
        private System.Windows.Forms.GroupBox groupBox_info_personal;
        private System.Windows.Forms.ComboBox comboBox_barrio;
        private System.Windows.Forms.TextBox textBox_tel_numero;
        private System.Windows.Forms.TextBox textBox_cuit_cuil;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_tel_caracteristica;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_cuit_cuil;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_fecha_nac;
        private System.Windows.Forms.Label label_barrio;
        private System.Windows.Forms.RadioButton radioButton_sin_verificar;
        private System.Windows.Forms.RadioButton radioButton_verificando;
        private System.Windows.Forms.RadioButton radioButton_verificado;
        private System.Windows.Forms.GroupBox groupBox_estado;
    }
}