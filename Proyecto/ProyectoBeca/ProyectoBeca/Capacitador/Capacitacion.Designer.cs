namespace ProyectoBeca.Capacitador
{
    partial class Capacitacion
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
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox_areas_posibles = new System.Windows.Forms.GroupBox();
            this.dataGridView_areas_capacitacion = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_areas_posibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_areas_capacitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(537, 253);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 4;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // groupBox_areas_posibles
            // 
            this.groupBox_areas_posibles.Controls.Add(this.dataGridView_areas_capacitacion);
            this.groupBox_areas_posibles.Location = new System.Drawing.Point(12, 9);
            this.groupBox_areas_posibles.Name = "groupBox_areas_posibles";
            this.groupBox_areas_posibles.Size = new System.Drawing.Size(600, 238);
            this.groupBox_areas_posibles.TabIndex = 3;
            this.groupBox_areas_posibles.TabStop = false;
            this.groupBox_areas_posibles.Text = "Areas posibles";
            // 
            // dataGridView_areas_capacitacion
            // 
            this.dataGridView_areas_capacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_areas_capacitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area,
            this.Seleccionar});
            this.dataGridView_areas_capacitacion.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_areas_capacitacion.Name = "dataGridView_areas_capacitacion";
            this.dataGridView_areas_capacitacion.Size = new System.Drawing.Size(588, 205);
            this.dataGridView_areas_capacitacion.TabIndex = 0;
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
            // Capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 285);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox_areas_posibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Capacitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areas de capacitacion";
            this.groupBox_areas_posibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_areas_capacitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.GroupBox groupBox_areas_posibles;
        private System.Windows.Forms.DataGridView dataGridView_areas_capacitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}