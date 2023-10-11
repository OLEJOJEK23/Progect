using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triygolnik
{
    public partial class DA : Form
    {
        public DA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = 0, s2 = 0, s3 = 0;
            string result;
            try
            {
                s1 = Convert.ToInt32(textBox1);
                s2 = Convert.ToInt32(textBox2);
                s3 = Convert.ToInt32(textBox3);
            }
            catch
            {
                MessageBox.Show("Ввели не число");
                return;
            }
            {
                if ((s1 + s2 <= s3) || (s1 + s3 <= s2) || (s2 + s3 <= s1))
                {
                    MessageBox.Show("Это не треугольник");
                }
                else
                if ((s1 == s2) && (s1 == s3) && (s2 == s3))
                {
                    MessageBox.Show("Треугольник равносторонний");
                }
                else
                if (((s1 == s2) && (s2 != s3) || (s1 == s3) && (s2 != s3)) || ((s2 == s3) && s1 != s3))
                {
                    MessageBox.Show("Треугольник равнобедренный");
                }
                  
                }

            }
        }
    }
