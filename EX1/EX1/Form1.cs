using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de las textboxes
                int horasTrabajadas = int.Parse(textBox1.Text);
                float costeHora = float.Parse(textBox2.Text);

                // Calcular el sueldo
                float sueldo = horasTrabajadas * costeHora;

                // Mostrar el resultado en un label
                textBox3.Text = sueldo.ToString("C2");
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante el cálculo
                MessageBox.Show("Error al calcular el sueldo: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
