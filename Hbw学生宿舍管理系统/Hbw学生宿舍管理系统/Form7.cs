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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\学生基本信息.xml");  //将XML读入到内存中
            XmlNode root = doc.DocumentElement;//选择XML的根元素
            root = doc.DocumentElement;
            XmlElement no;
            no = (XmlElement)root.SelectSingleNode("//S[学号='" + Class1.ygh + "']");//查找数据什等于 影片名稱 的数据。
            root.RemoveChild(no);
            doc.Save(System.Environment.CurrentDirectory + "\\学生基本信息.xml");

            XmlDocument doc1 = new XmlDocument();
            doc1.Load(System.Environment.CurrentDirectory + "\\学生得分信息.xml");  //将XML读入到内存中
            XmlNode root1 = doc1.DocumentElement;//选择XML的根元素
            root1 = doc1.DocumentElement;
            XmlElement no1;
            no1 = (XmlElement)root1.SelectSingleNode("//S[学号='" + Class1.ygh + "']");//查找数据什等于 影片名稱 的数据。
            root1.RemoveChild(no1);
            doc1.Save(System.Environment.CurrentDirectory + "\\学生得分信息.xml");
            MessageBox.Show("已成功删除此学生信息！", "恭喜");
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
