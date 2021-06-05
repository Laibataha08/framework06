using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class ChangingMovement : ICollisionBehaviour
    {
        public void behaviour(GameObject G2 )
        {
           
            G2.pictureBox.Visible = false ; // enemy will die
            
        }

    }
}
