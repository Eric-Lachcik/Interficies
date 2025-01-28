using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace MoneyCollector
{
    public partial class Game : Form
    {
        // Variables
        private System.Windows.Forms.Timer gameTimer;
        private Player player;
        private ArrayList moneyBags;
        private ArrayList keysPressed;
        private int score;
        private Random random;      
        private Image playerImage;  
        private Image moneyBagImage;  

        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 800;
            this.Height = 600;
            LoadImages();
            InitializeGame();
        }

        private void LoadImages()
        {
            // Cargamos imagenes desde la carpeta Images en bin/Debug
            try
            {
                playerImage = Image.FromFile("Images/briefcase.png");
                moneyBagImage = Image.FromFile("Images/moneybag.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando imágenes: {ex.Message}");
                Environment.Exit(1);
            }
        }

        private void InitializeGame()
        {

            random = new Random();

            // Spawn del jugador en el centro de la pantalla
            int centerX = (this.ClientSize.Width - 50) / 2;  
            int centerY = (this.ClientSize.Height - 50) / 2; 
            player = new Player(new Rectangle(centerX, centerY, 50, 50), playerImage);


            // Inicializamos las listas y el score
            moneyBags = new ArrayList();
            keysPressed = new ArrayList();
            score = 0;

           
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(0, this.ClientSize.Width - 50);
                int y = random.Next(0, this.ClientSize.Height - 50);
                moneyBags.Add(new MoneyBag(new Rectangle(x, y, 50, 50), moneyBagImage));
            }

            // Configuramos el timer del juego
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 16; // Aproximadamente 60 FPS
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            this.KeyDown += (s, e) =>
            {
                if (!keysPressed.Contains(e.KeyCode)) keysPressed.Add(e.KeyCode);
            };

            this.KeyUp += (s, e) =>
            {
                keysPressed.Remove(e.KeyCode);
            };
        }

        private void GameLoop(object sender, EventArgs e)
        {
           

            // Actualizamos el estado del juego
            UpdatePlayer();
            CheckCollisions();

            
            this.Invalidate();
        }

        private void UpdatePlayer()
        {
            // Velocidad de movimiento 
            int speed = 5;
            

            if (keysPressed.Contains(Keys.Up)) player.Move(0, -speed);
            if (keysPressed.Contains(Keys.Down)) player.Move(0, speed);
            if (keysPressed.Contains(Keys.Left)) player.Move(-speed, 0);
            if (keysPressed.Contains(Keys.Right)) player.Move(speed, 0);

            // Evitar que el jugador salga de los límites de la pantalla
            player.ClampToBounds(this.ClientSize);
        }

        private void CheckCollisions()
        {
            // Miramos las colisiones entre el jugador y las moneybags
            for (int i = moneyBags.Count - 1; i >= 0; i--)
            {
                MoneyBag bag = (MoneyBag)moneyBags[i];
                if (player.Bounds.IntersectsWith(bag.Bounds))
                {   
                    // Removemos la moneybag y sumamos puntos
                    moneyBags.RemoveAt(i);
                    score += 10;
                    
                    // Generar nuevo moneybag en posición aleatoria
                    int x = random.Next(0, this.ClientSize.Width - 50);
                    int y = random.Next(0, this.ClientSize.Height - 50);
                    moneyBags.Add(new MoneyBag(new Rectangle(x, y, 50, 50), moneyBagImage));

                    CheckScore();
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Dibujamos al jugador
            player.Draw(g);

            // Dibujamos las  bolsas de dinero
            foreach (MoneyBag bag in moneyBags)
            {
                bag.Draw(g);
            }

            // Dibujamos la  puntuación
            Font font = new Font("Arial", 16);
            g.DrawString($"Score: {score}", font, Brushes.Black, 10, 10);
        }

        private void CheckScore()
        {   // Verificamos si el jugador ha llegado a los 500 puntos 
            if (score >= 500) 
            {
                gameTimer.Stop();
                MessageBox.Show("¡Has Ganado!", "¡Felicidades!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

