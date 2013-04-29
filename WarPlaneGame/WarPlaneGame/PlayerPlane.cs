using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class PlayerPlane
    {
        // Image of the player Plane
        private Bitmap playerPlaneImg;
        // Player Life and Speed and List of Active Rockets
        private int playerLife; // { get; set; }
        private int playerSpeed;// { get; set; }
        private List<Rocket> FiredRockets;
       //Start-up Poissitions 
        private int X; 
        private int Y;
        // Window size and bounds
        private int maxWidth;
        private int maxHeight;
       
        public PlayerPlane(int formWidth,int formHeight)  
        {
          // Set Image of the Player Plnae
            playerPlaneImg = new Bitmap("D:\\documents\\visual studio 2012\\Projects\\WarPlaneGame\\WarPlaneGame\\Resources\\img\\MIG-small.png");
         // Set Player Life and Speed and List Active Rockets
            playerLife = 5;
            playerSpeed = 10;
            FiredRockets = new List<Rocket>();
         //Set start-up positions
            X = formWidth / 2;
            Y = formHeight - playerPlaneImg.Size.Height-15;
         // Set bounds
            maxWidth = formWidth - playerPlaneImg.Width-5;
            maxHeight = formHeight - playerPlaneImg.Height;
        }

        // Functions to move the player on the screen
        public void moveLeft()
        {
            int t = X - playerSpeed;
            if (t > 0) X = t;
        }
        public void moveRight()
        {
            int t = X + playerSpeed;
            if (t < maxWidth - 10) X = t;
        }
        public void moveUp()
        {
            int t = Y - playerSpeed;
            if (t > 0) Y = t;
        }
        public void moveDown()
        {
            int t = Y + playerSpeed;
            if (t < maxHeight - 10) Y = t;
        }

        // Fire a rocket 
        public void fireRocket()
        {
            FiredRockets.Add(new Rocket(X + 30, Y));
        }
        // Delete a Rocket
        public void removeRocket(int i)
        {
            FiredRockets.Remove(FiredRockets[i]);
        }



        // Getters and Setters
        public int getX()
        {
            return X;
        }
        public void setX(int x)
        {
            X = x;
        }

        public int getY()
        {
            return Y;
        }
        public void setY(int y)
        {
            Y = y;
        }
        public int getSpeed()
        {
            return playerSpeed;
        }
        public Bitmap getImage()
        {
            return playerPlaneImg;
        }
        public int getPlayerLife()
        {
            return playerLife;
        }
        public void setPlayerLife(int life)
        {
            playerLife = life;
        }
        public int getMaxWidth()
        {
            return maxWidth;
        }
        public List<Rocket> getFiredRocekts()
        {
            return FiredRockets;
        }
        public void moveUpFiredRocket(int i)
        {
            FiredRockets[i].moveRocket();
        }
    }
}
