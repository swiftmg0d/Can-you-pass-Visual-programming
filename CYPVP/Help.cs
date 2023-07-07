using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public class Help

    {

        public bool CanMoveUp { get; set; }
        public bool CanMoveDown { get; set; }
        public bool CanMoveRight { get; set; }
        public bool CanMoveLeft { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Help(int height, int width)
        {
            CanMoveDown = false;
            CanMoveLeft = false;
            CanMoveRight = false;
            CanMoveUp = false;
            Height = height;
            Width = width;
        }
       
        public bool Check()
        {
            return CanMoveDown == false && CanMoveUp == false && CanMoveLeft == false && CanMoveRight == false;
        }

    }
}
