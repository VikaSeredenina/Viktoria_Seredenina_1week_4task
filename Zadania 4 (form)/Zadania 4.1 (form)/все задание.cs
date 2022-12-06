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
    public partial class все_задание : Form
    {
        public все_задание()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            задание_2 two = new задание_2();
            two.Show();
        }
    }
}
