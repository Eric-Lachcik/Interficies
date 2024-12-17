using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form2 : Form
    {
        Label primero = null;

        Label segundo = null;

        Random random = new Random();

        Stopwatch timer = new Stopwatch();

        List<string> icons = new List<string>()
        {
            "?", "?", "n", "n", ".", ".", "L", "L",
            "A", "A", "t", "t", "W", "W", "Y", "Y"
        };
        public Form2()
        {
            InitializeComponent();
            AsignarIconos();
            timer.Start();
        }

        private void AsignarIconos()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
                return;

            Label labels = sender as Label;

            if (labels != null)
            {
                
                if (labels.ForeColor == Color.Black)
                    return;

              
                if (primero == null)
                {
                    primero = labels;
                    primero.ForeColor = Color.Black;
                    return;
                }
                segundo = labels;
                segundo.ForeColor = Color.Black;


               
                CheckForWinner();

                if (primero.Text == segundo.Text)
                {
                    primero = null;
                    segundo = null;
                    return;
                };

                timer1.Start();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Stop();

            primero.ForeColor = primero.BackColor;
            segundo.ForeColor = segundo.BackColor;

            primero = null;
            segundo = null;
        }

        private void CheckForWinner()
        {
            
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            timer.Stop(); 
            TimeSpan timeTaken = timer.Elapsed;

            string message = $"You matched all the icons!\nTime taken: {timeTaken.Minutes} minutes and {timeTaken.Seconds} seconds.";
            MessageBox.Show(message, "Congratulations");
            Close();
        }
    }
}
