using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class cloud
    {
        private Bitmap cloudImg;
        private int speed;
        private int X;
        private int Y;

        public cloud(int X, int Y, int t)
        {
            if (t == 1) cloudImg = new Bitmap(Properties.Resources.cloud1);
            else cloudImg = new Bitmap(Properties.Resources.cloud2);
            speed=4;
            this.X=X;
            this.Y=Y;
        }
        public bool moveCloud()
        {
            if (Y > 768) return false;
            Y = Y + speed;

            return true;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(cloudImg, X, Y);
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public Bitmap getImg()
        {
            return cloudImg;
        }
    }
}
