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

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato.Baja baja_candidato = new Candidato.Baja();
            baja_candidato.MdiParent = this;
            baja_candidato.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato.Modificacion modificacion_candidato = new Candidato.Modificacion();
            modificacion_candidato.MdiParent = this;
            modificacion_candidato.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato.Historial historial_candidato = new Candidato.Historial();
            historial_candidato.MdiParent = this;
            historial_candidato.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empresa.Alta alta_empresa = new Empresa.Alta();
            alta_empresa.MdiParent = this;
            alta_empresa.Show();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empresa.Baja baja_empresa = new Empresa.Baja();
            baja_empresa.MdiParent = this;
            baja_empresa.Show();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empresa.Modificacion modificacion_empresa = new Empresa.Modificacion();
            modificacion_empresa.MdiParent = this;
            modificacion_empresa.Show();
        }

        private void informeDeCandidatosPosiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.InformeCandidatos informeCandidatos_empresa = new Empresa.InformeCandidatos();
            informeCandidatos_empresa.MdiParent = this;
            informeCandidatos_empresa.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Capacitador.Alta alta_capacitador = new Capacitador.Alta();
            alta_capacitador.MdiParent = this;
            alta_capacitador.Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Capacitador.Baja baja_capacitador = new Capacitador.Baja();
            baja_capacitador.MdiParent = this;
            baja_capacitador.Show();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Capacitador.Modificacion modificacion_capacitador = new Capacitador.Modificacion();
            modificacion_capacitador.MdiParent = this;
            modificacion_capacitador.Show();
        }

        private void historialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capacitador.Historial historial_capacitador = new Capacitador.Historial();
            historial_capacitador.MdiParent = this;
            historial_capacitador.Show();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Capacitacion.Alta alta_capacitacion = new Capacitacion.Alta();
            alta_capacitacion.MdiParent = this;
            alta_capacitacion.Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Capacitacion.Baja baja_capacitacion = new Capacitacion.Baja();
            baja_capacitacion.MdiParent = this;
            baja_capacitacion.Show();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Capacitacion.Modificacion modificacion_capacitacion = new Capacitacion.Modificacion();
            modificacion_capacitacion.MdiParent = this;
            modificacion_capacitacion.Show();
        }

        private void historialToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Capacitacion.Historial historial_capacitacion = new Capacitacion.Historial();
            historial_capacitacion.MdiParent = this;
            historial_capacitacion.Show();
        }
    }
}
