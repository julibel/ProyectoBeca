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
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_Intereses_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_formacion_Enter(object sender, EventArgs e)
        {

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {

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
