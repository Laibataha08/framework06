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
    class movewithkeyboard: IMovement
    {

        private static movewithkeyboard a;
        bool up;
        bool down;
        bool left;
        bool right;


        public void typeofmovement(int speed, PictureBox picturebox)
        {
            movePLayer(speed, picturebox);

        }

        private void movePLayer(int speed, PictureBox picturebox)
        {
            if (left)
            {
                picturebox.Left -= speed;
            }

            if (right)
            {
                picturebox.Left += speed;
            }
            if (up)
            {
                picturebox.Top -= speed;
            }

            if (down)
            {
                picturebox.Top += speed;
            }
        }

        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                left = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
        }

        public void KeyUpEvent(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {

                left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }


    }
}
