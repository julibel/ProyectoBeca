namespace ProyectoBeca.Capacitacion
{
    partial class Seleccion
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
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_Seleccion = new System.Windows.Forms.GroupBox();
            this.dataGridView_seleccion_capacitacion = new System.Windows.Forms.DataGridView();
            this.groupBox_Seleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_capacitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 5;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_Seleccion
            // 
            this.groupBox_Seleccion.Controls.Add(this.dataGridView_seleccion_capacitacion);
            this.groupBox_Seleccion.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Seleccion.Name = "groupBox_Seleccion";
            this.groupBox_Seleccion.Size = new System.Drawing.Size(810, 401);
            this.groupBox_Seleccion.TabIndex = 4;
            this.groupBox_Seleccion.TabStop = false;
            this.groupBox_Seleccion.Text = "Seleccion de la capacitacion";
            // 
            // dataGridView_seleccion_capacitacion
            // 
            this.dataGridView_seleccion_capacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seleccion_capacitacion.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_seleccion_capacitacion.Name = "dataGridView_seleccion_capacitacion";
            this.dataGridView_seleccion_capacitacion.Size = new System.Drawing.Size(798, 367);
            this.dataGridView_seleccion_capacitacion.TabIndex = 0;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_Seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.groupBox_Seleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccion_capacitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_Seleccion;
        private System.Windows.Forms.DataGridView dataGridView_seleccion_capacitacion;
    }
}