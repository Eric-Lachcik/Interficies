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
        public Search()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            // Crear una instancia de DataTable
            DataTable table = new DataTable();

            // Definir las columnas
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Edad", typeof(int));

            // Agregar filas manualmente
            table.Rows.Add(1, "Juan Pérez", 25);
            table.Rows.Add(2, "Ana López", 30);
            table.Rows.Add(3, "Carlos Gómez", 35);

            // Enlazar el DataTable al DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
