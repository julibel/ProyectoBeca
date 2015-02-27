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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato.Alta alta_candidato = new Candidato.Alta();
            alta_candidato.MdiParent = this;
            alta_candidato.Show();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
