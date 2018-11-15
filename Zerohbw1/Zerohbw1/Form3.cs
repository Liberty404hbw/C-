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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();
            ds.ReadXml("XMLFile3.xml");
           dataGridView1.DataSource = ds.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
           // XmlDocument ds = new XmlDocument();
            //ds.Load("XMLFile3.xml");
           // while（reader.Read())
           // {
             //   switch (DataTableReader.NodeType)
             //   {
              //      case XmlNodeType.Element:
                //        s = reader.Name;
                //        break;
               //     case XmlNodeType.Text:
                //        if (s.Equals("name"))
                //            myitem = listView1.Items.Add(reader.Value);
                  //      else
                 //           myitem.SubItems.Add(reader.Value);
                 //       break;
                }
            }
        }
    

