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

        private void groupBox_info_personal_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_observaciones_Enter(object sender, EventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            DialogResult quiereGuardar = MessageBox.Show("¿Esta seguro que quiere gurdar los datos ingresados en el formulario?","Guardar empresa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
            if (quiereGuardar == DialogResult.Yes)
            {
                // creo nuevo objeto tipo: empresa
                // compruebo datos completos y tipos de datos correctos (manejo de errores)
                // guardo datos del form en objeto
                // limpio form

            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_domicilio.Clear();
            textBox_email.Clear();
            textBox_razon_social.Clear();
            textBox_tel_caracteristica.Clear();
            textBox_tel_numero.Clear();
            richTextBox_observaciones.Clear();
            richTextBox_principales_actividades.Clear();

        }

        private void groupBox_Intereses_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void richTextBox_observaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
