using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class BlastImages
    {
        private Bitmap winImg;
        private Bitmap loseImg;
        public BlastImages()
        {
            loseImg = new Bitmap("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\img\\Pow.png");
            winImg = new Bitmap("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\img\\Bam.png");
        }
        public Bitmap getWinImg()
        {
            return winImg;
        }
        public Bitmap getLoseImg()
        {
            return loseImg;
        }

    }
}
