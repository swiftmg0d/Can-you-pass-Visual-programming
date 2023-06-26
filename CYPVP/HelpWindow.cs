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
    public partial class HelpWindow : Form
    {
        private Help Help { get; set; }
       

        public HelpWindow()
        {
            InitializeComponent();
            Character.BackColor = Color.Transparent;
            textLabel.BackColor = Color.Transparent;
            MovmentsTick.Interval = 200;
            MovmentsTick.Start();
            DoubleBuffered = true;
            Help = new Help(this.Height, this.Width);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {

        }

        private void HelpWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue==(char)Keys.W)
            {
                if (Help.CanMoveUp == false)
                {
                    Character.Image = Properties.Resources.up_running;
                }
                Help.CanMoveUp = true;

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                if (Help.CanMoveDown == false)
                {
                    Character.Image = Properties.Resources.down_running;
                }
                Help.CanMoveDown = true;
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                if (Help.CanMoveRight == false)
                {
                    Character.Image = Properties.Resources.right_running;
                }
                Help.CanMoveRight = true;

            }
            else if (e.KeyValue == (char)Keys.A)
            {
                if (Help.CanMoveLeft == false)
                {
                    Character.Image = Properties.Resources.left_running;
                }
                Help.CanMoveLeft = true;
            }

        }
        private void HelpWindow_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue==(char)Keys.W)
            {
                Help.CanMoveUp=false;
                if (Help.Check())
                {
                    Character.Image = Properties.Resources.up_standing;
                }

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                Help.CanMoveDown = false;
                if (Help.Check())
                {
                    Character.Image = Properties.Resources.down_standing;
                }

            }
            else if (e.KeyValue == (char)Keys.D)
            {
                Help.CanMoveRight = false;
                if (Help.Check())
                {
                    Character.Image = Properties.Resources.right_standing;

                }
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                Help.CanMoveLeft = false;
                if (Help.Check())
                {
                    Character.Image = Properties.Resources.left_standing;

                }
            }


        }

        private void MovmentsTick_Tick(object sender, EventArgs e)
        {
            if (Help.CanMoveUp)
            {
                Help.MoveCharachter(Character, "UP", 15);
            }
            else if (Help.CanMoveDown)
            {
                Help.MoveCharachter(Character, "DOWN", 15);
            }
            else if (Help.CanMoveLeft)
            {
                Help.MoveCharachter(Character, "LEFT", 15);
            }
            else if (Help.CanMoveRight)
            {
                Help.MoveCharachter(Character, "RIGHT", 15);

            }

        }

       

        private void Character_Click(object sender, EventArgs e)
        {

        }

        private void lb_title1_Click(object sender, EventArgs e)
        {

        }

        private void Character_Click_1(object sender, EventArgs e)
        {

        }
    }
}
