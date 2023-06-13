using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public partial class Form1 : Form
    {
        public MainMenu Menu { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            Menu = new MainMenu();
            LoadMenu();
        }

        private void LoadMenu()
        {
            lb_title.BackColor = Color.Transparent;
            lb_title1.BackColor = Color.Transparent;
            lb_version.BackColor = Color.Transparent;
            pb_menu.BackColor = Color.Transparent;
            pb_muteSound.BackColor=Color.Transparent;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_muteSound_Click(object sender, EventArgs e)
        {
            if(Menu.IsMuted==false)
            {
                pb_muteSound.Image = Properties.Resources.mute1;
                Menu.IsMuted = true;
                Menu.Mute();
            }
            else
            {
                pb_muteSound.Image = Properties.Resources.unmute1;
                Menu.IsMuted = false;
                Menu.UnMute();
            }
        }
    }
}
