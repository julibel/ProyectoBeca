namespace ProyectoBeca.Capacitador
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
            this.groupBox_seleccion = new System.Windows.Forms.GroupBox();
            this.dataGridView_seleccionar_capacitador = new System.Windows.Forms.DataGridView();
            this.groupBox_seleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccionar_capacitador)).BeginInit();
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
            // groupBox_seleccion
            // 
            this.groupBox_seleccion.Controls.Add(this.dataGridView_seleccionar_capacitador);
            this.groupBox_seleccion.Location = new System.Drawing.Point(12, 12);
            this.groupBox_seleccion.Name = "groupBox_seleccion";
            this.groupBox_seleccion.Size = new System.Drawing.Size(810, 401);
            this.groupBox_seleccion.TabIndex = 2;
            this.groupBox_seleccion.TabStop = false;
            this.groupBox_seleccion.Text = "Seleccion del capacitador";
            // 
            // dataGridView_seleccionar_capacitador
            // 
            this.dataGridView_seleccionar_capacitador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seleccionar_capacitador.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_seleccionar_capacitador.Name = "dataGridView_seleccionar_capacitador";
            this.dataGridView_seleccionar_capacitador.Size = new System.Drawing.Size(798, 367);
            this.dataGridView_seleccionar_capacitador.TabIndex = 0;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox_seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.groupBox_seleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seleccionar_capacitador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_seleccion;
        private System.Windows.Forms.DataGridView dataGridView_seleccionar_capacitador;
    }
}