using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Form1 f;
        public Form4(Form1 f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XElement root = new XElement("group");
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    XElement s = new XElement("student");
                    XElement n = new XElement("name", Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                    s.Add(n);
                    root.Add(s);
                }
                XDocument doc = new XDocument();
                doc.Add(root);
                doc.Save(saveFileDialog1.OpenFile());
            }

            dataGridView1.AllowUserToAddRows = true;
        }
        int kol = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int index = cell.ColumnIndex;
                    if (index == 2)
                    {
                        cell.Value = "";

                    }
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    kol = 0;
                    XDocument doc = XDocument.Load(openFileDialog1.OpenFile());
                    foreach (XElement s in doc.Element("group").Elements("student"))
                    {
                        dataGridView1.Rows.Add(s.Element("name").Value);
                        kol++;
                    }
                }
                catch (Exception) { }

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
