using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBeca.Capacitador
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            DialogResult quiereGuardar = MessageBox.Show("¿Esta seguro que quiere gurdar los datos ingresados en el formulario?", "Guardar capacitador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quiereGuardar == DialogResult.Yes)
            {
                // creo nuevo objeto tipo: candidato
                // compruebo datos completos y tipos de datos correctos (manejo de errores)
                // guardo datos del form en objeto
                // limpio form

            }
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
            dataGridView_areas_capacitacion.Rows.Clear();
            dataGridView_areas_capacitacion.Refresh();
            richTextBox_observaciones.Clear();
            radioButton_sin_verificar.Checked = false;
            radioButton_verificado.Checked = false;
            radioButton_verificando.Checked = false;
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Capacitador.Capacitacion capacitacion_capacitador = new Capacitador.Capacitacion();
            capacitacion_capacitador.Show();
        }
    }
}
