using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public partial class CYPVP : Form
    {
        public MainMenu Menu { get; set; }
       
        public CYPVP()
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

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.StartPosition=FormStartPosition.Manual;
            help.Location = this.Location;
            this.Hide();
            Menu.Stop();
            if(help.ShowDialog() == DialogResult.Cancel) {
                this.Show();
                Menu.Play();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.StartPosition = FormStartPosition.Manual;
            gameWindow.Location = this.Location;
            this.Hide();
            Menu.Stop();
            if (gameWindow.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                Menu.Play();
            }
        }
    }
}
