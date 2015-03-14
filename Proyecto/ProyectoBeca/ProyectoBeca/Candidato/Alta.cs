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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        public bool comprobarTipos(String telefono, String caracteristica)
        {
            return (telefono.All(char.IsDigit) && caracteristica.All(char.IsDigit));
        }

        public bool comprobarDatosCompletos(String nombre, String apellido, String cuil_cuil, String fecha, String barrio, String caracteristica, String telefono, String mail, String primaria, String secundaria, String terciario, String universitario)
        {
            if (nombre == "" ||
                apellido == "" ||
                cuil_cuil == "" ||
                fecha == "" ||
                barrio == "" ||
                caracteristica == "" ||
                telefono == "" ||
                mail == "" ||
                primaria == "" ||
                secundaria == "" ||
                terciario == "" ||
                universitario == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_formacion_Enter(object sender, EventArgs e)
        {

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            //limpio el contenido de los controles
            //DialogResult quiereLimpiar = MessageBox.Show("¿Esta seguro que quiere limpiar todos los campos del formulario?","Limpiar formulario",MessageBoxButtons.YesNo,
            //MessageBoxIcon.Question);

            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_cuit_cuil.Clear();
            textBox_tel_caracteristica.Clear();
            textBox_tel_numero.Clear();
            textBox_email.Clear();
            dateTimePicker_nacimiento.Value = DateTime.Now;
            comboBox_barrio.SelectedIndex = -1;
            comboBox_opciones_primario.SelectedIndex = -1;
            comboBox_opciones_secundario.SelectedIndex = -1;
            comboBox_opciones_terciario.SelectedIndex = -1;
            comboBox_opciones_universitario.SelectedIndex = -1;
            dataGridView_cursos_capacitaciones.Rows.Clear();
            dataGridView_cursos_capacitaciones.Refresh();
            richTextBox_intereses.Clear();
            richTextBox_observaciones.Clear();





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            
            DialogResult quiereGuardar = MessageBox.Show("¿Esta seguro que quiere gurdar los datos ingresados en el formulario?","Guardar candidato",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
            if (quiereGuardar == DialogResult.Yes)
            {
                // creo nuevo objeto tipo: candidato
                // compruebo datos completos y tipos de datos correctos (manejo de errores)
                // guardo datos del form en objeto
                // limpio form

            }
        
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Candidato.Cursos_capacitaciones cursos_candidato = new Candidato.Cursos_capacitaciones();
            cursos_candidato.Show();
        }
    }
}
