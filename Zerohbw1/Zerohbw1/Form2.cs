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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "666666")       
                
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(System.Environment.CurrentDirectory + "\\XMLFile1.xml");
                    XmlNode root = doc.SelectSingleNode("NewDataSet");
                    XmlElement xe1 = doc.CreateElement("S");
                   
                    XmlElement xesub1 = doc.CreateElement("用户名");
                    xesub1.InnerText = textBox1.Text.Trim();
                    xe1.AppendChild(xesub1);
                  
                    XmlElement xesub2 = doc.CreateElement("密码");
                    xesub2.InnerText = textBox2.Text.Trim();
                    xe1.AppendChild(xesub2);
                  
                    root.AppendChild(xe1);
                   
                    doc.Save(System.Environment.CurrentDirectory + "\\XMLFile1.xml");
                    MessageBox.Show("注册成功！", "恭喜");
                }
                else
                {
                    MessageBox.Show("密码两次输入不一致！", "错误");
                }
           
            else
            {
                MessageBox.Show("注册码输入错误，您无权注册！", "错误");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
