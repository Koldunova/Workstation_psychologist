using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            {  /* dataGridView1.AllowUserToAddRows = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XElement root = new XElement("group");
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        XElement s = new XElement("student");
                        XElement n = new XElement("name", Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                        s.Add(n);
                        root.Add(s);
                    }
                    XDocument doc = new XDocument();
                    doc.Add(root);
                    doc.Save(saveFileDialog1.OpenFile());
              

            dataGridView1.AllowUserToAddRows = true;*/
            };
            //сохранить в бд
            if (textBox1.Text.Length > 0)
            {
                string sql = "";
                OleDbCommand command;
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    sql = "INSERT INTO students ([nameStudent], [group]) VALUES ('" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + "', '" + textBox1.Text + "'); ";
                    command = new OleDbCommand(sql, f.myConnection);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Группа сохранена", "Успешно", MessageBoxButtons.OK);
                dataGridView1.Rows.Clear();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Введите группу", "Внимание", MessageBoxButtons.OK);
            }

        }
        int kol = 0;
        private void button2_Click(object sender, EventArgs e)
        {/*
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
            {
                
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
            */
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
