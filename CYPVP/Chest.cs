using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPVP
{
    public class Chest
    {
        public PictureBox ChestSkin { get; set; }
        public bool isOpen { get; set; }
        public bool hasSpawned { get; set; }    

        public Chest(PictureBox chestSkin)
        {
            ChestSkin = chestSkin;
            isOpen = false;
            hasSpawned = false;
           
        }
    }
}
