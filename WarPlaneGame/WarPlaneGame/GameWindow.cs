using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WarPlaneGame
{
    public partial class GameWindow : Form
    {
        public PlayerPlane playerPlane;
        public int maxWidth;
        public int maxHeight;
        public List<EnemyPlane> Planes;
        public BackGround BG;
        public BackGround BG1;
        public bool Blast;
        public BlastImages Images;
        public HighScore scoore;
        public int xBam;
        public int yBam;
        public Sounds sounds;
        public int TimeLeft;
        public List<cloud> clouds;
        public bool BosFight;
        public Boss boss;
        public List<Rocket> bossRockets;
//Public constructor
        public GameWindow()
        {
            InitializeComponent();
            Run();
          
        }
//Function to re-load the scene if we want to play again.  
        public void Run()
        {
            // Get max Width and max height of the Form
                    maxWidth = this.ClientSize.Width;
                    maxHeight = this.ClientSize.Height;
            // Make the players 
                    playerPlane = new PlayerPlane(maxWidth, maxHeight);
            //Make enemy planes and fill the list
                    Planes = new List<EnemyPlane>();
                    fillList();
            //Make the Boss and his Rocket
                    boss = new Boss(300, 20, this.ClientSize.Width);
                    bossRockets = new List<Rocket>();
            //Check if there is a boss on the screen
                    BosFight = false;
            // Set the Backgounds [2 Backgrounds repeteng them selfs]
                    BG = new BackGround(-764);
                    BG1 = new BackGround(0);
            //Make Clouds on the screen
                    clouds = new List<cloud>();
                    fillClouds();
            // Set the buffer
                    this.DoubleBuffered = true;
            // Set the Blast Image, Scores, Remaining lifes, Time left, and Boss HP bar 
                    Blast = false;
                    Images = new BlastImages();
                    scoore = new HighScore();
                    ScoreLabel.Text =string.Format("High Score: {0}",scoore.getScore());
                    RemainingLifes.Text =string.Format("Player Lifes: {0}",playerPlane.getPlayerLife());
                    TimeLeft = 180;
                    BosLife.Visible = false;
                    BosLife.Value = boss.getLife();
            //Set the sounds
                    sounds = new Sounds();
                    sounds.playMainMusic();
            //Get the timers Ready
                    GameTimer.Enabled = true;
                    PlayerTime.Enabled = true;
        }
//Function to fill the list with clouds
        public void fillClouds()
        {
            Random ran = new Random();
            for(int i=0;i<6;i++)
                clouds.Add(new cloud(ran.Next(900),-ran.Next(1000),ran.Next(3)));
        }
// Function to fill the list with enemy planes
        public void fillList()
        {
            Random random = new Random();
            for (int i = Planes.Count; i < 10; i++)
            {
                Planes.Add(new EnemyPlane(random.Next(750), -random.Next(1000),random.Next(3)));

            }
        
        }
// Function to move the Player Plane 
        private void MovePlayerPlane(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                playerPlane.moveRight();
            if (e.KeyCode == Keys.Left)
                playerPlane.moveLeft();
            if (e.KeyCode == Keys.Up)
                playerPlane.moveUp();
            
            if (e.KeyCode == Keys.Down)
                playerPlane.moveDown();
        }

//Function to paint on the FORM (repaint also)
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           // Clear the screen
                e.Graphics.Clear(Color.White);
           // Set the Background
                      BG.Draw(e.Graphics);
           // Set the upper Background
                      BG1.Draw(e.Graphics);
           //Draw clouds
                      foreach (cloud t in clouds) t.Draw(e.Graphics);
           //Draw the player Rockets 
                for (int i = 0; i < playerPlane.getFiredRocekts().Count; i++)
                {
                      playerPlane.getFiredRocekts()[i].Draw(e.Graphics);
                }
           //Draw Bullets
                for (int i = 0; i < playerPlane.getFiredBullets().Count; i++)
                {
                     playerPlane.getFiredBullets()[i].Draw(e.Graphics);
                }
           //Check if the Boss Fight is taking place
                if (!BosFight)
                {
                    //Draw enemy plain at last possition             
                    for (int i = 0; i < Planes.Count; i++)
                    {
                        Planes[i].Draw(e.Graphics);
                    }
                    //Draw "Bam picture" if a enemy plane has been destroyed
                    if (Blast)
                    {
                        Blast = false;
                        e.Graphics.DrawImage(Images.getWinImg(), xBam, yBam);
                    }
                }
           //Draw the Boss and his Rockets
                else
                {
                    boss.Draw(e.Graphics);
                    foreach (Rocket r in bossRockets) r.Draw(e.Graphics);
                }
          //Check if the player is dead to draw the last image 
               if (playerPlane.getPlayerLife() == 0)
               {
                   e.Graphics.DrawImage(Images.getLoseImg(), playerPlane.getX(), playerPlane.getY());
               }
         // Draw the player plane 
               else
               {
                   playerPlane.Draw(e.Graphics);
               }
         }
//Function to move the enemy plane and check if the enemy plane hit the player plane
        private void EnemyPlaneMove()
        {
            for (int i = 0; i < Planes.Count; i++)
            {
                Rectangle r1 = new Rectangle(playerPlane.getX(), playerPlane.getY(), playerPlane.getImage().Width, playerPlane.getImage().Height);
                Rectangle r2 = new Rectangle(Planes[i].getX(), Planes[i].getY(), Planes[i].getImg().Width, Planes[i].getImg().Height);
                if (!Planes[i].enemyPlaneOnTheMove(maxHeight))
                {
                    Planes.Remove(Planes[i]);
                }
                if (r1.IntersectsWith(r2))
                {

                    Planes.Remove(Planes[i]);
                    playerPlane.setPlayerLife(playerPlane.getPlayerLife() - 1);
                  
                }
            }
           if (Planes.Count < 10) fillList();

        }
//Function to move the Player Rockets and Check if we have hit a EnemyPlane or the Boss
        public void moveTheRocekts()
        {
            for (int i = 0; i < playerPlane.getFiredRocekts().Count; i++)
            {
                playerPlane.moveUpFiredRocket(i);


                if (playerPlane.getFiredRocekts()[i].getY() < 0)
                {
                    playerPlane.removeRocket(i);
                }
                else
                {
                    if (!BosFight)
                    {
                        for (int y = 0; y < Planes.Count; y++)
                        {
                            Rectangle r1 = new Rectangle(playerPlane.getFiredRocekts()[i].getX(), playerPlane.getFiredRocekts()[i].getY(), playerPlane.getFiredRocekts()[i].getImage().Width, playerPlane.getFiredRocekts()[i].getImage().Height);
                            Rectangle r2 = new Rectangle(Planes[y].getX(), Planes[y].getY(), Planes[y].getImg().Width, Planes[y].getImg().Height);

                            if (r1.IntersectsWith(r2))
                            {
                                playerPlane.removeRocket(i);
                                Planes.Remove(Planes[y]);
                                fillList();
                                scoore.UpdateMissileScore();
                                Blast = true;
                                xBam = r1.X;
                                yBam = r1.Y;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Rectangle r1 = new Rectangle(playerPlane.getFiredRocekts()[i].getX(), playerPlane.getFiredRocekts()[i].getY(), playerPlane.getFiredRocekts()[i].getImage().Width, playerPlane.getFiredRocekts()[i].getImage().Height);
                        Rectangle b = new Rectangle(boss.getX(), boss.getY(), boss.getImg().Width, boss.getImg().Height);
                        if (r1.IntersectsWith(b))
                        {
                            boss.loseLife();
                            BosLife.Value = boss.getLife();
                            playerPlane.removeRocket(i);
                        }
                    }

                }

            }
        }
//Function to move the Player Bullets and check if they hit or destroyed a EnemyPlane
        public void moveTheBullets()
        {
            for (int i = 0; i < playerPlane.getFiredBullets().Count; i++)
            {
                playerPlane.moveUpBullets(i);


                if (playerPlane.getFiredBullets()[i].getY() < 0)
                {
                    playerPlane.removeBullet(i);
                }
                else
                {
                    for (int y = 0; y < Planes.Count; y++)
                    {
                        Rectangle r1 = new Rectangle(playerPlane.getFiredBullets()[i].getX(), playerPlane.getFiredBullets()[i].getY(), playerPlane.getFiredBullets()[i].getImage().Width, playerPlane.getFiredBullets()[i].getImage().Height);
                        Rectangle r2 = new Rectangle(Planes[y].getX(), Planes[y].getY(), Planes[y].getImg().Width, Planes[y].getImg().Height);

                        if (r1.IntersectsWith(r2))
                        {
                            playerPlane.removeBullet(i);
                            Planes[y].LoseLife();
                            if (Planes[y].LIFE() <= 0)
                            {
                                Planes.Remove(Planes[y]);
                               fillList();
                                scoore.UpdateBulletScore();
                                Blast = true;
                                xBam = r1.X;
                                yBam = r1.Y;
                            }
                            break;
                        }
                    }

                }

            }
        }
// Function to fire  1. Mashine gun at LMB  or 2. Rockets ar RMB   *(Mashine gun won't damage the boss)
        private void FireRocket(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                playerPlane.fireRocket();
            }
            if (e.Button == MouseButtons.Left)
            {
                playerPlane.fireBullet();
              }
        }
//Start the Game
        private void GameTimer_Start(object sender, EventArgs e)
        {
            Invalidate();
            BG.BackGroundMove();
            BG1.BackGroundMove();
            moveTheRocekts();
            moveTheBullets();
            if (!BosFight) EnemyPlaneMove();
            else
            {
                boss.move();
                moveBossRocket();
            }
            moveClouds();
            int min = TimeLeft / 60;
            int sec = TimeLeft % 60;
            TimerLabel.Text = string.Format("{0:00}:{1:00}", min, sec);
            ScoreLabel.Text = string.Format("High Score: {0}", scoore.getScore());
            RemainingLifes.Text =string.Format("Player Lifes: {0}", playerPlane.getPlayerLife());
            if (TimeLeft == 60) { BosFight = true; BosRocketTimer.Enabled = true; BosLife.Visible = true; }
            if (playerPlane.getPlayerLife() == 0 || TimeLeft==0)
            {

                freezScreen();
                sounds.playGameOverMusic();
                if (MessageBox.Show(string.Format("You lost.\nHigh score: {0}\t Time left: {1}:{2}\nDo you want to play again ?", scoore.getScore(), TimeLeft / 60, TimeLeft % 60), "Game Over", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Run();
                }
                else
                {
                    
                    Close();
                }
            }
            else if (boss.getLife() == 0)
            {
                freezScreen();
                sounds.playMissionComplete();
                ScoreLabel.Text = string.Format("High Score: {0}", scoore.getScore()+10000);
                if (MessageBox.Show(string.Format("You wooooon\nHigh score: {0}\t  Time left: {1}:{2}\t Lifes: {3}\nDo you want to play again ?", scoore.getScore() + 10000, TimeLeft / 60, TimeLeft % 60,playerPlane.getPlayerLife()), "You won !!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Run();
                }
                else
                {
                     Close();
                }
            }
            
        }
//Decrease the TimeLeft for the game
        private void UpdateTimeSpent(object sender, EventArgs e)
        {
            TimeLeft--;
        }
//Move the clouds on the screen
        public void moveClouds()
        {
            for(int i=0;i<clouds.Count;i++)
            {
                if(!clouds[i].moveCloud())
                    clouds.Remove(clouds[i]);
            }
            if (clouds.Count < 6) fillClouds();
        }
//Boss fire each rocket on 1.5seconds
        private void BossFireRocket(object sender, EventArgs e)
        {
            Rocket r = new Rocket(boss.RX(), boss.RY()); r.Reset();
            bossRockets.Add(r);
        }
//Move the Boss rcokets on the screen
        public void moveBossRocket()
        {
            for (int i = 0; i < bossRockets.Count; i++)
            {
                Rectangle roc = new Rectangle(bossRockets[i].getX(),bossRockets[i].getY(),bossRockets[i].getImage().Width, bossRockets[i].getImage().Height);
                Rectangle r1 = new Rectangle(playerPlane.getX(), playerPlane.getY(), playerPlane.getImage().Width, playerPlane.getImage().Height);
                if (roc.IntersectsWith(r1))
                {
                    playerPlane.loseLife();
                    bossRockets.Remove(bossRockets[i]);
                }
                else if (bossRockets[i].getY() > 780)
                {
                    bossRockets.Remove(bossRockets[i]);
                }
                else bossRockets[i].moveRocket();
            }
        }
//Freez the screen and disable all the timers
        public void freezScreen()
        {
            PlayerTime.Enabled = false;
            BosRocketTimer.Enabled = false;
            GameTimer.Enabled = false;
        }
    }
}