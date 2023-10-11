using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side1 = 0, side2 =0 , side3 = 0;
            try
            {
                side1 = Convert.ToDouble(textBox1.Text);
                side2 = Convert.ToDouble(textBox2.Text);
                side3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Значения не являются числом");
                return;
            }
            if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side3 + side1 > side2))
            {
                if ((side1 == side2 && side2 != side3) || (side2 == side3 && side2!= side1) || (side3 == side1 && side1 != side2))
                {
                    MessageBox.Show("Ваш треугольник равнобедренный");

                }
                else
                {
                    if(side1 == side2 && side2 == side3)
                    {
                        MessageBox.Show("Ваш треугольник равностороний");
                    }
                    else 
                    {
                        MessageBox.Show("Ваш треугольник разностороний");
                    }
                }
            }
            else { MessageBox.Show("Треугольник не может существовать"); }
           
        }
    }
}
