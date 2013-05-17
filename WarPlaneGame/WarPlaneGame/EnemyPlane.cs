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
        private int life;

        public EnemyPlane(int x, int y)
        {
           enemyPlaneImg = new Bitmap(Properties.Resources.Enemy1_small);
            X = x; 
            Y = y;
            speed = 6;  // Old Value 5
            life =2 ;
        }
// Move the Plain
        public bool enemyPlaneOnTheMove(int maxHeight)
        {
            if (Y + speed < maxHeight)
            {
                Y = Y + speed;
                return true;
            }
            return false;
        }
//Plain lose life
        public void LoseLife()
        {
            life = life - 1;
            enemyPlaneImg = new Bitmap(Properties.Resources.EnemyBurn);
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
        public int LIFE()
        {
            return life;
        }
       

    }
}
