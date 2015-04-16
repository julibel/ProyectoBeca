namespace ProyectoBeca.Capacitacion
{
    partial class Seleccion_profesor
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
            this.groupBox_profesores = new System.Windows.Forms.GroupBox();
            this.dataGridView_seleccion_profesor = new System.Windows.Forms.DataGridView();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.groupBox_profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_profesor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_profesores
            // 
            this.groupBox_profesores.Controls.Add(this.dataGridView_seleccion_profesor);
            this.groupBox_profesores.Location = new System.Drawing.Point(12, 9);
            this.groupBox_profesores.Name = "groupBox_profesores";
            this.groupBox_profesores.Size = new System.Drawing.Size(600, 238);
            this.groupBox_profesores.TabIndex = 5;
            this.groupBox_profesores.TabStop = false;
            this.groupBox_profesores.Text = "Profesores";
            // 
            // dataGridView_seleccion_profesor
            // 
            this.dataGridView_seleccion_profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seleccion_profesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area,
            this.Seleccionar});
            this.dataGridView_seleccion_profesor.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_seleccion_profesor.Name = "dataGridView_seleccion_profesor";
            this.dataGridView_seleccion_profesor.Size = new System.Drawing.Size(588, 205);
            this.dataGridView_seleccion_profesor.TabIndex = 0;
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
            this.button_volver.TabIndex = 6;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Seleccion_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 285);
            this.Controls.Add(this.groupBox_profesores);
            this.Controls.Add(this.button_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Seleccion_profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion del profesor";
            this.groupBox_profesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_profesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_profesores;
        private System.Windows.Forms.DataGridView dataGridView_seleccion_profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button button_volver;
    }
}