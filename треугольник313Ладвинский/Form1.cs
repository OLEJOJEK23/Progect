using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace треугольник313Ладвинский
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                int Side1 = Convert.ToInt32(side1.Text);
                int Side2 = Convert.ToInt32(side2.Text);
                int Side3 = Convert.ToInt32(side3.Text);
                if ((Side1 + Side2 > Side3) && (Side1 + Side3 > Side2) && (Side2 + Side3 > Side1))
                {
                    side1.Hide();
                    side2.Hide();
                    side3.Hide();
                    Check.Hide();
                    back.Show();
                    if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3)
                    {
                        label1.Text = "Треугольник разносторонний";
                    }
                    else if (Side1 == Side2 && Side1 == Side3)
                    {
                        label1.Text = "Треугольник равносторонний";
                    }
                    else
                    {
                        label1.Text = "Треугольник равнобедренный";
                    }
                }
                else
                {
                    MessageBox.Show("Треугольник не существует");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели неккоректные значения");
                side1.Text = "";
                side2.Text = "";
                side3.Text = "";
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            side1.Text = "";
            side2.Text = "";
            side3.Text = "";
            side1.Show();
            side2.Show();
            side3.Show();
            Check.Show();
            label1.Text = "";
            back.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            back.Hide();
        }
    }
}
