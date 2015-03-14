namespace ProyectoBeca.Candidato
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
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox_observaciones = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_formacion = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_opciones_terciario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_universitario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_secundario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_primario = new System.Windows.Forms.ComboBox();
            this.label_primario = new System.Windows.Forms.Label();
            this.label_secundaria = new System.Windows.Forms.Label();
            this.label_universitario = new System.Windows.Forms.Label();
            this.label_terciario = new System.Windows.Forms.Label();
            this.label_cursos = new System.Windows.Forms.Label();
            this.groupBox_Intereses = new System.Windows.Forms.GroupBox();
            this.richTextBox_intereses = new System.Windows.Forms.RichTextBox();
            this.groupBox_info_personal = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_cuit_cuil = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_fecha_nac = new System.Windows.Forms.Label();
            this.label_barrio = new System.Windows.Forms.Label();
            this.label_primaria = new System.Windows.Forms.Label();
            this.groupBox_observaciones.SuspendLayout();
            this.groupBox_formacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Intereses.SuspendLayout();
            this.groupBox_info_personal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(661, 428);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(75, 23);
            this.button_borrar.TabIndex = 25;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(742, 428);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 23;
            this.button_volver.Text = "Cerrar";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // groupBox_observaciones
            // 
            this.groupBox_observaciones.Controls.Add(this.richTextBox1);
            this.groupBox_observaciones.Location = new System.Drawing.Point(422, 308);
            this.groupBox_observaciones.Name = "groupBox_observaciones";
            this.groupBox_observaciones.Size = new System.Drawing.Size(395, 114);
            this.groupBox_observaciones.TabIndex = 21;
            this.groupBox_observaciones.TabStop = false;
            this.groupBox_observaciones.Text = "Observaciones";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(34, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 61);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // groupBox_formacion
            // 
            this.groupBox_formacion.Controls.Add(this.dataGridView1);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_terciario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_universitario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_secundario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_primario);
            this.groupBox_formacion.Controls.Add(this.label_primario);
            this.groupBox_formacion.Controls.Add(this.label_secundaria);
            this.groupBox_formacion.Controls.Add(this.label_universitario);
            this.groupBox_formacion.Controls.Add(this.label_terciario);
            this.groupBox_formacion.Controls.Add(this.label_cursos);
            this.groupBox_formacion.Location = new System.Drawing.Point(422, 10);
            this.groupBox_formacion.Name = "groupBox_formacion";
            this.groupBox_formacion.Size = new System.Drawing.Size(400, 292);
            this.groupBox_formacion.TabIndex = 22;
            this.groupBox_formacion.TabStop = false;
            this.groupBox_formacion.Text = "Formacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 76);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox_opciones_terciario
            // 
            this.comboBox_opciones_terciario.Enabled = false;
            this.comboBox_opciones_terciario.FormattingEnabled = true;
            this.comboBox_opciones_terciario.Items.AddRange(new object[] {
            "Completo",
            "Incompleto ",
            "No"});
            this.comboBox_opciones_terciario.Location = new System.Drawing.Point(175, 76);
            this.comboBox_opciones_terciario.Name = "comboBox_opciones_terciario";
            this.comboBox_opciones_terciario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_terciario.TabIndex = 18;
            // 
            // comboBox_opciones_universitario
            // 
            this.comboBox_opciones_universitario.Enabled = false;
            this.comboBox_opciones_universitario.FormattingEnabled = true;
            this.comboBox_opciones_universitario.Items.AddRange(new object[] {
            "Completo",
            "Incompleto ",
            "No"});
            this.comboBox_opciones_universitario.Location = new System.Drawing.Point(175, 105);
            this.comboBox_opciones_universitario.Name = "comboBox_opciones_universitario";
            this.comboBox_opciones_universitario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_universitario.TabIndex = 17;
            // 
            // comboBox_opciones_secundario
            // 
            this.comboBox_opciones_secundario.Enabled = false;
            this.comboBox_opciones_secundario.FormattingEnabled = true;
            this.comboBox_opciones_secundario.Items.AddRange(new object[] {
            "Completo",
            "No"});
            this.comboBox_opciones_secundario.Location = new System.Drawing.Point(176, 49);
            this.comboBox_opciones_secundario.Name = "comboBox_opciones_secundario";
            this.comboBox_opciones_secundario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_secundario.TabIndex = 16;
            // 
            // comboBox_opciones_primario
            // 
            this.comboBox_opciones_primario.Enabled = false;
            this.comboBox_opciones_primario.FormattingEnabled = true;
            this.comboBox_opciones_primario.Items.AddRange(new object[] {
            "Completo",
            "No"});
            this.comboBox_opciones_primario.Location = new System.Drawing.Point(176, 19);
            this.comboBox_opciones_primario.Name = "comboBox_opciones_primario";
            this.comboBox_opciones_primario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_primario.TabIndex = 15;
            // 
            // label_primario
            // 
            this.label_primario.AutoSize = true;
            this.label_primario.Location = new System.Drawing.Point(121, 22);
            this.label_primario.Name = "label_primario";
            this.label_primario.Size = new System.Drawing.Size(44, 13);
            this.label_primario.TabIndex = 14;
            this.label_primario.Text = "Primario";
            // 
            // label_secundaria
            // 
            this.label_secundaria.AutoSize = true;
            this.label_secundaria.Location = new System.Drawing.Point(104, 52);
            this.label_secundaria.Name = "label_secundaria";
            this.label_secundaria.Size = new System.Drawing.Size(61, 13);
            this.label_secundaria.TabIndex = 12;
            this.label_secundaria.Text = "Secundaria";
            // 
            // label_universitario
            // 
            this.label_universitario.AutoSize = true;
            this.label_universitario.Location = new System.Drawing.Point(104, 108);
            this.label_universitario.Name = "label_universitario";
            this.label_universitario.Size = new System.Drawing.Size(65, 13);
            this.label_universitario.TabIndex = 12;
            this.label_universitario.Text = "Universitario";
            // 
            // label_terciario
            // 
            this.label_terciario.AutoSize = true;
            this.label_terciario.Location = new System.Drawing.Point(121, 79);
            this.label_terciario.Name = "label_terciario";
            this.label_terciario.Size = new System.Drawing.Size(48, 13);
            this.label_terciario.TabIndex = 13;
            this.label_terciario.Text = "Terciario";
            // 
            // label_cursos
            // 
            this.label_cursos.AutoSize = true;
            this.label_cursos.Location = new System.Drawing.Point(20, 148);
            this.label_cursos.Name = "label_cursos";
            this.label_cursos.Size = new System.Drawing.Size(117, 13);
            this.label_cursos.TabIndex = 6;
            this.label_cursos.Text = "Cursos/Capacitaciones";
            // 
            // groupBox_Intereses
            // 
            this.groupBox_Intereses.Controls.Add(this.richTextBox_intereses);
            this.groupBox_Intereses.Location = new System.Drawing.Point(12, 308);
            this.groupBox_Intereses.Name = "groupBox_Intereses";
            this.groupBox_Intereses.Size = new System.Drawing.Size(395, 114);
            this.groupBox_Intereses.TabIndex = 20;
            this.groupBox_Intereses.TabStop = false;
            this.groupBox_Intereses.Text = "Intereses";
            // 
            // richTextBox_intereses
            // 
            this.richTextBox_intereses.Enabled = false;
            this.richTextBox_intereses.Location = new System.Drawing.Point(34, 27);
            this.richTextBox_intereses.Name = "richTextBox_intereses";
            this.richTextBox_intereses.Size = new System.Drawing.Size(326, 61);
            this.richTextBox_intereses.TabIndex = 6;
            this.richTextBox_intereses.Text = "";
            // 
            // groupBox_info_personal
            // 
            this.groupBox_info_personal.Controls.Add(this.comboBox1);
            this.groupBox_info_personal.Controls.Add(this.textBox5);
            this.groupBox_info_personal.Controls.Add(this.textBox6);
            this.groupBox_info_personal.Controls.Add(this.textBox4);
            this.groupBox_info_personal.Controls.Add(this.textBox3);
            this.groupBox_info_personal.Controls.Add(this.textBox2);
            this.groupBox_info_personal.Controls.Add(this.textBox1);
            this.groupBox_info_personal.Controls.Add(this.dateTimePicker1);
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
            this.groupBox_info_personal.TabIndex = 18;
            this.groupBox_info_personal.TabStop = false;
            this.groupBox_info_personal.Text = "Informacion personal";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(153, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(206, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(153, 111);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(153, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(153, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(153, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(153, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
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
            // label_primaria
            // 
            this.label_primaria.AutoSize = true;
            this.label_primaria.Location = new System.Drawing.Point(476, 251);
            this.label_primaria.Name = "label_primaria";
            this.label_primaria.Size = new System.Drawing.Size(44, 13);
            this.label_primaria.TabIndex = 19;
            this.label_primaria.Text = "Primaria";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox_observaciones);
            this.Controls.Add(this.groupBox_formacion);
            this.Controls.Add(this.groupBox_Intereses);
            this.Controls.Add(this.groupBox_info_personal);
            this.Controls.Add(this.label_primaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja";
            this.groupBox_observaciones.ResumeLayout(false);
            this.groupBox_formacion.ResumeLayout(false);
            this.groupBox_formacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Intereses.ResumeLayout(false);
            this.groupBox_info_personal.ResumeLayout(false);
            this.groupBox_info_personal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.GroupBox groupBox_observaciones;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox_formacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_opciones_terciario;
        private System.Windows.Forms.ComboBox comboBox_opciones_universitario;
        private System.Windows.Forms.ComboBox comboBox_opciones_secundario;
        private System.Windows.Forms.ComboBox comboBox_opciones_primario;
        private System.Windows.Forms.Label label_primario;
        private System.Windows.Forms.Label label_secundaria;
        private System.Windows.Forms.Label label_universitario;
        private System.Windows.Forms.Label label_terciario;
        private System.Windows.Forms.Label label_cursos;
        private System.Windows.Forms.GroupBox groupBox_Intereses;
        private System.Windows.Forms.RichTextBox richTextBox_intereses;
        private System.Windows.Forms.GroupBox groupBox_info_personal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_cuit_cuil;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_fecha_nac;
        private System.Windows.Forms.Label label_barrio;
        private System.Windows.Forms.Label label_primaria;
    }
}