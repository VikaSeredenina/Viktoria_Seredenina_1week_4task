using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_4._1__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int F(int n, int i = 0)
        {
            if (n-- == 0)
                return i;
            return F(n, 1 + i + n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            int m = int.Parse(textBox1.Text);

            int k = int.Parse(textBox2.Text);
            if (m == 0)
            {
                MessageBox.Show("0 - не натуральное число");
                return;
            }
            if (m < 0)
            {
                MessageBox.Show("Число должно быть положительным");
                return;
            }
            if (k == 0)
            {
                MessageBox.Show("0 - не натуральное число");
                return;
            }
            if (k < 0)
            {
                MessageBox.Show("Число должно быть положительным");
                return;
            }

            int sum = F(m) + F(2 * k);
            richTextBox1.Text = "Сумма равна " + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            richTextBox1.Text = "";
            richTextBox1.Clear();
        }
    }
}
