using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CYPVP
{
    public partial class GameWindow : Form
    {
        private Game Game { get; set; }
        public int Count { get; set; }
        

        public GameWindow()
        {
            InitializeComponent();
            CharacterMovements.Interval = 200;
            CharacterMovements.Start();
            SlimeMovements.Interval = 200;
            SlimeMovements.Start();
            TimeLeft.Interval = 22500;
            TimeLeft.Start();
            ScorePoints.Interval = 1000;
            ScorePoints.Start();
            DoubleBuffered = true;
            Game=new Game(this.Height,this.Width,Character,Slime);
            Count = 0;
            label2.Text = $"TIMELEFT: {string.Format("{0:00}:{1:00}", Game.Time / 60, Game.Time % 60)}";

        }



        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                if (Game.MainCharacter.CanMoveUp == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.up_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_left;

                }
                Game.MainCharacter.CanMoveUp = true;

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                if (Game.MainCharacter.CanMoveDown == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.down_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_right;

                }
                Game.MainCharacter.CanMoveDown = true;
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                if (Game.MainCharacter.CanMoveRight == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.right_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_right;

                }
                Game.MainCharacter.CanMoveRight = true;

            }
            else if (e.KeyValue == (char)Keys.A)
            {
                if (Game.MainCharacter.CanMoveLeft == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.left_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_left;

                }
                Game.MainCharacter.CanMoveLeft = true;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                Game.MainCharacter.CanMoveUp = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.up_standing;

                }

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                Game.MainCharacter.CanMoveDown = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.down_standing;

                }

            }
            else if (e.KeyValue == (char)Keys.D)
            {
                Game.MainCharacter.CanMoveRight = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.right_standing;

                }
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                Game.MainCharacter.CanMoveLeft = false;
                if (Game.MainCharacter.Check())
                {

                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.left_standing;

                }
            }
        }


        private void Movements_Tick(object sender, EventArgs e)
        {
            Game.MoveCharacter(this.Height,this.Width);
      
        }

        private void SlimeMovements_Tick(object sender, EventArgs e)
        {
            Game.MoveSlime();
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            Count++;
            if(Count == 1) {
                TimeLeftLabel.Image = Properties.Resources._2_statusbar;

            }
            else if(Count == 2) {
                TimeLeftLabel.Image = Properties.Resources._3_statusbar;


            }
            else if(Count == 3) {
                TimeLeftLabel.Image = Properties.Resources._4_statusbar;


            }
            else if(Count == 4)
            {
                TimeLeftLabel.Image = Properties.Resources._5_statusbar;

            }




        }

        private void ScorePoints_Tick(object sender, EventArgs e)
        {
            if (Game.Time >= 0)
            {
                Game.Time--;
            }
            if(Game.MainSlime.isCloseEnough)
            {
                Game.Score--;
            }
            label1.Text = $"POINTS: {Game.Score}";
            label2.Text = $"TIMELEFT: {string.Format("{0:00}:{1:00}", Game.Time / 60, Game.Time % 60)}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

