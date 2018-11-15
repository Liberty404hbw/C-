using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Zerohbw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\XMLFile1.xml");
            XmlNode root = doc.DocumentElement;  
            DataSet ds = new DataSet();
            XmlNode S;           
            root = doc.DocumentElement;
            S = root.SelectSingleNode("//S[用户名='" + textBox1.Text.Trim() + "']");    
            StringReader reader = new StringReader(S.OuterXml);    
            ds.ReadXml(reader);
            if (textBox2.Text == ds.Tables[0].Rows[0]["密码"].ToString().Trim())        
            {
                Form7 myf = new Form7();
                this.Opacity = 0;
                myf.ShowDialog();
                this.Opacity = 100;
            }
            else
            {
                MessageBox.Show("用户名或密码不存在！", "错误");
            }

        }
        private void Form2()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Form2));
            thread.Start();
            this.Close();


        }
    }
}
