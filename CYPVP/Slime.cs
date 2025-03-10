﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public class Slime
    {
        public PictureBox SlimeSkin { get; set; }
        public string Direction { get; set; }
        public bool isCloseEnough { get; set; }
        public int speed { get; set; }
        public Slime(PictureBox slimeskin)
        {
            SlimeSkin = slimeskin;
            Direction = "RIGHT";
            SlimeSkin.Image = Properties.Resources.slime_right;
            isCloseEnough = false;
       
        }

        public void Move(int x, int y)
        {
            if (Math.Abs(SlimeSkin.Location.X - x) < 60 && Math.Abs(SlimeSkin.Location.Y - y) < 60)
            {
                isCloseEnough=true;
            }
            else
            {
                
                if (SlimeSkin.Location.X + speed < x)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X + speed, SlimeSkin.Location.Y);
                }
                else if (SlimeSkin.Location.X - speed > x)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X - speed, SlimeSkin.Location.Y);

                }
                 if (SlimeSkin.Location.Y + speed < y)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X, SlimeSkin.Location.Y + speed);
                }
                else if (SlimeSkin.Location.Y - speed > y)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X, SlimeSkin.Location.Y - speed);
                }
                



            }

            

        }
    }
}
