using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public class Star
    {
        public PictureBox StarSkin { get; set; }
        public bool IsEaten { get; set; }
        public bool isSelected { get; set; }

        public Star(PictureBox starSkin)
        {
            StarSkin = starSkin;
            IsEaten = false;
            isSelected = false;
        }
    }
}
