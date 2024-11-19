namespace LoginSearch
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Search form2 = new Search();
            form2.ShowDialog();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
