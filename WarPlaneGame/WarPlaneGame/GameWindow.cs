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
        public int TimeSpent;
        //Public constructor
        public GameWindow()
        {
            InitializeComponent();
            // Get max Width and max height of the Form
            maxWidth = this.ClientSize.Width;
            maxHeight = this.ClientSize.Height;
            // Make the players 
            playerPlane = new PlayerPlane(maxWidth, maxHeight);
            //Make enemy planes and fill the list
            Planes = new List<EnemyPlane>();
            fillList();
            // Set the Backgounds [2 Backgrounds repeteng them selfs]
            BG = new BackGround(-764);
            BG1 = new BackGround(0);
            // Set the buffer
            this.DoubleBuffered = true;
          //  SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // Set the Blast Image and Scores 
            Blast = false;
            Images = new BlastImages();
            scoore = new HighScore();
            ScoreLabel.Text = "High Score: " + scoore.getScore().ToString();
            RemainingLifes.Text = "Player Lifes: " + playerPlane.getPlayerLife().ToString();
            //Set the sounds
            sounds = new Sounds();
            sounds.playMainMusic();
            GameTimer.Enabled = true;
            TimeSpent = 0;
          
        }

        // Function to fill the list with enemy planes
        public void fillList()
        {
           
            Random random = new Random();
            for (int i = Planes.Count; i < 10; i++)
            {
                Planes.Add(new EnemyPlane(random.Next(750), -random.Next(1000)));

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
              e.Graphics.DrawImage(BG.getImg(), BG.getX(), BG.getY());
               // Set the upper Background
              e.Graphics.DrawImage(BG1.getImg(), BG1.getX(), BG1.getY());
                //Draw the player Rockets 
                for (int i = 0; i < playerPlane.getFiredRocekts().Count; i++)
                {
                    e.Graphics.DrawImage(playerPlane.getFiredRocekts()[i].getImage(), playerPlane.getFiredRocekts()[i].getX(), playerPlane.getFiredRocekts()[i].getY());
                }
                //Draw Bullets
                for (int i = 0; i < playerPlane.getFiredBullets().Count; i++)
                {
                    e.Graphics.DrawImage(playerPlane.getFiredBullets()[i].getImage(), playerPlane.getFiredBullets()[i].getX(), playerPlane.getFiredBullets()[i].getY());
                }
               // Draw enemy plain at last possition             
                for (int i = 0; i < Planes.Count; i++)
                {
                    e.Graphics.DrawImage(Planes[i].getImg(), Planes[i].getX(), Planes[i].getY());
                }
               if (Blast)
                {
                    Blast = false;
                    e.Graphics.DrawImage(Images.getWinImg(), xBam, yBam);
                }
              //Check if dead to draw the last image
               if (playerPlane.getPlayerLife() == 0)
               {
                   e.Graphics.DrawImage(Images.getLoseImg(), playerPlane.getX(), playerPlane.getY());

                   sounds.playGameOverMusic();
               }
               else
               {
                   // Draw the player plane 
                   e.Graphics.DrawImage(playerPlane.getImage(), playerPlane.getX(), playerPlane.getY());
               }
                
            

        }

        //Function to move the enemy plane
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
                    RemainingLifes.Text = "Player Lifes: " + playerPlane.getPlayerLife().ToString();
                }
            }
           if (Planes.Count < 10) fillList();

        }
        //Function to move the Player Rockets
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
                            sounds.playExplosions();
                            break;
                        }
                    }

                }

            }
        }
        //Function to move the Player Bullets
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
        // Function to fire  1. Mashine gun at LMB  or 2. Rockets ar RMB
        private void FireRocket(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sounds.playRocket();
                playerPlane.fireRocket();
            }
            if (e.Button == MouseButtons.Left)
            {
                playerPlane.fireBullet();
                sounds.playMashineGun();
            }
        }

        private void GameTimer_Start(object sender, EventArgs e)
        {
            Invalidate();
            BG.BackGroundMove();
            BG1.BackGroundMove();
            moveTheRocekts();
            moveTheBullets();
            EnemyPlaneMove();
            ScoreLabel.Text = "High Score: " + scoore.getScore().ToString();
            if (playerPlane.getPlayerLife() == 0)
            {
                GameTimer.Enabled = false;
                PlayerTime.Enabled = false;

                MessageBox.Show("dasd "+TimeSpent);
            }
        }

        private void CountTime(object sender, EventArgs e)
        {
            TimeSpent++;
        }
    }
}