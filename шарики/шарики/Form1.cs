using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шарики
{
    public partial class Шарики : Form
    {
        Balls Ball = new Balls();
        Balls Ball2 = new Balls();
        public Шарики()
        {
            InitializeComponent();
        }

        private void Шарики_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape) { this.Close(); }
        }
        private void Traectory_Tick(object sender, EventArgs e)
        {
            Ball_1.Top = Ball.Y;
            Ball_1.Left = Ball.X;
            Ball_2.Top = Ball2.Y;
            Ball_2.Left = Ball2.X;
        }

        private void Шарики_Load(object sender, EventArgs e)
        {
            Ball.Y = 78;
            Ball.X = 226;
            Ball2.Y = 206;
            Ball2.X = 456;
        }

        private void Dvijenie_X2_Tick(object sender, EventArgs e)
        {
            if (Ball.X >= 0)
                Ball.X += -2;
            else
            {
                Dvijenie_X1.Enabled = true;
                Dvijenie_X2.Enabled = false;
            }
            if (Ball.X == Ball2.X + 100 && Ball.Y - Ball2.Y <= 100 && Ball.Y - Ball2.Y >= -100)
            {
                Dvijenie_X1.Enabled = true;
                Dvijenie_X2.Enabled = false;
            }
        }

        private void Dvijenie_X1_Tick(object sender, EventArgs e)
        {
            if(Ball.X <= this.Width - 117)
                Ball.X += 2;
            else
            {
                Dvijenie_X2.Enabled = true;
                Dvijenie_X1.Enabled = false;
            }
            if (Ball.X + 100 != Ball2.X && Ball.Y - Ball2.Y <= 100 && Ball.Y - Ball2.Y >= -100)
            {
                Dvijenie_X2.Enabled = true;
                Dvijenie_X1.Enabled = false;
            }
        }

        private void Dvijenie_Y1_Tick(object sender, EventArgs e)
        {
            if (Ball.Y <= this.Height - 140)
                Ball.Y += 2;
            else
            {
                Dvijenie_Y2.Enabled = true;
                Dvijenie_Y1.Enabled = false;
            }
            if (Ball.Y + 100 != Ball2.Y && Ball.X - Ball2.X <= 100 && Ball.X - Ball2.X >= -100)
            {
                Dvijenie_Y2.Enabled = true;
                Dvijenie_Y1.Enabled = false;
            }
        }

        private void Dvijenie_Y2_Tick(object sender, EventArgs e)
        {
            if (Ball.Y >= 0)
                Ball.Y += -2;
            else
            {
                Dvijenie_Y1.Enabled = true;
                Dvijenie_Y2.Enabled = false;
            }
            if  (Ball.Y != Ball2.Y + 100 && Ball.X - Ball2.X <= 100 && Ball.X - Ball2.X >= -100)
            {
                Dvijenie_Y1.Enabled = true;
                Dvijenie_Y2.Enabled = false;
            }
        }

        private void Dvijenie2_X1_Tick(object sender, EventArgs e)
        {
            if (Ball2.X <= this.Width - 117)
                Ball2.X += 2;
            else
            {
                Dvijenie2_X2.Enabled = true;
                Dvijenie2_X1.Enabled = false;
            }
            if (Ball2.X + 100 != Ball.X && Ball2.Y - Ball.Y <= 100 && Ball2.Y - Ball.Y >= -100)
            {
                Dvijenie2_X2.Enabled = true;
                Dvijenie2_X1.Enabled = false;
            }
        }

        private void Dvijenie2_X2_Tick(object sender, EventArgs e)
        {
            if (Ball2.X >= 0)
                Ball2.X += -2;
            else
            {
                Dvijenie2_X1.Enabled = true;
                Dvijenie2_X2.Enabled = false;
            }
            if (Ball2.X != Ball.X + 100 && Ball2.Y - Ball.Y <= 100 && Ball2.Y - Ball.Y >= -100)
            {
                Dvijenie2_X1.Enabled = true;
                Dvijenie2_X2.Enabled = false;
            }
        }

        private void Dvijenie2_Y1_Tick(object sender, EventArgs e)
        {
            if (Ball2.Y <= this.Height - 140)
                Ball2.Y += 2;
            else
            {
                Dvijenie2_Y2.Enabled = true;
                Dvijenie2_Y1.Enabled = false;
            }
            if (Ball2.Y + 100 != Ball.Y && Ball2.X - Ball.X <= 100 && Ball2.X - Ball.X >= -100)
            {
                Dvijenie2_Y2.Enabled = true;
                Dvijenie2_Y1.Enabled = false;
            }
        }

        private void Dvijenie2_Y2_Tick(object sender, EventArgs e)
        {
            if (Ball2.Y >= 0)
                Ball2.Y += -2;
            else
            {
                Dvijenie2_Y1.Enabled = true;
                Dvijenie2_Y2.Enabled = false;
            }
            if (Ball2.Y != Ball.Y + 100 && Ball2.X - Ball.X <= 100 && Ball2.X - Ball.X >= -100)
            {
                Dvijenie2_Y1.Enabled = true;
                Dvijenie2_Y2.Enabled = false;
            }
        }
    }
}