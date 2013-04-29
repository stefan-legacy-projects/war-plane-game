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
            Layer1 = new Bitmap("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\img\\back1.png");
            Layer1speed = 3;
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
