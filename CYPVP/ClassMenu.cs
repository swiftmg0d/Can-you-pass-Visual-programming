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
    public partial class ClassMenu : Form
    {
        public ClassMenu()
        {
            InitializeComponent();
        }
  
        private void btn_CS_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GameWindow gameWindow = new GameWindow("Hard");
            this.Hide();
            if (gameWindow.ShowDialog() == DialogResult.Cancel)
            {
                Application.OpenForms["CYPVP"].Show();
                CYPVP.Menu.Play();
            }


        }

        private void btn_AIT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GameWindow gameWindow = new GameWindow("Easy");
            this.Hide();
            if (gameWindow.ShowDialog() == DialogResult.Cancel)
            {
                Application.OpenForms["CYPVP"].Show();
                CYPVP.Menu.Play();
            };
           

        }
    }
}
