using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBeca.Empresa
{
    public partial class InformeCandidatos : Form
    {
        public InformeCandidatos()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_razon_social.Clear();
            comboBox_area.SelectedIndex = -1;
            comboBox_barrio.SelectedIndex = -1;
            comboBox_opciones_primario.SelectedIndex = -1;
            comboBox_opciones_secundario.SelectedIndex = -1;
            comboBox_opciones_universitario.SelectedIndex = -1;
            numericUpDown_edad_desde.Value = 0;
            numericUpDown_edad_hasta.Value = 0;

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void InformeCandidatos_Load(object sender, EventArgs e)
        {

        }
    }
}
