using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace WarPlaneGame
{
    public class Sounds
    {
        private SoundPlayer IntroMusic;
        private SoundPlayer MainMusic;
        private SoundPlayer GameOverMusic;
        private SoundPlayer GameComplete;
        
        public Sounds()
        {
            IntroMusic = new SoundPlayer(Properties.Resources.Intro1);
            MainMusic = new SoundPlayer (Properties.Resources.bgSound);
            GameOverMusic = new SoundPlayer(Properties.Resources.GameOver);
            GameComplete = new SoundPlayer(Properties.Resources.missionComplete);
        }
        public void playMainMusic()
        {
           MainMusic.PlayLooping();
        }
        public void playGameOverMusic()
        {
           GameOverMusic.Play();
        }
        
        public void playIntro()
        {
            IntroMusic.PlayLooping();
        }
        public void playMissionComplete()
        {
            GameComplete.Play();
        }
        
       
    }
}
