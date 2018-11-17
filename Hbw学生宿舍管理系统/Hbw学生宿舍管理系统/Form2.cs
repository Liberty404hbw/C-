using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hbw学生宿舍管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 myf = new Form4();
            myf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 myf = new Form5();
            myf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 myf = new Form9();
            myf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 myf = new Form6();
            myf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
