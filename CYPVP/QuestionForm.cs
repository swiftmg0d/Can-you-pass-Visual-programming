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
    public partial class QuestionForm : Form
    {
        public String Answer { get; set; }
        public SoundPlayer SoundPlayer { get; set; }
        public QuestionForm(string question, string answer)
        {
            InitializeComponent();      
            Answer = answer;
            lb_Text.Text = question;  
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            if (Answer == "Yes")
            {
                SoundPlayer = new SoundPlayer(Properties.Resources.Correct_Answer_Sound_Effect);
                SoundPlayer.Play();
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                SoundPlayer = new SoundPlayer(Properties.Resources.Incorrect_sound_effect);
                SoundPlayer.Play();
                this.DialogResult = DialogResult.Cancel;
                
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            if(Answer == "No")
            {
                SoundPlayer = new SoundPlayer(Properties.Resources.Correct_Answer_Sound_Effect);
                SoundPlayer.Play();
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                SoundPlayer = new SoundPlayer(Properties.Resources.Incorrect_sound_effect);
                SoundPlayer.Play();
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
