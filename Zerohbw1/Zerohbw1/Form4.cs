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
    public partial class Form4 : Form
    {
        public Form4()
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
            XmlElement xe1 = doc.CreateElement("S");

            XmlElement xesub1 = doc.CreateElement("ID号");
            xesub1.InnerText = textBox1.Text.Trim();
            xe1.AppendChild(xesub1);
            XmlElement xesub2 = doc.CreateElement("name");
            xesub2.InnerText = textBox2.Text.Trim();
            xe1.AppendChild(xesub2);
            XmlElement xesub3 = doc.CreateElement("jibie");
            xesub3.InnerText = textBox3.Text.Trim();
            xe1.AppendChild(xesub3);
            XmlElement xesub4 = doc.CreateElement("xingbie");
            xesub4.InnerText = textBox4.Text.Trim();
            xe1.AppendChild(xesub4);
            XmlElement xesub5 = doc.CreateElement("nianling");
            xesub5.InnerText = textBox5.Text.Trim();
            xe1.AppendChild(xesub5);
            root.AppendChild(xe1);
            doc.Save(System.Environment.CurrentDirectory + "\\XMLFile2.xml");
            XmlDocument dob = new XmlDocument();
            dob.Load(System.Environment.CurrentDirectory + "\\XMLFile3.xml");
            XmlNode root1 = dob.SelectSingleNode("NewDataSet");
            XmlElement xe2 = dob.CreateElement("S");
            XmlElement xesu6 = dob.CreateElement("ID号");
            xesu6.InnerText = textBox1.Text.Trim();
            xe2.AppendChild(xesu6);
            XmlElement xesu7 = dob.CreateElement("name");
            xesu7.InnerText = textBox2.Text.Trim();
            xe2.AppendChild(xesu7);
            XmlElement xesu8 = dob.CreateElement("E-mail");
            xesu8.InnerText = textBox6.Text.Trim();
            xe2.AppendChild(xesu8);
            XmlElement xesu9 = dob.CreateElement("message");
            xesu9.InnerText = textBox7.Text.Trim();
            xe2.AppendChild(xesu9);
            root1.AppendChild(xe2);
            dob.Save(System.Environment.CurrentDirectory + "\\XMLFile3.xml");
            MessageBox.Show("添加信息！", "恭喜");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
