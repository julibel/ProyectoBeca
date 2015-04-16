namespace ProyectoBeca.Capacitacion
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
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_alumnos = new System.Windows.Forms.GroupBox();
            this.button_modificar_alumnos = new System.Windows.Forms.Button();
            this.dataGridView_alumnos = new System.Windows.Forms.DataGridView();
            this.groupBox_profesor = new System.Windows.Forms.GroupBox();
            this.button_seleccionar = new System.Windows.Forms.Button();
            this.textBox_profesor = new System.Windows.Forms.TextBox();
            this.groupBox_capacitacion = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label_fecha = new System.Windows.Forms.Label();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.label_area = new System.Windows.Forms.Label();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.groupBox_estado = new System.Windows.Forms.GroupBox();
            this.radioButton_verificado = new System.Windows.Forms.RadioButton();
            this.radioButton_verificando = new System.Windows.Forms.RadioButton();
            this.radioButton_sin_verificar = new System.Windows.Forms.RadioButton();
            this.groupBox_alumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alumnos)).BeginInit();
            this.groupBox_profesor.SuspendLayout();
            this.groupBox_capacitacion.SuspendLayout();
            this.groupBox_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(661, 428);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 24;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(580, 428);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 23;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(742, 428);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 22;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_alumnos
            // 
            this.groupBox_alumnos.Controls.Add(this.button_modificar_alumnos);
            this.groupBox_alumnos.Controls.Add(this.dataGridView_alumnos);
            this.groupBox_alumnos.Location = new System.Drawing.Point(422, 10);
            this.groupBox_alumnos.Name = "groupBox_alumnos";
            this.groupBox_alumnos.Size = new System.Drawing.Size(400, 412);
            this.groupBox_alumnos.TabIndex = 21;
            this.groupBox_alumnos.TabStop = false;
            this.groupBox_alumnos.Text = "Alumnos";
            // 
            // button_modificar_alumnos
            // 
            this.button_modificar_alumnos.Location = new System.Drawing.Point(23, 19);
            this.button_modificar_alumnos.Name = "button_modificar_alumnos";
            this.button_modificar_alumnos.Size = new System.Drawing.Size(358, 23);
            this.button_modificar_alumnos.TabIndex = 20;
            this.button_modificar_alumnos.Text = "Modificar lista de alumnos";
            this.button_modificar_alumnos.UseVisualStyleBackColor = true;
            this.button_modificar_alumnos.Click += new System.EventHandler(this.button_modificar_alumnos_Click);
            // 
            // dataGridView_alumnos
            // 
            this.dataGridView_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alumnos.Location = new System.Drawing.Point(23, 48);
            this.dataGridView_alumnos.Name = "dataGridView_alumnos";
            this.dataGridView_alumnos.Size = new System.Drawing.Size(358, 351);
            this.dataGridView_alumnos.TabIndex = 19;
            // 
            // groupBox_profesor
            // 
            this.groupBox_profesor.Controls.Add(this.button_seleccionar);
            this.groupBox_profesor.Controls.Add(this.textBox_profesor);
            this.groupBox_profesor.Location = new System.Drawing.Point(37, 152);
            this.groupBox_profesor.Name = "groupBox_profesor";
            this.groupBox_profesor.Size = new System.Drawing.Size(321, 74);
            this.groupBox_profesor.TabIndex = 19;
            this.groupBox_profesor.TabStop = false;
            this.groupBox_profesor.Text = "Profesor";
            // 
            // button_seleccionar
            // 
            this.button_seleccionar.Location = new System.Drawing.Point(226, 26);
            this.button_seleccionar.Name = "button_seleccionar";
            this.button_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_seleccionar.TabIndex = 26;
            this.button_seleccionar.Text = "Seleccionar";
            this.button_seleccionar.UseVisualStyleBackColor = true;
            this.button_seleccionar.Click += new System.EventHandler(this.button_seleccionar_Click);
            // 
            // textBox_profesor
            // 
            this.textBox_profesor.Location = new System.Drawing.Point(20, 28);
            this.textBox_profesor.Name = "textBox_profesor";
            this.textBox_profesor.Size = new System.Drawing.Size(200, 20);
            this.textBox_profesor.TabIndex = 41;
            // 
            // groupBox_capacitacion
            // 
            this.groupBox_capacitacion.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox_capacitacion.Controls.Add(this.label_fecha);
            this.groupBox_capacitacion.Controls.Add(this.comboBox_area);
            this.groupBox_capacitacion.Controls.Add(this.label_area);
            this.groupBox_capacitacion.Controls.Add(this.textBox_titulo);
            this.groupBox_capacitacion.Controls.Add(this.label_titulo);
            this.groupBox_capacitacion.Controls.Add(this.groupBox_profesor);
            this.groupBox_capacitacion.Location = new System.Drawing.Point(12, 10);
            this.groupBox_capacitacion.Name = "groupBox_capacitacion";
            this.groupBox_capacitacion.Size = new System.Drawing.Size(395, 292);
            this.groupBox_capacitacion.TabIndex = 18;
            this.groupBox_capacitacion.TabStop = false;
            this.groupBox_capacitacion.Text = "Capacitacion";
            // 
            // dateTimePicker_fecha
            // 
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
            this.textBox_titulo.Location = new System.Drawing.Point(117, 66);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(200, 20);
            this.textBox_titulo.TabIndex = 12;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(78, 69);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(33, 13);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Titulo";
            // 
            // groupBox_estado
            // 
            this.groupBox_estado.Controls.Add(this.radioButton_verificado);
            this.groupBox_estado.Controls.Add(this.radioButton_verificando);
            this.groupBox_estado.Controls.Add(this.radioButton_sin_verificar);
            this.groupBox_estado.Location = new System.Drawing.Point(12, 308);
            this.groupBox_estado.Name = "groupBox_estado";
            this.groupBox_estado.Size = new System.Drawing.Size(395, 114);
            this.groupBox_estado.TabIndex = 25;
            this.groupBox_estado.TabStop = false;
            this.groupBox_estado.Text = "Estado";
            // 
            // radioButton_verificado
            // 
            this.radioButton_verificado.AutoSize = true;
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
            this.radioButton_sin_verificar.Location = new System.Drawing.Point(158, 26);
            this.radioButton_sin_verificar.Name = "radioButton_sin_verificar";
            this.radioButton_sin_verificar.Size = new System.Drawing.Size(80, 17);
            this.radioButton_sin_verificar.TabIndex = 0;
            this.radioButton_sin_verificar.TabStop = true;
            this.radioButton_sin_verificar.Text = "Sin verificar";
            this.radioButton_sin_verificar.UseVisualStyleBackColor = true;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox_estado);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_alumnos);
            this.Controls.Add(this.groupBox_capacitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.groupBox_alumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alumnos)).EndInit();
            this.groupBox_profesor.ResumeLayout(false);
            this.groupBox_profesor.PerformLayout();
            this.groupBox_capacitacion.ResumeLayout(false);
            this.groupBox_capacitacion.PerformLayout();
            this.groupBox_estado.ResumeLayout(false);
            this.groupBox_estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_alumnos;
        private System.Windows.Forms.DataGridView dataGridView_alumnos;
        private System.Windows.Forms.GroupBox groupBox_profesor;
        private System.Windows.Forms.GroupBox groupBox_capacitacion;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.GroupBox groupBox_estado;
        private System.Windows.Forms.RadioButton radioButton_verificado;
        private System.Windows.Forms.RadioButton radioButton_verificando;
        private System.Windows.Forms.RadioButton radioButton_sin_verificar;
        private System.Windows.Forms.Button button_seleccionar;
        private System.Windows.Forms.TextBox textBox_profesor;
        private System.Windows.Forms.Button button_modificar_alumnos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label_fecha;


    }
}