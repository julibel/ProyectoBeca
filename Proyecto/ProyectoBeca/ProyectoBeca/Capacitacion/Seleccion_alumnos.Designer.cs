namespace ProyectoBeca.Capacitacion
{
    partial class Seleccion_alumnos
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
            this.groupBox_alumnos = new System.Windows.Forms.GroupBox();
            this.dataGridView_seleccion_alumnos = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox_alumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_alumnos
            // 
            this.groupBox_alumnos.Controls.Add(this.dataGridView_seleccion_alumnos);
            this.groupBox_alumnos.Location = new System.Drawing.Point(12, 9);
            this.groupBox_alumnos.Name = "groupBox_alumnos";
            this.groupBox_alumnos.Size = new System.Drawing.Size(600, 238);
            this.groupBox_alumnos.TabIndex = 3;
            this.groupBox_alumnos.TabStop = false;
            this.groupBox_alumnos.Text = "Seleccionar alumnos";
            // 
            // dataGridView_seleccion_alumnos
            // 
            this.dataGridView_seleccion_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seleccion_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area,
            this.Seleccionar});
            this.dataGridView_seleccion_alumnos.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_seleccion_alumnos.Name = "dataGridView_seleccion_alumnos";
            this.dataGridView_seleccion_alumnos.Size = new System.Drawing.Size(588, 205);
            this.dataGridView_seleccion_alumnos.TabIndex = 0;
            this.dataGridView_seleccion_alumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Seleccion_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 285);
            this.Controls.Add(this.groupBox_alumnos);
            this.Controls.Add(this.button_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Seleccion_alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de alumnos";
            this.groupBox_alumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_alumnos;
        private System.Windows.Forms.DataGridView dataGridView_seleccion_alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button button_volver;
    }
}