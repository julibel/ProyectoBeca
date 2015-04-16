namespace ProyectoBeca.Capacitacion
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
            this.groupBox_estado = new System.Windows.Forms.GroupBox();
            this.radioButton_verificado = new System.Windows.Forms.RadioButton();
            this.radioButton_verificando = new System.Windows.Forms.RadioButton();
            this.radioButton_sin_verificar = new System.Windows.Forms.RadioButton();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_alumnos = new System.Windows.Forms.GroupBox();
            this.dataGridView_alumnos = new System.Windows.Forms.DataGridView();
            this.groupBox_capacitacion = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label_fecha = new System.Windows.Forms.Label();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.label_area = new System.Windows.Forms.Label();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.groupBox_profesor = new System.Windows.Forms.GroupBox();
            this.textBox_profesor = new System.Windows.Forms.TextBox();
            this.groupBox_estado.SuspendLayout();
            this.groupBox_alumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alumnos)).BeginInit();
            this.groupBox_capacitacion.SuspendLayout();
            this.groupBox_profesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_estado
            // 
            this.groupBox_estado.Controls.Add(this.radioButton_verificado);
            this.groupBox_estado.Controls.Add(this.radioButton_verificando);
            this.groupBox_estado.Controls.Add(this.radioButton_sin_verificar);
            this.groupBox_estado.Location = new System.Drawing.Point(12, 308);
            this.groupBox_estado.Name = "groupBox_estado";
            this.groupBox_estado.Size = new System.Drawing.Size(395, 114);
            this.groupBox_estado.TabIndex = 31;
            this.groupBox_estado.TabStop = false;
            this.groupBox_estado.Text = "Estado";
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
            // radioButton_sin_verificar
            // 
            this.radioButton_sin_verificar.AutoSize = true;
            this.radioButton_sin_verificar.Enabled = false;
            this.radioButton_sin_verificar.Location = new System.Drawing.Point(158, 26);
            this.radioButton_sin_verificar.Name = "radioButton_sin_verificar";
            this.radioButton_sin_verificar.Size = new System.Drawing.Size(80, 17);
            this.radioButton_sin_verificar.TabIndex = 0;
            this.radioButton_sin_verificar.TabStop = true;
            this.radioButton_sin_verificar.Text = "Sin verificar";
            this.radioButton_sin_verificar.UseVisualStyleBackColor = true;
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(661, 428);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(75, 23);
            this.button_borrar.TabIndex = 30;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
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
            // groupBox_alumnos
            // 
            this.groupBox_alumnos.Controls.Add(this.dataGridView_alumnos);
            this.groupBox_alumnos.Location = new System.Drawing.Point(422, 10);
            this.groupBox_alumnos.Name = "groupBox_alumnos";
            this.groupBox_alumnos.Size = new System.Drawing.Size(400, 412);
            this.groupBox_alumnos.TabIndex = 27;
            this.groupBox_alumnos.TabStop = false;
            this.groupBox_alumnos.Text = "Alumnos";
            this.groupBox_alumnos.Enter += new System.EventHandler(this.groupBox_formacion_Enter);
            // 
            // dataGridView_alumnos
            // 
            this.dataGridView_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alumnos.Enabled = false;
            this.dataGridView_alumnos.Location = new System.Drawing.Point(23, 19);
            this.dataGridView_alumnos.Name = "dataGridView_alumnos";
            this.dataGridView_alumnos.Size = new System.Drawing.Size(358, 380);
            this.dataGridView_alumnos.TabIndex = 19;
            // 
            // groupBox_capacitacion
            // 
            this.groupBox_capacitacion.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox_capacitacion.Controls.Add(this.label_fecha);
            this.groupBox_capacitacion.Controls.Add(this.comboBox_area);
            this.groupBox_capacitacion.Controls.Add(this.label_area);
            this.groupBox_capacitacion.Controls.Add(this.textBox_titulo);
            this.groupBox_capacitacion.Controls.Add(this.label_nombre);
            this.groupBox_capacitacion.Controls.Add(this.groupBox_profesor);
            this.groupBox_capacitacion.Location = new System.Drawing.Point(12, 10);
            this.groupBox_capacitacion.Name = "groupBox_capacitacion";
            this.groupBox_capacitacion.Size = new System.Drawing.Size(395, 292);
            this.groupBox_capacitacion.TabIndex = 26;
            this.groupBox_capacitacion.TabStop = false;
            this.groupBox_capacitacion.Text = "Capacitacion";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Enabled = false;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(117, 119);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fecha.TabIndex = 41;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(74, 124);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(37, 13);
            this.label_fecha.TabIndex = 40;
            this.label_fecha.Text = "Fecha";
            // 
            // comboBox_area
            // 
            this.comboBox_area.Enabled = false;
            this.comboBox_area.Items.AddRange(new object[] {
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
            this.comboBox_area.Location = new System.Drawing.Point(117, 92);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(200, 21);
            this.comboBox_area.TabIndex = 39;
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(80, 95);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(29, 13);
            this.label_area.TabIndex = 38;
            this.label_area.Text = "Area";
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.Enabled = false;
            this.textBox_titulo.Location = new System.Drawing.Point(117, 66);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(200, 20);
            this.textBox_titulo.TabIndex = 12;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(78, 69);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(33, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Titulo";
            // 
            // groupBox_profesor
            // 
            this.groupBox_profesor.Controls.Add(this.textBox_profesor);
            this.groupBox_profesor.Location = new System.Drawing.Point(37, 152);
            this.groupBox_profesor.Name = "groupBox_profesor";
            this.groupBox_profesor.Size = new System.Drawing.Size(321, 74);
            this.groupBox_profesor.TabIndex = 19;
            this.groupBox_profesor.TabStop = false;
            this.groupBox_profesor.Text = "Profesor";
            // 
            // textBox_profesor
            // 
            this.textBox_profesor.Enabled = false;
            this.textBox_profesor.Location = new System.Drawing.Point(60, 27);
            this.textBox_profesor.Name = "textBox_profesor";
            this.textBox_profesor.Size = new System.Drawing.Size(200, 20);
            this.textBox_profesor.TabIndex = 41;
            this.textBox_profesor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.Controls.Add(this.groupBox_alumnos);
            this.Controls.Add(this.groupBox_capacitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja";
            this.groupBox_estado.ResumeLayout(false);
            this.groupBox_estado.PerformLayout();
            this.groupBox_alumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alumnos)).EndInit();
            this.groupBox_capacitacion.ResumeLayout(false);
            this.groupBox_capacitacion.PerformLayout();
            this.groupBox_profesor.ResumeLayout(false);
            this.groupBox_profesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_estado;
        private System.Windows.Forms.RadioButton radioButton_verificado;
        private System.Windows.Forms.RadioButton radioButton_verificando;
        private System.Windows.Forms.RadioButton radioButton_sin_verificar;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_alumnos;
        private System.Windows.Forms.DataGridView dataGridView_alumnos;
        private System.Windows.Forms.GroupBox groupBox_capacitacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.GroupBox groupBox_profesor;
        private System.Windows.Forms.TextBox textBox_profesor;
    }
}