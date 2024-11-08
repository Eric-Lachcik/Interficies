namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateTotals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                String Name = nombrecito.Text;
                String Surname = apellido.Text;

                String fullname = Name + " " + Surname;


                if (Selector.SelectedItem.ToString().Equals("User"))
                {
                    UserList.Items.Add(fullname);

                }
                else
                {
                    AdminList.Items.Add(fullname);
                }
                UpdateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TotalAdmins_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TotalUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UpdateTotals()
        {
            TotalUser.Text = UserList.Items.Count.ToString();
            TotalAdmins.Text = AdminList.Items.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserList.Items.Clear();
            UpdateTotals();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminList.Items.Clear();
            UpdateTotals();
        }

        private void AdminList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
