namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = 0, s2 = 0, s3 = 0;
            try
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                s3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Не числа!");
                return;
            }
            if ((s1 + s2 > s3) && (s2 + s3 > 1) && (s3 + s1 > s3))
            {
                if (((s1 == s2) && (s2 != s3)) || (s1 == s3) && (s2 != s3) || ((s2 == s3) && (s1 != s3)))
                {
                    MessageBox.Show("Равнобедренный треугольник");
                }
                else
                {
                    if (s1 == s2 && s2 == s3)
                    {
                        MessageBox.Show("Равносторонний треугольник");
                    }
                    else
                    {
                        MessageBox.Show("Разносторонний треугольник");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не существует");
            }


        }
    }
}