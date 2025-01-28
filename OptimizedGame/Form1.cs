using System.Diagnostics;

namespace OptimizedGame
{
    public partial class Form1 : Form
    {
        private Label primero = null;
        private Label segundo = null;
        private Random random = new Random();
        private Stopwatch gameTimer = new Stopwatch();

        private List<string> icons = new List<string>
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
            gameTimer.Start();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label)
                {
                    int randomIndex = random.Next(icons.Count);
                    label.Text = icons[randomIndex];
                    label.ForeColor = label.BackColor;
                    icons.RemoveAt(randomIndex);
                }
            }
        }

        private void CheckForMatch()
        {
            if (primero.Text == segundo.Text)
            {
                primero = null;
                segundo = null;
                CheckForWinner();
                return;
            }

            timer1.Start();
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label && label.ForeColor == label.BackColor)
                    return;
            }

            gameTimer.Stop();
            TimeSpan elapsed = gameTimer.Elapsed;

            MessageBox.Show($"Congratulations! You've matched all icons.\nTime: {elapsed.Minutes}m {elapsed.Seconds}s", "Winner!");
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            if (primero != null && segundo != null)
                return;

            if (sender is not Label clickedLabel || clickedLabel.ForeColor == Color.Black)
                return;

            clickedLabel.ForeColor = Color.Black;

            if (primero == null)
            {
                primero = clickedLabel;
                return;
            }

            segundo = clickedLabel;

            CheckForMatch();
        }
    }
}
