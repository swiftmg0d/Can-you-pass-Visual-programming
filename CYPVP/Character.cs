using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public class Character
    {
        public PictureBox CharacterSkin { get; set; }
        public bool CanMoveUp { get; set; }
        public bool CanMoveDown { get; set; }
        public bool CanMoveRight { get; set; }
        public bool CanMoveLeft { get; set; }
        public Character(PictureBox Character)
        {
            CharacterSkin = Character;
            CharacterSkin.BackColor = Color.Transparent;
        }
        public void Move(String Position,int Speed,int Height,int Width,int x,int y)
        {
            
           
            
                if (Position == "UP")
                {
                    int NewPosition = CharacterSkin.Location.Y - Speed;
                    if (NewPosition >= 80d)
                    {
                    
                   
                        CharacterSkin.Location = new Point(CharacterSkin.Location.X, NewPosition);

 
                }

                }
                else if (Position == "DOWN")
                {
                    int NewPosition = CharacterSkin.Location.Y + Speed;
                    if (NewPosition < Height - 100)
                    {
                    
                        CharacterSkin.Location = new Point(CharacterSkin.Location.X, NewPosition);

                    
                }

                }
                else if (Position == "RIGHT")
                {
                    int NewPosition = CharacterSkin.Location.X + Speed;
                    if (NewPosition < Width - 70)
                    {
                    
                        CharacterSkin.Location = new Point(NewPosition, CharacterSkin.Location.Y);
                    
                    
                    }

                }
                else if (Position == "LEFT")
                {
                    int NewPosition = CharacterSkin.Location.X - Speed;
                    if (NewPosition >= 10)
                    {
                    
                        CharacterSkin.Location = new Point(NewPosition, CharacterSkin.Location.Y);
                    
                  

                    }
                }
            

            
        }
        public bool Check()
        {
            return CanMoveDown == false && CanMoveUp == false && CanMoveLeft == false && CanMoveRight == false;
        }
    }
}
