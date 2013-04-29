using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class EnemyPlane
    {
        private Bitmap enemyPlaneImg;
        private int X;
        private int Y;
        private int speed;

        public EnemyPlane(int maxWidth,int x, int y)
        {
            enemyPlaneImg = new Bitmap("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\img\\Enemy1-small.png");
            Random random = new Random();
            X = x; //int.Parse(random.Next(maxWidth-enemyPlaneImg.Size.Width).ToString());
            Y = y;// -enemyPlaneImg.Size.Height;
            speed = 5;
        }

        public bool enemyPlaneOnTheMove(int maxHeight)
        {
            if (Y + speed < maxHeight)
            {
                Y = Y + speed;
                return true;
            }
            return false;
        }

        //Getters and Setters

        public int getX()
        {
            return X;
        }
        
        public int getY()
        {
            return Y;
        }

        public void setY(int y)
        {
            Y = y;
        }

        public Bitmap getImg()
        {
            return enemyPlaneImg;
        }
        public int getSpeed()
        {
            return speed;
        }
       

    }
}
