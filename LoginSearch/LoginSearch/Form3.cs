using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSearch
{
    public partial class Form3 : Form
    {
        public string DNI => textBoxDNI.Text;
        public string Nombre => textBoxNombre.Text;
        public string Llinatge => textBoxLinatge.Text;
        public int Edad => int.TryParse(textBoxEdad.Text, out var edad) ? edad : 0;
        Random randomizer = new Random();

        int Mates;
        int Historia;
        int Fisica;
        int Biologia;
        int Quimica;

        public Form3(string dni, string nombre, string linatge, int edad)
        {
            InitializeComponent();
            tabla_assignatures();

            textBoxDNI.Text = dni;
            textBoxNombre.Text = nombre;
            textBoxLinatge.Text = linatge;
            textBoxEdad.Text = edad.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_assignatures()
        {
            DataTable table = new DataTable();
            Mates = randomizer.Next(11);
            Historia = randomizer.Next(11);
            Fisica = randomizer.Next(11);
            Biologia = randomizer.Next(11);
            Quimica = randomizer.Next(11);

            table.Columns.Add("Assigatura", typeof(string));
            table.Columns.Add("Nota", typeof(int));

            table.Rows.Add("Matemáticas", Mates);
            table.Rows.Add("Historia", Historia);
            table.Rows.Add("Física", Fisica);
            table.Rows.Add("Biología", Biologia);
            table.Rows.Add("Química", Quimica);

            dataGridView1.DataSource = table;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.RowTemplate.Height = 100;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
