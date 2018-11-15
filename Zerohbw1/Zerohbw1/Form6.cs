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

namespace Zerohbw1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\XMLFile3.xml");  
            XmlNode root = doc.DocumentElement;
            root = doc.DocumentElement;
            XmlElement no;
            no = (XmlElement)root.SelectSingleNode("//S[ID号=]");
            root.RemoveChild(no);
            doc.Save(System.Environment.CurrentDirectory + "\\XMLFile3.xml");
            
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(System.Environment.CurrentDirectory + "\\XMLFile2.xml");
            XmlNode root1 = doc1.DocumentElement;
            root1 = doc1.DocumentElement;
            XmlElement no1;
           no1 = (XmlElement)root1.SelectSingleNode("//S[ID号=]");
            root1.RemoveChild(no1);
            doc1.Save(System.Environment.CurrentDirectory + "\\XMLFile2.xml");
            MessageBox.Show("已成功删除此信息！", "恭喜");
        }
        private void 删除留言_Load_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\XMLFile2.xml");  
            XmlNode root = doc.DocumentElement;             
            DataSet ds = new DataSet();         
            XmlNode S;
            root = doc.DocumentElement;
            S = root.SelectSingleNode("//S[jibie=" + "" + "and" + " ID号=" + "Class1.ygh" + "]"); 
            StringReader reader = new StringReader(S.OuterXml);
            ds.ReadXml(reader);

           dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

       
    }
}
