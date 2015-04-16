namespace ProyectoBeca.Candidato
{
    partial class Cursos_capacitaciones
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
            this.dataGridView_cursos_capacitaciones = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_areas_posibles = new System.Windows.Forms.GroupBox();
            this.button_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos_capacitaciones)).BeginInit();
            this.groupBox_areas_posibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_cursos_capacitaciones
            // 
            this.dataGridView_cursos_capacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cursos_capacitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area,
            this.Seleccionar});
            this.dataGridView_cursos_capacitaciones.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_cursos_capacitaciones.Name = "dataGridView_cursos_capacitaciones";
            this.dataGridView_cursos_capacitaciones.Size = new System.Drawing.Size(588, 205);
            this.dataGridView_cursos_capacitaciones.TabIndex = 0;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Agregar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // groupBox_areas_posibles
            // 
            this.groupBox_areas_posibles.Controls.Add(this.dataGridView_cursos_capacitaciones);
            this.groupBox_areas_posibles.Location = new System.Drawing.Point(12, 12);
            this.groupBox_areas_posibles.Name = "groupBox_areas_posibles";
            this.groupBox_areas_posibles.Size = new System.Drawing.Size(600, 238);
            this.groupBox_areas_posibles.TabIndex = 1;
            this.groupBox_areas_posibles.TabStop = false;
            this.groupBox_areas_posibles.Text = "Areas posibles";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(537, 256);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 2;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Cursos_capacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 285);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox_areas_posibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cursos_capacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos y capacitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos_capacitaciones)).EndInit();
            this.groupBox_areas_posibles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cursos_capacitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.GroupBox groupBox_areas_posibles;
        private System.Windows.Forms.Button button_volver;
    }
}