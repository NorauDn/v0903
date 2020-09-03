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
        int[] vx = new int[2000]; 
        int [] vy = new int[2000];
        Label[] labels = new Label[2000];
        int time = rand.Next(-20, 11);

        static Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<2000;i++)
            {
                vx[i] = rand.Next(-20, 21);
                vy[i] = rand.Next(-20, 21);

                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "ﾐ゜";
                Controls.Add(labels[i]);

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Left = rand.Next(ClientSize.Width - ClientSize.Width);
            label1.Top = rand.Next(ClientSize.Height - ClientSize.Height);
            label1.Text = "(*´ω｀*)";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx[0];
            label1.Top += vy[0];
            label2.Left += vx[1];
            label2.Top += vy[1];
            label3.Left += vx[2];
            label3.Top += vy[2];

            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if (label1.Right > ClientSize.Width) 
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }

            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label2.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }

            Point mp = PointToClient(MousePosition);
            if((label1.Left <= mp.X) && 
                (label1.Right > mp.X)&&
                (label1.Top <= mp.Y)&&
                (label1.Bottom > mp.Y))
            {
                timer1.Enabled = false;
                label1.Text = "(/・ω・)/";
            }

            if ((label3.Left <= mp.X) &&
                (label3.Right > mp.X) &&
                (label3.Top <= mp.Y) &&
                (label3.Bottom > mp.Y))
            {
                label3.Left = rand.Next(ClientSize.Width - label3.Width);
                label3.Top = rand.Next(ClientSize.Height - label3.Height);
            }
            //timer1.Interval = rand.Next(1, 120);
            /*if ((timer1.Interval > 1) && 
               ((timer1.Interval+time) > 1) && 
               (timer1.Interval < 500))
            {
                timer1.Interval += time;
            }
            else
            {
                if(timer1.Interval > 500)
                {
                    timer1.Interval += rand.Next(-10, 0);
                }
                else
                {
                    timer1.Interval += rand.Next(0, 11);
                }
            }*/
        }
    }
}
