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
    public partial class QuestionForm : Form
    {
        public String Answer { get; set; }
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
                this.DialogResult=DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            if(Answer == "NO")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
