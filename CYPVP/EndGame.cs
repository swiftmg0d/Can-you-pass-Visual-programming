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
    public partial class EndGame : Form
    {
        public int Points { get; set; }
        public SoundPlayer soundPlayer { get; set; }
        
        public EndGame(int points)
        {
            InitializeComponent();
            Points = points;
            lb_Points.Text = Points.ToString();
            if (GetGrade() == 10)
            {
                lb_Grade.Text = "10";
            }else if(GetGrade() == 4)
            {
                lb_Grade.Text = "5";
            }
            else
            {
                lb_Grade.Text = $"{GetGrade() + 1}";
            }
            if (GetGrade() > 5)
            {
                label3.Text = "Yeyy you passed Visual Programming";
                soundPlayer = new SoundPlayer(Properties.Resources.Yayyy_Sound_Effect);
                soundPlayer.Play();
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Epic_Fail_Sound_Effect);
                soundPlayer.Play();
            }
        }

        public int GetGrade()
        {
            if ((int)(Points / 10) < 5) return 4;
            if ((int)(Points / 10) >= 10) return 10;
            return (int)(Points / 10);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["CYPVP"].Show();
            CYPVP.Menu.Play();
        }
    }
}
