using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class Boss
    {
        private int lifes;
        private Bitmap bosImg;
        private int X;
        private int Y;
        private int speedX;
        private int speedY;
        public int MaxX;
        private List<Rocket> rockets;
        public Boss(int x, int y,int ma)
        {
            MaxX=ma;
            X = x;
            Y = y;
            rockets=new List<Rocket>();
            bosImg = new Bitmap(Properties.Resources.boss);
            speedX = 6;
            speedY = 3;
            lifes = 20;
        }
        public void move()
        {
            if (X > (MaxX - bosImg.Size.Width))
            {
                speedX = -speedX;
                X += speedX;
            }
            else if (X < 0)
            {
                speedX = -speedX;
                X += speedX;
            }
            else X += speedX;
            if (Y > 100)
            {
                speedY = -speedY;
                Y += speedY;
            }
            else if (Y < 0)
            {
                speedY =- speedY;
                Y += speedY;
            }
            else Y += speedY;
            

        }
        public void loseLife()
        {
            lifes--;
            if (lifes == 15) bosImg = new Bitmap(Properties.Resources.bossOnFlame1);
            if (lifes == 10) bosImg = new Bitmap(Properties.Resources.bossOnFlame2);
            if (lifes == 5) bosImg = new Bitmap(Properties.Resources.bossOnFlame3);
            if (lifes == 0) bosImg = new Bitmap(Properties.Resources.bossOnFlame4);
        }
        public void Draw(Graphics e)
        {
            e.DrawImage(bosImg,X,Y);
        }
        public int RX()
        {
            return X +(bosImg.Size.Width)/2;
        }
        public int RY()
        {
            return Y + 150;
        }
        public int getLife()
        {
            return lifes;
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
            return bosImg;
        }
    }
}
