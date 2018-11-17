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
using System.IO;
namespace Hbw学生宿舍管理系统
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\学生基本信息.xml");
            XmlNode root = doc.SelectSingleNode("NewDataSet");
            XmlElement xe1 = doc.CreateElement("S");

            XmlElement xesub1 = doc.CreateElement("学号");
            xesub1.InnerText = textBox2.Text.Trim();
            xe1.AppendChild(xesub1);
            XmlElement xesub3 = doc.CreateElement("姓名");
            xesub3.InnerText = textBox1.Text.Trim();
            xe1.AppendChild(xesub3);
            XmlElement xesub4 = doc.CreateElement("性别");
            xesub4.InnerText = comboBox2.Text.Trim();
            xe1.AppendChild(xesub4);
            XmlElement xesub5 = doc.CreateElement("年龄");
            xesub5.InnerText = textBox3.Text.Trim();
            xe1.AppendChild(xesub5);
            XmlElement xesub6 = doc.CreateElement("住址");
            xesub6.InnerText = textBox4.Text.Trim();
            xe1.AppendChild(xesub6);
            XmlElement xesub2 = doc.CreateElement("专业");
            xesub2.InnerText = comboBox1.Text.Trim();
            xe1.AppendChild(xesub2);
            root.AppendChild(xe1);//添加到节点中
            doc.Save(System.Environment.CurrentDirectory + "\\学生基本信息.xml");

            XmlDocument dob = new XmlDocument();
            dob.Load(System.Environment.CurrentDirectory + "\\学生得分信息.xml");
            XmlNode root1 = dob.SelectSingleNode("NewDataSet");
            XmlElement xe2 = dob.CreateElement("S");

            XmlElement xesu7 = dob.CreateElement("学号");
            xesu7.InnerText = textBox2.Text.Trim();
            xe2.AppendChild(xesu7);
            XmlElement xesu6 = dob.CreateElement("专业");
            xesu6.InnerText = comboBox1.Text.Trim();
            xe2.AppendChild(xesu6);
            XmlElement xesu8 = dob.CreateElement("姓名");
            xesu8.InnerText = textBox1.Text.Trim();
            xe2.AppendChild(xesu8);

            XmlElement xesub7 = dob.CreateElement("九月份得分");
            xesub7.InnerText = textBox5.Text.Trim();
            xe2.AppendChild(xesub7);
            XmlElement xesub8 = dob.CreateElement("十月份得分");
            xesub8.InnerText = textBox6.Text.Trim();
            xe2.AppendChild(xesub8);
            XmlElement xesub9 = dob.CreateElement("十一月份得分");
            xesub9.InnerText = textBox7.Text.Trim();
            xe2.AppendChild(xesub9);
            XmlElement xesu1 = dob.CreateElement("十二月份得分");
            xesu1.InnerText = textBox8.Text.Trim();
            xe2.AppendChild(xesu1);
            XmlElement xesu2 = dob.CreateElement("九月份星级");
            xesu2.InnerText = textBox9.Text.Trim();
            xe2.AppendChild(xesu2);
            XmlElement xesu3 = dob.CreateElement("十月份星级");
            xesu3.InnerText = textBox10.Text.Trim();
            xe2.AppendChild(xesu3);
            XmlElement xesu4 = dob.CreateElement("十一月份星级");
            xesu4.InnerText = textBox11.Text.Trim();
            xe2.AppendChild(xesu4);
            XmlElement xesu5 = dob.CreateElement("十二月份星级");
            xesu5.InnerText = textBox12.Text.Trim();
            xe2.AppendChild(xesu5);

            root1.AppendChild(xe2);//添加到节点中
            dob.Save(System.Environment.CurrentDirectory + "\\学生得分信息.xml");
            MessageBox.Show("添加新学生成功！", "恭喜");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
