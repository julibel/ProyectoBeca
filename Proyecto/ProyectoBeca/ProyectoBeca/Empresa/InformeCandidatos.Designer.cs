namespace ProyectoBeca.Empresa
{
    partial class InformeCandidatos
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
            this.groupBox_Filtros = new System.Windows.Forms.GroupBox();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.comboBox_barrio = new System.Windows.Forms.ComboBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.label_entre = new System.Windows.Forms.Label();
            this.numericUpDown_edad_hasta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_edad_desde = new System.Windows.Forms.NumericUpDown();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.label_barrio = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.groupBox_info_empresa = new System.Windows.Forms.GroupBox();
            this.button_validar = new System.Windows.Forms.Button();
            this.textBox_razon_social = new System.Windows.Forms.TextBox();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.groupBox_formacion = new System.Windows.Forms.GroupBox();
            this.comboBox_opciones_terciario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_universitario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_secundario = new System.Windows.Forms.ComboBox();
            this.comboBox_opciones_primario = new System.Windows.Forms.ComboBox();
            this.label_primario = new System.Windows.Forms.Label();
            this.label_secundaria = new System.Windows.Forms.Label();
            this.label_universitario = new System.Windows.Forms.Label();
            this.label_terciario = new System.Windows.Forms.Label();
            this.dataGridView_informe = new System.Windows.Forms.DataGridView();
            this.groupBox_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad_desde)).BeginInit();
            this.groupBox_info_empresa.SuspendLayout();
            this.groupBox_formacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_informe)).BeginInit();
            this.SuspendLayout();
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(665, 420);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 32;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(584, 420);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 31;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(746, 420);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 30;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_Filtros
            // 
            this.groupBox_Filtros.Controls.Add(this.button_filtrar);
            this.groupBox_Filtros.Controls.Add(this.comboBox_barrio);
            this.groupBox_Filtros.Controls.Add(this.label_edad);
            this.groupBox_Filtros.Controls.Add(this.label_entre);
            this.groupBox_Filtros.Controls.Add(this.numericUpDown_edad_hasta);
            this.groupBox_Filtros.Controls.Add(this.numericUpDown_edad_desde);
            this.groupBox_Filtros.Controls.Add(this.comboBox_area);
            this.groupBox_Filtros.Controls.Add(this.label_barrio);
            this.groupBox_Filtros.Controls.Add(this.label_area);
            this.groupBox_Filtros.Location = new System.Drawing.Point(13, 123);
            this.groupBox_Filtros.Name = "groupBox_Filtros";
            this.groupBox_Filtros.Size = new System.Drawing.Size(395, 304);
            this.groupBox_Filtros.TabIndex = 29;
            this.groupBox_Filtros.TabStop = false;
            this.groupBox_Filtros.Text = "Filtros";
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(314, 275);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(75, 23);
            this.button_filtrar.TabIndex = 35;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            // 
            // comboBox_barrio
            // 
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
            this.comboBox_barrio.Location = new System.Drawing.Point(118, 67);
            this.comboBox_barrio.Name = "comboBox_barrio";
            this.comboBox_barrio.Size = new System.Drawing.Size(200, 21);
            this.comboBox_barrio.TabIndex = 35;
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(78, 94);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(32, 13);
            this.label_edad.TabIndex = 41;
            this.label_edad.Text = "Edad";
            // 
            // label_entre
            // 
            this.label_entre.AutoSize = true;
            this.label_entre.Location = new System.Drawing.Point(171, 94);
            this.label_entre.Name = "label_entre";
            this.label_entre.Size = new System.Drawing.Size(10, 13);
            this.label_entre.TabIndex = 40;
            this.label_entre.Text = "-";
            // 
            // numericUpDown_edad_hasta
            // 
            this.numericUpDown_edad_hasta.Location = new System.Drawing.Point(187, 94);
            this.numericUpDown_edad_hasta.Name = "numericUpDown_edad_hasta";
            this.numericUpDown_edad_hasta.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_edad_hasta.TabIndex = 39;
            // 
            // numericUpDown_edad_desde
            // 
            this.numericUpDown_edad_desde.Location = new System.Drawing.Point(118, 94);
            this.numericUpDown_edad_desde.Name = "numericUpDown_edad_desde";
            this.numericUpDown_edad_desde.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_edad_desde.TabIndex = 38;
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
            this.comboBox_area.Location = new System.Drawing.Point(118, 40);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(200, 21);
            this.comboBox_area.TabIndex = 37;
            // 
            // label_barrio
            // 
            this.label_barrio.AutoSize = true;
            this.label_barrio.Location = new System.Drawing.Point(76, 70);
            this.label_barrio.Name = "label_barrio";
            this.label_barrio.Size = new System.Drawing.Size(34, 13);
            this.label_barrio.TabIndex = 33;
            this.label_barrio.Text = "Barrio";
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(81, 43);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(29, 13);
            this.label_area.TabIndex = 36;
            this.label_area.Text = "Area";
            // 
            // groupBox_info_empresa
            // 
            this.groupBox_info_empresa.Controls.Add(this.button_validar);
            this.groupBox_info_empresa.Controls.Add(this.textBox_razon_social);
            this.groupBox_info_empresa.Controls.Add(this.label_razon_social);
            this.groupBox_info_empresa.Location = new System.Drawing.Point(14, 18);
            this.groupBox_info_empresa.Name = "groupBox_info_empresa";
            this.groupBox_info_empresa.Size = new System.Drawing.Size(395, 102);
            this.groupBox_info_empresa.TabIndex = 27;
            this.groupBox_info_empresa.TabStop = false;
            this.groupBox_info_empresa.Text = "Informacion de la empresa";
            // 
            // button_validar
            // 
            this.button_validar.Location = new System.Drawing.Point(314, 73);
            this.button_validar.Name = "button_validar";
            this.button_validar.Size = new System.Drawing.Size(75, 23);
            this.button_validar.TabIndex = 33;
            this.button_validar.Text = "Validar";
            this.button_validar.UseVisualStyleBackColor = true;
            // 
            // textBox_razon_social
            // 
            this.textBox_razon_social.Location = new System.Drawing.Point(137, 35);
            this.textBox_razon_social.Name = "textBox_razon_social";
            this.textBox_razon_social.Size = new System.Drawing.Size(200, 20);
            this.textBox_razon_social.TabIndex = 12;
            this.textBox_razon_social.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Location = new System.Drawing.Point(63, 38);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(68, 13);
            this.label_razon_social.TabIndex = 0;
            this.label_razon_social.Text = "Razon social";
            // 
            // groupBox_formacion
            // 
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_terciario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_universitario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_secundario);
            this.groupBox_formacion.Controls.Add(this.comboBox_opciones_primario);
            this.groupBox_formacion.Controls.Add(this.label_primario);
            this.groupBox_formacion.Controls.Add(this.label_secundaria);
            this.groupBox_formacion.Controls.Add(this.label_universitario);
            this.groupBox_formacion.Controls.Add(this.label_terciario);
            this.groupBox_formacion.Location = new System.Drawing.Point(19, 243);
            this.groupBox_formacion.Name = "groupBox_formacion";
            this.groupBox_formacion.Size = new System.Drawing.Size(384, 150);
            this.groupBox_formacion.TabIndex = 34;
            this.groupBox_formacion.TabStop = false;
            this.groupBox_formacion.Text = "Formacion";
            // 
            // comboBox_opciones_terciario
            // 
            this.comboBox_opciones_terciario.FormattingEnabled = true;
            this.comboBox_opciones_terciario.Items.AddRange(new object[] {
            "Completo",
            "Incompleto",
            "No"});
            this.comboBox_opciones_terciario.Location = new System.Drawing.Point(168, 81);
            this.comboBox_opciones_terciario.Name = "comboBox_opciones_terciario";
            this.comboBox_opciones_terciario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_terciario.TabIndex = 18;
            // 
            // comboBox_opciones_universitario
            // 
            this.comboBox_opciones_universitario.FormattingEnabled = true;
            this.comboBox_opciones_universitario.Items.AddRange(new object[] {
            "Completo",
            "Incompleto",
            "No"});
            this.comboBox_opciones_universitario.Location = new System.Drawing.Point(167, 108);
            this.comboBox_opciones_universitario.Name = "comboBox_opciones_universitario";
            this.comboBox_opciones_universitario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_universitario.TabIndex = 17;
            // 
            // comboBox_opciones_secundario
            // 
            this.comboBox_opciones_secundario.FormattingEnabled = true;
            this.comboBox_opciones_secundario.Items.AddRange(new object[] {
            "Completo",
            "No"});
            this.comboBox_opciones_secundario.Location = new System.Drawing.Point(168, 52);
            this.comboBox_opciones_secundario.Name = "comboBox_opciones_secundario";
            this.comboBox_opciones_secundario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_secundario.TabIndex = 16;
            // 
            // comboBox_opciones_primario
            // 
            this.comboBox_opciones_primario.FormattingEnabled = true;
            this.comboBox_opciones_primario.Items.AddRange(new object[] {
            "Completo",
            "No"});
            this.comboBox_opciones_primario.Location = new System.Drawing.Point(168, 22);
            this.comboBox_opciones_primario.Name = "comboBox_opciones_primario";
            this.comboBox_opciones_primario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_opciones_primario.TabIndex = 15;
            // 
            // label_primario
            // 
            this.label_primario.AutoSize = true;
            this.label_primario.Location = new System.Drawing.Point(113, 25);
            this.label_primario.Name = "label_primario";
            this.label_primario.Size = new System.Drawing.Size(44, 13);
            this.label_primario.TabIndex = 14;
            this.label_primario.Text = "Primario";
            // 
            // label_secundaria
            // 
            this.label_secundaria.AutoSize = true;
            this.label_secundaria.Location = new System.Drawing.Point(100, 55);
            this.label_secundaria.Name = "label_secundaria";
            this.label_secundaria.Size = new System.Drawing.Size(61, 13);
            this.label_secundaria.TabIndex = 12;
            this.label_secundaria.Text = "Secundaria";
            // 
            // label_universitario
            // 
            this.label_universitario.AutoSize = true;
            this.label_universitario.Location = new System.Drawing.Point(96, 111);
            this.label_universitario.Name = "label_universitario";
            this.label_universitario.Size = new System.Drawing.Size(65, 13);
            this.label_universitario.TabIndex = 12;
            this.label_universitario.Text = "Universitario";
            // 
            // label_terciario
            // 
            this.label_terciario.AutoSize = true;
            this.label_terciario.Location = new System.Drawing.Point(113, 82);
            this.label_terciario.Name = "label_terciario";
            this.label_terciario.Size = new System.Drawing.Size(48, 13);
            this.label_terciario.TabIndex = 13;
            this.label_terciario.Text = "Terciario";
            // 
            // dataGridView_informe
            // 
            this.dataGridView_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_informe.Location = new System.Drawing.Point(426, 29);
            this.dataGridView_informe.Name = "dataGridView_informe";
            this.dataGridView_informe.Size = new System.Drawing.Size(395, 374);
            this.dataGridView_informe.TabIndex = 35;
            // 
            // InformeCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dataGridView_informe);
            this.Controls.Add(this.groupBox_formacion);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_Filtros);
            this.Controls.Add(this.groupBox_info_empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformeCandidatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeCandidatos";
            this.Load += new System.EventHandler(this.InformeCandidatos_Load);
            this.groupBox_Filtros.ResumeLayout(false);
            this.groupBox_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edad_desde)).EndInit();
            this.groupBox_info_empresa.ResumeLayout(false);
            this.groupBox_info_empresa.PerformLayout();
            this.groupBox_formacion.ResumeLayout(false);
            this.groupBox_formacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_informe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_Filtros;
        private System.Windows.Forms.GroupBox groupBox_info_empresa;
        private System.Windows.Forms.Button button_validar;
        private System.Windows.Forms.TextBox textBox_razon_social;
        private System.Windows.Forms.Label label_razon_social;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label_entre;
        private System.Windows.Forms.NumericUpDown numericUpDown_edad_hasta;
        private System.Windows.Forms.NumericUpDown numericUpDown_edad_desde;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.Label label_barrio;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.ComboBox comboBox_barrio;
        private System.Windows.Forms.GroupBox groupBox_formacion;
        private System.Windows.Forms.ComboBox comboBox_opciones_universitario;
        private System.Windows.Forms.ComboBox comboBox_opciones_secundario;
        private System.Windows.Forms.ComboBox comboBox_opciones_primario;
        private System.Windows.Forms.Label label_primario;
        private System.Windows.Forms.Label label_secundaria;
        private System.Windows.Forms.Label label_universitario;
        private System.Windows.Forms.Label label_terciario;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.ComboBox comboBox_opciones_terciario;
        private System.Windows.Forms.DataGridView dataGridView_informe;
    }
}