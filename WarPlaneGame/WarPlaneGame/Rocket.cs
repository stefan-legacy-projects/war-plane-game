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
    }
}
