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
            lbl_heading.BackColor = Color.Transparent;
            lbl_control.BackColor = Color.Transparent;
            lbl_instruction.BackColor=Color.Transparent;
            lbl_instruction1.BackColor = Color.Transparent;    
            Help = new Help(this.Height, this.Width);
        }
        private void HelpWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.W)
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

            if (e.KeyValue == (char)Keys.W)
            {
                Help.CanMoveUp = false;
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

        
    }
}
