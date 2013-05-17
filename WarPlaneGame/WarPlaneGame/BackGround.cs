using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class BackGround
    {
        private Bitmap Layer1;
        private int Layer1speed;
        private int X;
        private int Y;
        public BackGround(int y)
        {
            Layer1 = new Bitmap(Properties.Resources.back1);
            Layer1speed = 2;
            X = 0;
            Y = y;
        }

        public void BackGroundMove()
        {
            if (Y >= 768) Y = -760;
            else
            {
                Y = Y + Layer1speed;
            }

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
            return Layer1;
        }
    }
}
