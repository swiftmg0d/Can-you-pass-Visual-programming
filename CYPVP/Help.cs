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
        public int NewPosition { get; set; }
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
        public void MoveCharachter(PictureBox Charachter, string Position, int Speed)
        {
            if (Position == "UP")
            {
                NewPosition = Charachter.Location.Y - Speed;
                if (NewPosition >= 40)
                {
                    Charachter.Location = new Point(Charachter.Location.X, NewPosition);
                }

            }
            else if (Position == "DOWN")
            {
                NewPosition = Charachter.Location.Y + Speed;
                if (NewPosition < Height - 100)
                {
                    Charachter.Location = new Point(Charachter.Location.X, NewPosition);
                }

            }
            else if (Position == "RIGHT")
            {
                NewPosition = Charachter.Location.X + Speed;
                if (NewPosition < Width - 70)
                {
                    Charachter.Location = new Point(NewPosition, Charachter.Location.Y);
                }

            }
            else if (Position == "LEFT")
            {
                NewPosition = Charachter.Location.X - Speed;
                if (NewPosition >= 10)
                {
                    Charachter.Location = new Point(NewPosition, Charachter.Location.Y);

                }
            }
        }
        public bool Check()
        {
            return CanMoveDown == false && CanMoveUp == false && CanMoveLeft == false && CanMoveRight == false;
        }

    }
}
