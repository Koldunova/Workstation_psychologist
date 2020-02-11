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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int kol = 0;
        Form1 f;
        public Form2(Form1 F)
        {
            InitializeComponent();
            f = F;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //загрузка в combobox уникальные группы
            string sql = "Select DISTINCT group from students ";
            OleDbCommand command = new OleDbCommand(sql, f.myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void Ответ()
        {
            //очистка
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

            int k = kol * 2;
            int f = 0;
            string res = "";
            //запсь в столбцы
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (f != 1)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1 && k != 0)
                        {
                            k--;
                            if (cell.Value.ToString().Length == 53)
                            { 
                                res = Результат(cell.Value.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK);
                                f = 1;
                            }
                        }
                        else
                        {
                            if (index == 2 && k != 0)
                            {
                                cell.Value = res;
                                k--;
                            }
                        }
                    }
                }

            }
        }

       void ДополнительныйОтвет ()
       {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            string r6 = "";
            string r7 = "";


            int k = kol * 8;
            int f = 0;

            //запсь в столбцы
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (f != 1)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1 && k != 0)
                        {
                            k--;
                            try
                            {
                                Дополнительно(cell.Value.ToString(), out r1, out r2, out r3, out r4, out r5, out r6, out r7);
                            }
                            catch (System.NullReferenceException)
                            {
                                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK);
                                f = 1;
                            }

                        }
                        
                            if (index == 3 && k != 0)
                            {
                                cell.Value = r1;
                                k--;
                            }
                            if (index == 4 && k != 0)
                            {
                                cell.Value = r2;
                                k--;
                            }
                            if (index == 5 && k != 0)
                            {
                                cell.Value = r3;
                                k--;
                            }
                            if (index == 6 && k != 0)
                            {
                                cell.Value = r4;
                                k--;
                            }
                            if (index == 7 && k != 0)
                            {
                                cell.Value = r5;
                                k--;
                            }
                            if (index == 8 && k != 0)
                            {
                                cell.Value = r6;
                                k--;
                            }
                            if (index == 9 && k != 0)
                            {
                                cell.Value = r7;
                                k--;
                            }
                        
                    }
                }

            }

        }

        void Дополнительно(string line,out string r1,out string r2, out string r3,  out string r4, out string r5, out string r6, out string r7)
        {
            line = line.Replace(" ", "");


            StringBuilder l1_1 = new StringBuilder();
            StringBuilder l1_2 = new StringBuilder();

            StringBuilder l2_1 = new StringBuilder();
            StringBuilder l2_2 = new StringBuilder();

            StringBuilder l3 = new StringBuilder();

            StringBuilder l4 = new StringBuilder();

            StringBuilder l5_1 = new StringBuilder();
            StringBuilder l5_2 = new StringBuilder();

            StringBuilder l6 = new StringBuilder();

            StringBuilder l7_1 = new StringBuilder();
            StringBuilder l7_2 = new StringBuilder();

            if (line.Length == 53)
            {
                //создание строк для подсчетов

                for (int i = 1; i <= line.Length; i++)
                {
                    //импульсивность
                    if (i == 4 || i == 6 || i == 7 || i == 13 || i == 25 || i == 26 || i == 27 || i == 38 ||
                        i == 42 || i == 47 )
                    {
                        l1_1.Append(line[i-1]);
                    }
                    if (i == 10 || i == 17 || i == 24 || i == 30 || i == 35 || i == 45)
                    {
                        l1_2.Append(line[i - 1]);
                    }
                    //Слабость
                    if (i == 9 || i == 12 || i == 44 || i == 49 || i == 53 || i == 15 || i == 23 || i == 31 || i == 51)
                    {
                        l2_1.Append(line[i - 1]);
                    }
                    if ( i == 15 || i == 23 || i == 31 || i == 51)
                    {
                        l2_2.Append(line[i - 1]);
                    }
                    //дезадаптированность
                    if (i == 5 || i == 19 || i == 21 || i == 29 || i == 32 || i == 39 || i == 40 || i == 50 ||
                        i == 52)
                    {
                        l3.Append(line[i - 1]);
                    }
                    //Враждебность
                    if (i == 20 || i ==33 || i == 41 || i == 46)
                    {
                        l4.Append(line[i - 1]);
                    }
                    //Безрассудность
                    if (i == 16 || i == 22 || i == 28 )
                    {
                        l5_1.Append(line[i - 1]);
                    }
                    if (i == 37 )
                    {
                        l5_2.Append(line[i - 1]);
                    }
                    //склонность к зависимостям
                    if (i == 8 || i == 36 || i == 43)
                    {
                        l6.Append(line[i - 1]);
                    }
                    //социальная желательность
                    if (i == 34)
                    {
                        l7_1.Append(line[i - 1]);
                    }
                    if (i == 1 || i == 2 || i == 3 || i == 11 || i == 14 || i == 18 || i == 48)
                    {
                        l7_1.Append(line[i - 1]);
                    }

                }

                int i1 = Прямые(l1_1.ToString()) + Обратные(l1_2.ToString());
                int i2 = Прямые(l2_1.ToString()) + Обратные(l2_2.ToString());
                int i3 = Прямые(l3.ToString());
                int i4 = Прямые(l4.ToString());
                int i5 = Прямые(l5_1.ToString()) + Обратные(l5_2.ToString());
                int i6 = Прямые(l6.ToString());
                int i7 = Прямые(l7_1.ToString()) + Обратные(l7_2.ToString());
                //импульсивность
                if (i1 < 16)
                {
                    r1 = "Неверные данные";
                }
                else
                {
                    if (i1 < 21)
                    {
                        r1 = "Низкий";
                    }
                    else
                    {
                        if (i1 < 61)
                        {
                            r1 = "Средний";
                        }
                        else
                        {

                                r1 = "Высоокий";

                        }
                    }
                }
                
                //Слабость
                if (i2 < 9)
                {
                    r2 = "Неверные данные";
                }
                else
                {
                    if (i2 < 15)
                    {
                        r2 = "Низкий";
                    }
                    else
                    {
                        if (i2 < 30)
                        {
                            r2 = "Средний";
                        }
                        else
                        {
                           
                                r2 = "Высоокий";

                        }
                    }
                }

                // дезадаптированность
                if (i3 < 9)
                {
                    r3 = "Неверные данные";
                }
                else
                {
                    if (i3 < 15)
                    {
                        r3 = "Низкий";
                    }
                    else
                    {
                        if (i3 < 30)
                        {
                            r3 = "Средний";
                        }
                        else
                        {

                            r3 = "Высоокий";

                        }
                    }
                }

                //враждебность
                if (i4 < 4)
                {
                    r4 = "Неверные данные";
                }
                else
                {
                    if (i4 < 7)
                    {
                        r4 = "Низкий";
                    }
                    else
                    {
                        if (i4 < 15)
                        {
                            r4 = "Средний";
                        }
                        else
                        {

                            r4 = "Высоокий";

                        }
                    }
                }

                // безрассудность
                if (i5 < 4)
                {
                    r5 = "Неверные данные";
                }
                else
                {
                    if (i5 < 7)
                    {
                        r5 = "Низкий";
                    }
                    else
                    {
                        if (i5 < 15)
                        {
                            r5 = "Средний";
                        }
                        else
                        {

                            r5 = "Высоокий";

                        }
                    }
                }


                // склонность
                if (i6 < 3)
                {
                    r6 = "Неверные данные";
                }
                else
                {
                    if (i6 < 6)
                    {
                        r6 = "Низкий";
                    }
                    else
                    {
                        if (i6 < 11)
                        {
                            r6 = "Средний";
                        }
                        else
                        {

                            r6 = "Высоокий";

                        }
                    }
                }

                // сочиальная
                if (i7 < 8)
                {
                    r7 = "Неверные данные";
                }
                else
                {
                    if (i7 < 14)
                    {
                        r7 = "Низкий";
                    }
                    else
                    {
                        if (i7 < 28)
                        {
                            r7 = "Средний";
                        }
                        else
                        {

                            r7 = "Высоокий";

                        }
                    }
                }


            }
            else
            {
                r1=  "Неверное кол-во данных";
                r2 = "Неверное кол-во данных";
                r3 = "Неверное кол-во данных";
                r4 = "Неверное кол-во данных";
                r5 = "Неверное кол-во данных";
                r6 = "Неверное кол-во данных";
                r7 = "Неверное кол-во данных";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ответ();
            ДополнительныйОтвет();
            button2.Enabled = true;
           
        }

        string Результат (string line)
        {
            line= line.Replace(" ", "");

            if (line.Length == 53)
            {
                StringBuilder fПрямые = new StringBuilder();
                StringBuilder fОбратные = new StringBuilder();
                for (int i = 0; i < line.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 7 || i == 9 || i == 10 || i == 13 || i == 14 || i == 16 ||
                        i == 17 || i == 22 || i == 23 || i == 29 || i == 30 || i == 34 || i == 36 || i == 44
                        || i == 47 || i == 50)
                    {
                        fОбратные.Append(line[i]);
                    }
                    else
                    {
                        fПрямые.Append(line[i]);
                    }

                }

                int result = Обратные(fОбратные.ToString()) + Прямые(fПрямые.ToString());
                Console.WriteLine(result);
                if (result < 53)
                {
                    return "неверные данные";
                }
                else
                {
                    if (result < 130)
                    {
                        return "Показатели в норме";
                    }
                    else
                    {
                        if (result < 161)
                        {
                            return "Признаки склонности";
                        }
                        else
                        {
                            if (result < 201)
                            {
                                return "Признаки повышенной склонности";
                            }
                            else
                            {
                                if (result < 265)
                                {
                                    return "Признаки высокой вероятности";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return "Неверное кол-во данных";
            }
            return "";
        }

        int Обратные(string line)
        {

            int ans = 0;
            foreach (char el in line)
            {
                if (el == '5') { ans += 1; continue; }
                if (el == '4') { ans += 2; continue; }
                if (el == '3') { ans += 3; continue; }
                if (el == '2') { ans += 4; continue; }
                if (el == '1') { ans += 5; continue; }
                return -1; 
            }
            return ans ;
        }

        int Прямые(string line)
        {

            int ans = 0;
            foreach (char el in line)
            {
                if (el == '1') { ans += 1; continue; }
                if (el == '2') { ans += 2; continue; }
                if (el == '3') { ans += 3; continue; }
                if (el == '4') { ans += 4; continue; }
                if (el == '5') { ans += 5; continue; }
                return -1; 
            }
            return ans;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    /*copyAlltoClipboard();
                    Excel.Application xlexcel;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    xlWorkBook.SaveAs();
                    */
                }
                //сохранить результаты
                string sql = "";
                for (int i = 0; i < dataGridView1.Rows.Count;++i)
                {
                    sql = "update students set inputdata='" + dataGridView1.Rows[i].Cells[1].Value + "',result='" + dataGridView1.Rows[i].Cells[2].Value + "'," +
                        "impulsiveness='" + dataGridView1.Rows[i].Cells[3].Value + "',weakness='" + dataGridView1.Rows[i].Cells[4].Value + "'," +
                        "maladaptation='" + dataGridView1.Rows[i].Cells[5].Value + "',hostilityOfParents='" + dataGridView1.Rows[i].Cells[6].Value + "'," +
                        "recklessness='" + dataGridView1.Rows[i].Cells[7].Value + "',addiction='" + dataGridView1.Rows[i].Cells[8].Value + "',socialDesitability='" +
                        dataGridView1.Rows[i].Cells[9].Value + "' where [nameStudent]='" + dataGridView1.Rows[i].Cells[0].Value + "' and [group] ='" + comboBox1.Text + "' ;";
                    OleDbCommand command = new OleDbCommand(sql, f.myConnection);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Данные успешно сохранены", "Успешно", MessageBoxButtons.OK);
            }
            catch (Exception) { }
            

      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            { 
            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kol = 0;
                XDocument doc = XDocument.Load(openFileDialog1.OpenFile());
                foreach (XElement s in doc.Element("group").Elements("student"))
                {
                    dataGridView1.Rows.Add(s.Element("name").Value);
                    kol++;
                }
                button1.Enabled = true;
               
            }
            */
        }
            //загрузка учащихся и их результатов если нада
            if (comboBox1.Text.Length > 0)
            {
                kol = 0;
                dataGridView1.Rows.Clear();
                string sql = "Select nameStudent,inputdata,result,impulsiveness,weakness,maladaptation,hostilityOfParents,recklessness,addiction,socialDesitability from students where [group] ='" +comboBox1.Text +"' ;";
                OleDbCommand command = new OleDbCommand(sql, f.myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                    kol++;
                }
                button2.Enabled = true;
                button1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Выберите группу", "Внимание", MessageBoxButtons.OK);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
