using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial
{
    public partial class Form1 : Form
    {
        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        Rectangle area;
        Image beetle = Image.FromFile(Application.StartupPath + @"\beetle.jpg");
        Image beetleright = Image.FromFile(Application.StartupPath + @"\beetle right.jpg");
        Image beetleleft = Image.FromFile(Application.StartupPath + @"\beetle left.jpg");
        Image beetledown = Image.FromFile(Application.StartupPath + @"\beetle down.jpg");


        bool left, right, up, down;

        private void TmrCar_Tick(object sender, EventArgs e)
        {
            if (left) { area.X -= 5; }//move ship 5 to the left
            if (right) { area.X += 5; }// move ship 5 to the right
            if (up) { area.Y -= 5; }//move ship 5 to the up
            if (down) { area.Y += 5; }// move ship 5 to the down
            PanelGame.Invalidate();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false;}
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)  { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

        }

        public Form1()
        {
            InitializeComponent();
            area = new Rectangle(x, y, 30, 30);//spaceship's rectangle	
        }

        private void PanelGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(beetle, area);
            e.Graphics.RotateTransform(20.0F);
            e.Graphics.DrawImage(beetle, new Rectangle(5, 5, 30, 40));
        }

    }
}
