using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lamboda_Run
{
    internal class Cars
    {

        public int x, y;
        public int xSpeed = 6;
        public int ySpeed = 6;
        public int size = 15;

        public Cars(int _x, int _y, int _ySpeed, int _xSpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move()
        {

            y += ySpeed;


            //if (y > Height - size || y < 0)
            //{
                
            //}
        }

        public bool Collision(Player p)
        {
            Rectangle carRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (carRec.IntersectsWith(playerRec))
            {
                if (ySpeed > 0)
                {
                    y = p.y - size;
                }
                else
                {
                    y = p.y + p.height;
                }
                ySpeed *= -1;

                GameScreen.lives--;
 
                return true;
            }
            return false;
        }
    }
}
