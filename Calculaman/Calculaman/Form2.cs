using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculaman
{
    public partial class Form2 : Form
    {
        private int timeLeft = 60;

        Random randomizer = new Random();

        int addend1;
        int addend2;


        int minuend;
        int subtrahend;


        int multiplicand;
        int multiplier;


        int dividend;
        int divisor;

        public Form2()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            StartTheQuiz();
        }

        private void InitializeCountdownTimer()
        {

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;

            progressBarTimer.Maximum = 60;
            progressBarTimer.Value = 0;
            labelTimer.Text = "60";


            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            bool allCorrect = true;

            if (addend1 + addend2 == numericSum.Value)
            {
                sumRes.Visible = true;
                sumRes.ForeColor = Color.Green;
            }
            else
            {
                sumRes.Visible = true;
                sumRes.ForeColor = Color.Red;
                allCorrect = false;
            }

            if (minuend - subtrahend == numericMin.Value)
            {
                minRes.Visible = true;
                minRes.ForeColor = Color.Green;
            }
            else
            {
                minRes.Visible = true;
                minRes.ForeColor = Color.Red;
                allCorrect = false;
            }

            if (multiplicand * multiplier == numericPor.Value)
            {
                porRes.Visible = true;
                porRes.ForeColor = Color.Green;
            }
            else
            {
                porRes.Visible = true;
                porRes.ForeColor = Color.Red;
                allCorrect = false;
            }

            if (dividend / divisor == numericDiv.Value)
            {
                divRes.Visible = true;
                divRes.ForeColor = Color.Green;
            }
            else
            {
                divRes.Visible = true;
                divRes.ForeColor = Color.Red;
                allCorrect = false;
            }

            return allCorrect;
        }

        private void labelExer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                timeLeft--;
                progressBarTimer.Value = 60 - timeLeft;
                labelTimer.Text = timeLeft.ToString();
            }
            else
            {
                timer1.Stop();
                labelTimer.Text = "¡Tiempo terminado!";
                MessageBox.Show("¡El tiempo ha finalizado!");
                if (CheckTheAnswer())
                {
                    MessageBox.Show("¡Has acertado todo!");
                    buttonClose.Enabled = true;
                    buttonClose.Visible = true;
                }
                else
                {
                    MessageBox.Show("¡Tienes Fallos!");
                    buttonClose.Enabled = true;
                    buttonClose.Visible = true;
                }
            }
        }

        public void StartTheQuiz()
        {

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeft.Text = addend1.ToString();
            plusRight.Text = addend2.ToString();

            numericSum.Value = 0;


            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusleft.Text = minuend.ToString();
            minright.Text = subtrahend.ToString();

            numericMin.Value = 0;


            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            porleft.Text = multiplicand.ToString();
            porright.Text = multiplier.ToString();

            numericPor.Value = 0;


            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            divleft.Text = dividend.ToString();
            divright.Text = divisor.ToString();

            numericDiv.Value = 0;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void plusLeft_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Results_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (CheckTheAnswer())
            {
                MessageBox.Show("¡Has acertado todo!");
                buttonClose.Enabled = true;
                buttonClose.Visible = true;
            }
            else
            {
                MessageBox.Show("¡Tienes Fallos!");
                buttonClose.Enabled = true;
                buttonClose.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void sumRes_Click(object sender, EventArgs e)
        {

        }
    }
}
