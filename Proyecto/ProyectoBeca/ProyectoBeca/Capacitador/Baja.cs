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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            DialogResult quiereBorrar = MessageBox.Show("¿Esta seguro que quiere borrar los datos?", "Borrar capacitador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quiereBorrar == DialogResult.Yes)
            {
                // borrar objeto
                // limpio form

            }
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_formacion_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
