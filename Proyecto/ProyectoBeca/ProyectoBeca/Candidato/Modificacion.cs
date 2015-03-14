using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBeca.Candidato
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_cuit_cuil.Clear();
            textBox_tel_caracteristica.Clear();
            textBox_tel_numero.Clear();
            textBox_email.Clear();
            dateTimePicker_nacimiento.Value = DateTime.Now;
            comboBox_barrio.SelectedIndex = -1;
            comboBox_opciones_primario.SelectedIndex = -1;
            comboBox_opciones_secundario.SelectedIndex = -1;
            comboBox_opciones_terciario.SelectedIndex = -1;
            comboBox_opciones_universitario.SelectedIndex = -1;
            dataGridView_cursos_capacitaciones.Rows.Clear();
            dataGridView_cursos_capacitaciones.Refresh();
            richTextBox_intereses.Clear();
            richTextBox_observaciones.Clear();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            DialogResult quiereGuardar = MessageBox.Show("¿Esta seguro que quiere gurdar los datos ingresados en el formulario?", "Guardar candidato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quiereGuardar == DialogResult.Yes)
            {
                // creo nuevo objeto tipo: candidato
                // compruebo datos completos y tipos de datos correctos (manejo de errores)
                // guardo datos del form en objeto
                // limpio form

            }
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
