using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void buttonReservar_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
