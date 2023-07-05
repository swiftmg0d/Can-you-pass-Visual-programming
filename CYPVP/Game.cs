﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace CYPVP
{
    public class Game
    {
        public Character MainCharacter { get; set; }
        public List<Star> List0fStars { get; set; }
        public SoundPlayer CollectCoinSound { get; set; }
        public int SlimeRadiationPoints { get; set; }

        public  Slime MainSlime { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }


        
        public Game(int height,int width,PictureBox mainCharacter,PictureBox mainSlime) {
            MainCharacter = new Character(mainCharacter);
            MainSlime=new Slime(mainSlime);
            Time = 79;
            Score = 0;
            List0fStars=new List<Star>();
            CollectCoinSound = new SoundPlayer(Properties.Resources.coin_collect);
           
            SlimeRadiationPoints = 5;
        }

        public static int Distance0f(Point x, Point y)
        {
            return (int)Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
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
       
        internal void CheckIfEaten()
        {
            foreach(Star c in List0fStars)
            {
                if (Distance0f(MainCharacter.CharacterSkin.Location, c.StarSkin.Location) < 30)
                {
                    c.IsEaten = true;
                    Score += 10;
                    
                }
            }


           
        }
    }
}
