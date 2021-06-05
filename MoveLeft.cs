using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp4
{
    class MoveLeft: IMovement
    {
        public void typeofmovement(int speed, PictureBox picturebox)
        {
            picturebox.Left += speed;

        }

    }
}
