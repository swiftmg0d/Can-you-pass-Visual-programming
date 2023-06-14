using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public partial class GameWindow : Form
    {
        private Game Game { get; set; }

        public GameWindow()
        {
            InitializeComponent();
            Movements.Interval = 200;
            Movements.Start();
            DoubleBuffered = true;
            Game=new Game(this.Height,this.Width);
            
        }



        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                if (Game.CanMoveUp == false)
                {
                    Character.Image = Properties.Resources.up_running;
                }
                Game.CanMoveUp = true;

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                if (Game.CanMoveDown == false)
                {
                    Character.Image = Properties.Resources.down_running;
                }
                Game.CanMoveDown = true;
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                if (Game.CanMoveRight == false)
                {
                    Character.Image = Properties.Resources.right_running;
                }
                Game.CanMoveRight = true;

            }
            else if (e.KeyValue == (char)Keys.A)
            {
                if (Game.CanMoveLeft == false)
                {
                    Character.Image = Properties.Resources.left_running;
                }
                Game.CanMoveLeft = true;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                Game.CanMoveUp = false;
                if (Game.Check())
                {
                    Character.Image = Properties.Resources.up_standing;
                }
                
            }
            else if (e.KeyValue == (char)Keys.S)
            {
                Game.CanMoveDown = false;
                if (Game.Check())
                {
                    Character.Image = Properties.Resources.down_standing;
                }
       
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                Game.CanMoveRight = false;
                if (Game.Check())
                {
                    Character.Image = Properties.Resources.right_standing;

                }
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                Game.CanMoveLeft = false;
                if (Game.Check())
                {
                    Character.Image = Properties.Resources.left_standing;

                }
            }
        }


        private void Movements_Tick(object sender, EventArgs e)
        {
            if (Game.CanMoveUp)
            {
                Game.MoveCharachter(Character, "UP",15);
            }
            else if (Game.CanMoveDown)
            {
                Game.MoveCharachter(Character, "DOWN",15);
            }
            else if (Game.CanMoveLeft)
            {
                Game.MoveCharachter(Character, "LEFT",15);
            }
            else if (Game.CanMoveRight)
            {
                Game.MoveCharachter(Character, "RIGHT",15);

            }
        }

       

    }
}

