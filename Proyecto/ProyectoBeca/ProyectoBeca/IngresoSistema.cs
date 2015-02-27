using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBeca
{
    public partial class IngresoSistema : Form
    {
        public IngresoSistema()
        {
            InitializeComponent();
        }

        private void label_bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            FormBase menu_base = new FormBase();
            menu_base.Show();
            this.Hide();
            }
    }
}
