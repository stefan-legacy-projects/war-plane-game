using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class Rocket
    {
        // Image for the Rocket
        private Bitmap rocketImage;
        //Rocket Speed
        private int speed;
        //Starting possition for the Rocket
        private int X;
        private int Y;

        public Rocket(int x, int y)
        {
            rocketImage = new Bitmap(Properties.Resources.Rocket_V2);
            X = x;
            Y = y;
            speed = 20;
        }

        public void moveRocket()
        {
            Y = Y - speed;
           
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(rocketImage, X, Y);
        }

        //Getter and Setters
        public int getSpeed()
        {
            return speed;
        }
        public Bitmap getImage()
        {
            return rocketImage;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void Reset()
        {
            speed = -6;
            rocketImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }
    }
}
