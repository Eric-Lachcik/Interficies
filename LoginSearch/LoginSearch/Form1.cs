using System.Diagnostics;
using System.Windows.Forms;

namespace LoginSearch
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeLinkLabel();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string usuari = usernameText.Text;
            string contra = passwordText.Text;
            Search form2 = new Search();
            if (string.IsNullOrEmpty(usuari) && string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Tens que introduir l'usuari i contrasenya");
            }
            else if (string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Tens que introduir la contrasenya");
            }
            else if (string.IsNullOrEmpty(usuari))
            {
                MessageBox.Show("Tens que introduir l'usuari");
            }
            else
            {
                form2.ShowDialog();
                passwordText.Clear();
                usernameText.Clear();
            }

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void InitializeLinkLabel()
        {
            subHeaderLink.Text = "Visita Cide";
            subHeaderLink.Links.Clear();
            subHeaderLink.Links.Add(0, subHeaderLink.Text.Length, "www.cide.es");


            subHeaderLink.LinkClicked -= subHeaderLink_LinkClicked;
            subHeaderLink.LinkClicked += subHeaderLink_LinkClicked;
        }

        private void subHeaderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData is string url && !string.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void subHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
