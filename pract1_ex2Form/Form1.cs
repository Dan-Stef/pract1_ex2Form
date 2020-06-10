using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1_ex2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b, c;
            if (!(a > 9 && a < 100))
                textBox2.Text = Convert.ToString("Число не двузначное");
            else
            {
                b = a / 10;
                c = a % 10;
                if (b > c) textBox2.Text = Convert.ToString("Первая цифра больше");
                else if (b == c) textBox2.Text = Convert.ToString("Цифры равны");
                else textBox2.Text = Convert.ToString("Вторая цифра больше");
            }
        }
    }
}
