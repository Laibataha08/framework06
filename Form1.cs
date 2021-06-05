using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Game game;
        Factory f;
        MovementFactory mf;
        GameObject G2;
        GameObject G1;
        

        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            movewithkeyboard key = new movewithkeyboard();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(key.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(key.KeyUpEvent);
            game.update();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            game = Game.getInstance();
            f = Factory.getInstance();
            mf = MovementFactory.getInstance();
           
            IMovement m1 = mf.getobjects(typeof(movewithkeyboard));
            IMovement m2 = mf.getobjects(typeof(MoveLeft));
            IMovement m3 = mf.getobjects(typeof(MoveRight));
            IMovement m4 = mf.getobjects(typeof(Falling));
            

            G1 = f.createObjects(pictureBox1, m1 , 2, Gametype.player);
            G2 = f.createObjects(pictureBox2, m2, 2, Gametype.ghost);
            GameObject G3 = f.createObjects(pictureBox3, m3 , 2, Gametype.ghost);
            GameObject G4 =  f.createObjects(pictureBox4, m4 , 3, Gametype.ghost);
            pictureBox1.Visible = true;

            int countplayer = f.getplayercount();
            label1.Text = "player : " + countplayer;
            int countenemy = f.getenemycount();
            label2.Text = "ghost : " + countenemy;

            game.AddObjects(G1);
            game.AddObjects(G2);
            game.AddObjects(G3);
            game.AddObjects(G4);
            CollisionDetection CD1 = new CollisionDetection(Gametype.player, Gametype.ghost ,new ChangingMovement());
            game.AddCollision(CD1);

            mf.releaseObjects(m1);
            IMovement m5 = mf.getobjects(typeof(movewithkeyboard));
            GameObject G5 = f.createObjects(pictureBox5, m5, 3, Gametype.player);
            game.AddObjects(G5);

            int totalnumber = mf.totalobjects();
            label3.Text = "totalobjects : " + totalnumber;

        } 

    }
}
