using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCollector
{
    public class Player
    {
        public Rectangle Bounds { get; private set; }
        private Image PlayerImage;

        public Player(Rectangle bounds, Image image)
        {
            Bounds = bounds;
            PlayerImage = image;
        }

        public void Move(int dx, int dy)
        {
            Bounds = new Rectangle(Bounds.X + dx, Bounds.Y + dy, Bounds.Width, Bounds.Height);
        }

        public void ClampToBounds(Size screenSize)
        {
            Bounds = new Rectangle(
                Math.Max(0, Math.Min(screenSize.Width - Bounds.Width, Bounds.X)),
                Math.Max(0, Math.Min(screenSize.Height - Bounds.Height, Bounds.Y)),
                Bounds.Width,
                Bounds.Height
            );
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(PlayerImage, Bounds);
        }
    }
}
