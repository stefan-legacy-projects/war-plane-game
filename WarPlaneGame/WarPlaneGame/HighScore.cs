using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarPlaneGame
{
    
    public class HighScore
    {
        // Variable for the player High Score
        private int score;
        // Public constructor
        public HighScore()
        {
            score = 0;
        }
        // Update the score 
        public void UpdateScore()
        {
            score = score + 10;
        }
        // Get the Score
        public int getScore()
        {
            return score;
        }
       
    }
}
