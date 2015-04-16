namespace ProyectoBeca.Capacitacion
{
    partial class Historial
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
            this.groupBox_historial = new System.Windows.Forms.GroupBox();
            this.dataGridView_historial_capacitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox_historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial_capacitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 3;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_historial
            // 
            this.groupBox_historial.Controls.Add(this.dataGridView_historial_capacitaciones);
            this.groupBox_historial.Location = new System.Drawing.Point(12, 12);
            this.groupBox_historial.Name = "groupBox_historial";
            this.groupBox_historial.Size = new System.Drawing.Size(810, 401);
            this.groupBox_historial.TabIndex = 2;
            this.groupBox_historial.TabStop = false;
            this.groupBox_historial.Text = "Historial de capacitaciones";
            // 
            // dataGridView_historial_capacitaciones
            // 
            this.dataGridView_historial_capacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historial_capacitaciones.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_historial_capacitaciones.Name = "dataGridView_historial_capacitaciones";
            this.dataGridView_historial_capacitaciones.Size = new System.Drawing.Size(798, 367);
            this.dataGridView_historial_capacitaciones.TabIndex = 0;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_historial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.groupBox_historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial_capacitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_historial;
        private System.Windows.Forms.DataGridView dataGridView_historial_capacitaciones;
    }
}