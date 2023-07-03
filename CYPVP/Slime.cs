using System;
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
        public Slime(PictureBox slimeskin)
        {
            SlimeSkin = slimeskin;
            Direction = "RIGHT";
            SlimeSkin.Image = Properties.Resources.slime_right;
            isCloseEnough = false;
       
        }

        public void Move(int x, int y)
        {
            if (Math.Abs(SlimeSkin.Location.X - x) < 56 && Math.Abs(SlimeSkin.Location.Y - y) < 56)
            {
                isCloseEnough=true;
            }
            else
            {
                isCloseEnough=false;
                if (SlimeSkin.Location.X + 2 < x)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X + 2, SlimeSkin.Location.Y);
                }
                else if (SlimeSkin.Location.X - 2 > x)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X - 2, SlimeSkin.Location.Y);

                }
                if (SlimeSkin.Location.Y + 2 < y)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X, SlimeSkin.Location.Y + 2);
                }
                else if (SlimeSkin.Location.Y - 2 > y)
                {
                    SlimeSkin.Location = new Point(SlimeSkin.Location.X, SlimeSkin.Location.Y - 2);
                }
            }

            

        }
    }
}
