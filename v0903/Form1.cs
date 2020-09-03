using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - ClientSize.Width);
            label1.Top = rand.Next(ClientSize.Height - ClientSize.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            Point mp = MousePosition;
            mp = PointToClient(mp);

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width) 
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if((label1.Left <= mp.X) && 
                (label1.Right > mp.X)&&
                (label1.Top<=mp.Y)&&
                (label1.Bottom>mp.Y))
            {
                timer1.Enabled = false;
                label1.Text = "(/・ω・)/";
            }
        }
    }
}
