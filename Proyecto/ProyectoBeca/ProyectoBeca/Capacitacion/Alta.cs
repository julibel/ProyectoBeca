using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBeca.Capacitacion
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_modificar_alumnos_Click(object sender, EventArgs e)
        {
            Capacitacion.Seleccion_alumnos seleccionar_alumnos = new Capacitacion.Seleccion_alumnos();
            seleccionar_alumnos.Show();
        }

        private void button_seleccionar_Click(object sender, EventArgs e)
        {
            Capacitacion.Seleccion_profesor seleccionar_profesor = new Capacitacion.Seleccion_profesor();
            seleccionar_profesor.Show();
        }
    }
}
