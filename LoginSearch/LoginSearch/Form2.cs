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

    public partial class Search : Form
    {
        private DataTable tablinha;

        public Search()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {

            DataTable table = new DataTable();


            table.Columns.Add("DNI", typeof(string));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Llinatge", typeof(string));
            table.Columns.Add("Edat", typeof(int));


            table.Rows.Add(1, "Pedro", "Garcia", 25);
            table.Rows.Add(2, "Juan", "Sebastian", 30);
            table.Rows.Add(3, "Eric", "Lachcik", 35);
            table.Rows.Add(4, "Toñin", "Kumar", 18);
            table.Rows.Add(5, "Jose", "Luis", 17);

            tablinha = table.Copy();
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Perfil",
                Text = "Abrir Perfil",
                UseColumnTextForButtonValue = true,
                Name = "Perfil"
            };

            dataGridView1.Columns.Add(buttonColumn);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {

                string dni = dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                string linatge = dataGridView1.Rows[e.RowIndex].Cells["Llinatge"].Value.ToString();
                int edad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Edat"].Value);


                Form3 perfil = new Form3(dni, nombre, linatge, edad);
                if (perfil.ShowDialog() == DialogResult.OK)
                {

                    dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value = perfil.DNI;
                    dataGridView1.Rows[e.RowIndex].Cells["Nom"].Value = perfil.Nombre;
                    dataGridView1.Rows[e.RowIndex].Cells["Llinatge"].Value = perfil.Llinatge;
                    dataGridView1.Rows[e.RowIndex].Cells["Edat"].Value = perfil.Edad;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string apellidoBuscar = textBuscar.Text;

            if (string.IsNullOrEmpty(apellidoBuscar))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
                return;
            }


            DataView view = new DataView(tablinha);
            view.RowFilter = $"Llinatge LIKE '%{apellidoBuscar}%'";

            dataGridView1.DataSource = view;

        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tablinha;
            textBuscar.Clear();
        }
    }
}
