using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CYPVP
{
    public class Game
    {
        public Character MainCharacter { get; set; }

        public  Slime MainSlime { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }



        public Game(int height,int width,PictureBox mainCharacter,PictureBox mainSlime) {
            MainCharacter = new Character(mainCharacter);
            MainSlime=new Slime(mainSlime);
            Time = 90;
            Score = 0;
        }

        internal void MoveCharacter(int Height,int Width)
        {
            if (MainCharacter.CanMoveUp)
            {
                MainCharacter.Move("UP", 15, Height, Width,MainSlime.SlimeSkin.Location.X, MainSlime.SlimeSkin.Location.Y);
            }
            else if (MainCharacter.CanMoveDown)
            {
                MainCharacter.Move("DOWN", 15, Height, Width, MainSlime.SlimeSkin.Location.X, MainSlime.SlimeSkin.Location.Y);
            }
            else if (MainCharacter.CanMoveLeft)
            {
                MainCharacter.Move("LEFT", 15, Height, Width, MainSlime.SlimeSkin.Location.X, MainSlime.SlimeSkin.Location.Y);
            }
            else if (MainCharacter.CanMoveRight)
            {
                MainCharacter.Move("RIGHT", 15, Height, Width, MainSlime.SlimeSkin.Location.X, MainSlime.SlimeSkin.Location.Y);
            }
            
        }

        internal void MoveSlime()
        {
            MainSlime.Move((int)MainCharacter.CharacterSkin.Location.X, (int)MainCharacter.CharacterSkin.Location.Y);
        }
    }
}
