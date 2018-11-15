using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Zerohbw1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\XMLFile2.xml");
            XmlNode root = doc.SelectSingleNode("NewDataSet");
            XmlNode book = root.SelectSingleNode("//S[ID号='" + textBox1.Text.Trim() + "']");
            book.ChildNodes[0].InnerText = textBox2.Text.Trim();
            book.ChildNodes[1].InnerText = textBox3.Text.Trim();
            book.ChildNodes[2].InnerText = textBox4.Text.Trim();
            book.ChildNodes[3].InnerText = textBox5.Text.Trim();
            doc.Save(System.Environment.CurrentDirectory + "\\XMLFile2.xml");
           
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(System.Environment.CurrentDirectory + "\\XMLFile3.xml");
            XmlNode root1 = doc1.SelectSingleNode("NewDataSet");
            XmlNode book1 = root1.SelectSingleNode("//S[ID号='" + textBox1.Text.Trim() + "']");
            book1.ChildNodes[2].InnerText = textBox6.Text.Trim();
            book1.ChildNodes[3].InnerText = textBox7.Text.Trim();
            doc1.Save(System.Environment.CurrentDirectory + "\\XMLFile3.xml");
            MessageBox.Show("已成功修改！", "提示");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
