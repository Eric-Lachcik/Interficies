using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCollector
{
    public class MoneyBag
    {
        public Rectangle Bounds { get; private set; }
        private Image MoneyBagImage;

        public MoneyBag(Rectangle bounds, Image image)
        {
            Bounds = bounds;
            MoneyBagImage = image;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(MoneyBagImage, Bounds);
        }
    }
}
