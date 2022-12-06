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
    public partial class задание_2 : Form
    {
        public задание_2()
        {
            InitializeComponent();
        }
         void F(int n, int b)
        {
            if (n < b)
            {

                var s = n.ToString();
                var result = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    result += s[i];
                }
                richTextBox1.Text += result.ToString() + Environment.NewLine;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            int A = int.Parse(textBox1.Text);

            int B = int.Parse(textBox2.Text);
            if (A == 0)
            {
                MessageBox.Show("0 - не натуральное число");
                return;
            }
            if (A < 0)
            {
                MessageBox.Show("Число должно быть положительным");
                return;
            }
            if (B == 0)
            {
                MessageBox.Show("0 - не натуральное число");
                return;
            }
            if (B < 0)
            {
                MessageBox.Show("Число должно быть положительным");
                return;
            }
            if (A > B)
            {
                MessageBox.Show(" 'A' не может быть больше 'B'");
                return;
            }
            for (int i = A; A < B; A++)
            {
                 F(A, B);
            }
   
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
