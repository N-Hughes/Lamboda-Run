using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamboda_Run
{
    internal class Player
    {
        public int x, y;
        public int speed = 5;
        public int height = 9;
        public int width = 28;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
            
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }

            if (direction == "left")
            {
                x -= 104;
            }
            if (direction == "right")
            {
                x += 104;
            }

        }
    }
}
