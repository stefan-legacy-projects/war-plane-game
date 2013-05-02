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
        private SoundPlayer RocketMusic;
        private SoundPlayer GameOverMusic;
        private SoundPlayer MashinegunPlayer;
        private SoundPlayer Explosions;
        
        
        public Sounds()
        {
            IntroMusic = new SoundPlayer("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\Intro.wav");
            MainMusic = new SoundPlayer ("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\bgSound.wav");
            Explosions = new SoundPlayer("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\Explosion.wav");
            RocketMusic = new SoundPlayer("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\Rocket.wav");
            GameOverMusic = new SoundPlayer("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\GameOver.wav");
            MashinegunPlayer = new SoundPlayer("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\sounds\\MashineGun.wav");
            
        }
        public void playMainMusic()
        {
           MainMusic.PlayLooping();
        }
        public void playGameOverMusic()
        {
            MainMusic.Stop();
            GameOverMusic.Play();
        }
        public void playExplosions()
        {
            MainMusic.Stop();
           Explosions.Play();
           MainMusic.PlayLooping();
        }
        public void playRocket()
        {
            MainMusic.Stop();
            RocketMusic.Play();
            MainMusic.PlayLooping();
        }
        public void playIntro()
        {
            IntroMusic.PlayLooping();
        }
        public void playMashineGun()
        {
            MashinegunPlayer.Play();
        }
       
    }
}
