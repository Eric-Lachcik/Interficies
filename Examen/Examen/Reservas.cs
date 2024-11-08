using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSalon_Click(object sender, EventArgs e)
        {

        }

        private void numericJornada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombres_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEventos.SelectedItem.ToString().Equals("Congreso"))
            {
                labelJornada.Enabled = true;
                numericJornada.Enabled = true;
                labelAsistentes.Enabled = true;
                comboBoxAsistentes.Enabled = true;

                labelBanquete.Enabled = false;
                comboBoxBanquete.Enabled = false;
                labelComensales.Enabled = false;
                numericUpDownComensales.Enabled = false;

            }
            else if (comboBoxEventos.SelectedItem.ToString().Equals("Banquete"))
            {
                labelBanquete.Enabled = true;
                comboBoxBanquete.Enabled = true;
                labelComensales.Enabled = true;
                numericUpDownComensales.Enabled = true;


                labelJornada.Enabled = false;
                numericJornada.Enabled = false;
                labelAsistentes.Enabled = false;
                comboBoxAsistentes.Enabled = false;
            }
            else
            {
                labelBanquete.Enabled = false;
                comboBoxBanquete.Enabled = false;
                labelComensales.Enabled = false;
                numericUpDownComensales.Enabled = false;
                labelJornada.Enabled = false;
                numericJornada.Enabled = false;
                labelAsistentes.Enabled = false;
                comboBoxAsistentes.Enabled = false;
            }
        }

        private void textBoxContacto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden numeros");
            }
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerFecha.Value;

            labelFecha.Text = fecha.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxContacto.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Sala Reservada");

        }

        private void comboBoxAsistentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
