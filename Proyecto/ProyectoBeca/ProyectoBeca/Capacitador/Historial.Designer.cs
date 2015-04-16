namespace ProyectoBeca.Capacitador
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
            this.groupBox_historial_capacitador = new System.Windows.Forms.GroupBox();
            this.dataGridView_historial_capacitador = new System.Windows.Forms.DataGridView();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_historial_capacitador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial_capacitador)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_historial_capacitador
            // 
            this.groupBox_historial_capacitador.Controls.Add(this.dataGridView_historial_capacitador);
            this.groupBox_historial_capacitador.Location = new System.Drawing.Point(12, 12);
            this.groupBox_historial_capacitador.Name = "groupBox_historial_capacitador";
            this.groupBox_historial_capacitador.Size = new System.Drawing.Size(810, 402);
            this.groupBox_historial_capacitador.TabIndex = 1;
            this.groupBox_historial_capacitador.TabStop = false;
            this.groupBox_historial_capacitador.Text = "Historial del capacitador";
            // 
            // dataGridView_historial_capacitador
            // 
            this.dataGridView_historial_capacitador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historial_capacitador.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_historial_capacitador.Name = "dataGridView_historial_capacitador";
            this.dataGridView_historial_capacitador.Size = new System.Drawing.Size(798, 367);
            this.dataGridView_historial_capacitador.TabIndex = 0;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 1;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_historial_capacitador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.groupBox_historial_capacitador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial_capacitador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_historial_capacitador;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView_historial_capacitador;
    }
}