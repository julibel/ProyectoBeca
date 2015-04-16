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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            DialogResult quiereBorrar = MessageBox.Show("¿Esta seguro que quiere borrar los datos?", "Borrar candidato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quiereBorrar == DialogResult.Yes)
            {
                // borrar objeto
                // limpio form

            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
