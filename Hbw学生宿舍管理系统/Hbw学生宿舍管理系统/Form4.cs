using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Hbw学生宿舍管理系统
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "全部")
            {
                DataSet ds = new DataSet();
                ds.ReadXml(System.Environment.CurrentDirectory + "\\学生基本信息.xml");
                dataGridView1.DataSource = ds.Tables[0];
                DataSet da = new DataSet();
                da.ReadXml(System.Environment.CurrentDirectory + "\\学生得分信息.xml");
                dataGridView2.DataSource = da.Tables[0];
            }
            else if (textBox1.Text.Trim() == "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(System.Environment.CurrentDirectory + "\\学生基本信息.xml");  //将XML读入到内存中
                XmlNode root = doc.DocumentElement;//选择XML的根元素
                DataSet ds = new DataSet();

                XmlNodeList s;
                root = doc.DocumentElement;
                s = root.SelectNodes("//S[专业='" + comboBox1.Text.Trim() + "']");//查找数据什等于 学号 的数据。
                for (int i = 0; i < s.Count; i++)
                {
                    StringReader reader = new StringReader(s.Item(i).OuterXml);//将找到的数据加入到新生成的reader数据流中。
                    ds.ReadXml(reader);//以XML方式读取到dataset中。
                }
                dataGridView1.DataSource = ds.Tables[0];

                XmlDocument dob = new XmlDocument();
                dob.Load(System.Environment.CurrentDirectory + "\\学生得分信息.xml");  //将XML读入到内存中
                XmlNode root1 = doc.DocumentElement;//选择XML的根元素
                DataSet da = new DataSet();

                XmlNodeList b;
                root1 = dob.DocumentElement;
                b = root1.SelectNodes("//S[专业='" + comboBox1.Text.Trim() + "']");//查找数据什等于 学号 的数据。
                for (int i = 0; i < b.Count; i++)
                {
                    StringReader reader = new StringReader(b.Item(i).OuterXml);//将找到的数据加入到新生成的reader数据流中。
                    da.ReadXml(reader);//以XML方式读取到dataset中。
                }
                dataGridView2.DataSource = da.Tables[0];


            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(System.Environment.CurrentDirectory + "\\学生基本信息.xml");  //将XML读入到内存中
                XmlNode root = doc.DocumentElement;//选择XML的根元素
                DataSet ds = new DataSet();
                XmlNode z;
                root = doc.DocumentElement;
                z = root.SelectSingleNode("//S[专业=" + "'" + comboBox1.Text.Trim() + "'" + "and" + " 学号=" + "'" + textBox1.Text.Trim() + "'" + "]");//查找数据什等于 学号 的数据。
                StringReader reader = new StringReader(z.OuterXml);
                ds.ReadXml(reader);
                dataGridView1.DataSource = ds.Tables[0];

                XmlDocument dob = new XmlDocument();
                dob.Load(System.Environment.CurrentDirectory + "\\学生得分信息.xml");  //将XML读入到内存中
                XmlNode root1 = doc.DocumentElement;//选择XML的根元素
                DataSet da = new DataSet();
                XmlNode s;
                root1 = dob.DocumentElement;
                s = root1.SelectSingleNode("//S[专业=" + "'" + comboBox1.Text.Trim() + "'" + "and" + " 学号=" + "'" + textBox1.Text.Trim() + "'" + "]");//查找数据什等于 学号 的数据。
                StringReader reader1 = new StringReader(s.OuterXml);
                da.ReadXml(reader1);
                dataGridView2.DataSource = da.Tables[0];

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}