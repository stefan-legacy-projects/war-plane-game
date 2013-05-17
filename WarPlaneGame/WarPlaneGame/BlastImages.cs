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
             loseImg = new Bitmap(Properties.Resources.Pow);
             winImg = new Bitmap(Properties.Resources.Bam);
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
