using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class MashineGun
    {
        // Image for the Rocket
        private Bitmap Bullet;
        //Rocket Speed
        private int speed;
        //Starting possition for the Rocket
        private int X;
        private int Y;

        public MashineGun(int x, int y)
        {
           Bullet = new Bitmap(Properties.Resources.Bullet);
            X = x;
            Y = y;
            speed = 30;
        }

        public void moveBullets()
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
            return Bullet;
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
