using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WarPlaneGame
{
    public class Collision
    {
        
        public static bool Detect(EnemyPlane enemyPlane, PlayerPlane playerPlane)
        {
           // All 4 Players themes 
            Point p1 = new Point(playerPlane.getX(), playerPlane.getY());
            Point p2 = new Point(playerPlane.getX() + playerPlane.getImage().Width, playerPlane.getY());
            Point p3 = new Point(playerPlane.getX() + playerPlane.getImage().Width,playerPlane.getY() + playerPlane.getImage().Height);
            Point p4 = new Point(playerPlane.getX(),  playerPlane.getY() + playerPlane.getImage().Height);
            // All 4 Enemeys themes
            Point e1 = new Point(enemyPlane.getX(), enemyPlane.getY());
            Point e2 = new Point(enemyPlane.getX() + enemyPlane.getImg().Width, enemyPlane.getY());
            Point e3 = new Point(enemyPlane.getX() + enemyPlane.getImg().Width, enemyPlane.getY() + enemyPlane.getImg().Height);
            Point e4 = new Point(enemyPlane.getX(), enemyPlane.getY() + enemyPlane.getImg().Height);
             
         Rectangle r1 = new Rectangle(playerPlane.getX(),playerPlane.getY(),playerPlane.getImage().Width,playerPlane.getImage().Height);
         return false;
            //Now to check if there is a interfiring 
        //    bool OutSideBottom =
          //      playerPlane.getImg().GetBounds.Bottom < enemyPlane.getImg().GetBounds().Top;
            
/*
            GraphicsUnit o1Bounds = GraphicsUnit.Point;
            RectangleF Rect1 = o1.GetBounds(ref o1Bounds);
            GraphicsUnit o2Bounds = GraphicsUnit.Point;
            RectangleF Rect2 = o2.GetBounds(ref o2Bounds);


          bool OutsideBottom = Rect1.Bottom < Rect2.Top;
          bool OutsideTop = Rect1.Top > Rect2.Bottom;
          bool OutsideLeft = Rect1.Left > Rect2.Right;
          bool OutsideRight = Rect1.Right < Rect2.Left;

            return !(OutsideBottom || OutsideTop || OutsideLeft || OutsideRight);
*/
  /*          Rectangle r1 = new Rectangle(object1.getX(), object1.getY(), object1.getImg().Width, object1.getImg().Height);
            Rectangle r2 = new Rectangle(object2.getX(), object2.getY(), object2.getImage().Width, object2.getImage().Height);

            bool OutsideBottom = r1.Bottom < r2.Top;
            bool OutsideTop = r1.Top > r2.Bottom;
            bool OutsideLeft = r1.Left > r2.Right;
            bool OutsideRight = r1.Right < r2.Left;

          //return r1.IntersectsWith(r2);
            return !(OutsideBottom || OutsideTop || OutsideLeft || OutsideRight);
   */
        }
    }
}
