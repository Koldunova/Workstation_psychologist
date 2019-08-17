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
    public partial class Form3 : Form
    {
        Form f;
        public Form3(Form1 F)
        {
            f = F;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
  

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Заполнение();
        }

        void Заполнение()
        {
            dataGridView1.Rows.Add("Когда я делаю что-нибудь хорошее, мои родители замечают это и хвалят меня");
            dataGridView1.Rows.Add("Если у меня возникают личные проблемы, я обращаюсь за помощью к родителям");
            dataGridView1.Rows.Add("Члены моей семьи регаются и кричат друг на друга");
            dataGridView1.Rows.Add("Мне кажется, что родители меня не любят");
            dataGridView1.Rows.Add("Когда я нахожусь в гругу семьи, я чувствую себя в безопасности");
            dataGridView1.Rows.Add("Я чувствую себя одиноким");
            dataGridView1.Rows.Add("Я злюсь на весь мир");
            dataGridView1.Rows.Add("В кругу своих друзей, я чувствую себя в безопасности");
            dataGridView1.Rows.Add("Решая свои проблемы, я учитываю мнение друзей");
            dataGridView1.Rows.Add("Со своими проблемами я могу обратиться к педагогам, психологу");
            dataGridView1.Rows.Add("Педагоги поощряют мои старания");
            dataGridView1.Rows.Add("Педагоги информируют моих родтелей о моих успехах или неудачах");

            dataGridView2.Rows.Add("Если я задерживаюсь, я звоню родителям");
            dataGridView2.Rows.Add("В моей семье существует запрет на употребление алкоголя");
            dataGridView2.Rows.Add("В моей семье существует запрет на употребление наркотиков");

            dataGridView3.Rows.Add("Курению сигарет");
            dataGridView3.Rows.Add("Употреблению пива");
            dataGridView3.Rows.Add("Употреблению других алкогольных напитков");
            dataGridView3.Rows.Add("Употреблению наркотиков, в том числе спайсов");

            dataGridView4.Rows.Add("Курят");
            dataGridView4.Rows.Add("Употребляют алкоголь");
            dataGridView4.Rows.Add("Употребляют наркотики");

            dataGridView5.Rows.Add("Курению сигарет");
            dataGridView5.Rows.Add("Употреблению пива");
            dataGridView5.Rows.Add("Употреблению других алкогольных напитков");
            dataGridView5.Rows.Add("Употреблению наркотиков, в том числе спайсов");

            dataGridView6.Rows.Add("сигареты");
            dataGridView6.Rows.Add("пиво");
            dataGridView6.Rows.Add("другие алкогольные напитки");
            dataGridView6.Rows.Add("наркотики, спайсы");

            dataGridView7.Rows.Add("Курят");
            dataGridView7.Rows.Add("Употребляют пиво");
            dataGridView7.Rows.Add("Употребляют другие алкогольные напитки");
            dataGridView7.Rows.Add("Употребляют наркотики");

            dataGridView8.Rows.Add("Курят");
            dataGridView8.Rows.Add("Употребляют пиво");
            dataGridView8.Rows.Add("Употребляют другие алкогольные напитки");
            dataGridView8.Rows.Add("Употребляют наркотики");

            dataGridView9.Rows.Add("сигареты");
            dataGridView9.Rows.Add("пиво");
            dataGridView9.Rows.Add("другие алкогольные напитки");
            dataGridView9.Rows.Add("наркотики");
            dataGridView9.Rows.Add("спайсы");

            dataGridView10.Rows.Add("употребляли (употребляют) наркотики");
            dataGridView10.Rows.Add("продавали (продают) наркотики");

            dataGridView11.Rows.Add("Курение сигарет");
            dataGridView11.Rows.Add("Употребление пива");
            dataGridView11.Rows.Add("Употребление других алкогольных напитков");
            dataGridView11.Rows.Add("Употребление наркотиков, в том числе спайсов");
        }

        bool Check()
        {

            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                for (int j = 1; j < dataGridView3.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                for (int j = 1; j < dataGridView4.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView5.RowCount; i++)
            {
                for (int j = 1; j < dataGridView5.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView5.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView6.RowCount; i++)
            {
                for (int j = 1; j < dataGridView6.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView7.RowCount; i++)
            {
                for (int j = 1; j < dataGridView7.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView8.RowCount; i++)
            {
                for (int j = 1; j < dataGridView8.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView10.RowCount; i++)
            {
                for (int j = 1; j < dataGridView10.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView10.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView9.RowCount; i++)
            {
                for (int j = 1; j < dataGridView9.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            k = 0;
            for (int i = 0; i < dataGridView11.RowCount; i++)
            {
                for (int j = 1; j < dataGridView11.ColumnCount; j++)
                {
                    if (Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        k = 1;
                    }
                    if (k == 2)
                    {
                        return false;
                    }
                }
            }
            if (k == 0) { return false; }
            return true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        void Анализ()
        {
           // int res = 0;
            int res1 = 0;
            int res2 = 0;
            int res3 = 0;
            int res4 = 0;
            //первая таблица
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    if (i >= 0 && i <= 4)
                    {
                        if (i == 0 || i == 1 || i == 4 || i == 7 || i == 8 || i == 9 || i == 10 || i == 11)
                        {
                            if (j == 1 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 0;
                            }
                            if (j == 2 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 1;
                            }
                            if (j == 3 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 2;
                            }
                            if (j == 4 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 3;
                            }
                        }
                        else
                        {
                            if (j == 1 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 3;
                            }
                            if (j == 2 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 2;
                            }
                            if (j == 3 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 1;
                            }
                            if (j == 4 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res1 += 0;
                            }
                        }
                    }
                    else
                    {
                        if (i == 5 || i == 6)
                        {
                            if (j == 1 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res2 += 3;
                            }
                            if (j == 2 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res2 += 2;
                            }
                            if (j == 3 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res2 += 1;
                            }
                            if (j == 4 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res2 += 0;
                            }
                        }
                        if (i == 7 || i == 8)
                        {
                            if (j == 1 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res3 += 0;
                            }
                            if (j == 2 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res3 += 1;
                            }
                            if (j == 3 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res3 += 2;
                            }
                            if (j == 4 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res3 += 3;
                            }
                        }
                        if (i >= 9 && i <= 11)
                        {
                            if (j == 1 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res4 += 0;
                            }
                            if (j == 2 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res4 += 1;
                            }
                            if (j == 3 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res4 += 2;
                            }
                            if (j == 4 && Convert.ToBoolean(dataGridView1.Rows[i].Cells[j].Value))
                            {
                                res4 += 3;
                            }
                        }
                    }
                }
            }
                //вторая таблица
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    if (j == 2 && Convert.ToBoolean(dataGridView2.Rows[i].Cells[j].Value))
                    {
                        res1 += 2;
                    }
                }
            }
            //третья таблица
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                for (int j = 1; j < dataGridView3.ColumnCount; j++)
                {
                    if ((i==1 || i == 0 )&& j == 2 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value) )
                    {
                        res1 += 1;
                    }
                    if (i == 2 && j == 2 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        res1 += 2;
                    }
                    if (i == 3 && j == 2 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        res1 += 3;
                    }

                    if ((i == 1 || i == 0) && j == 3 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        res1 += 2;
                    }
                    if (i == 2 && j == 3 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        res1 += 3;
                    }
                    if (i == 3 && j == 3 && Convert.ToBoolean(dataGridView3.Rows[i].Cells[j].Value))
                    {
                        res1 += 4;
                    }

                }
            }
            //4
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                for (int j = 1; j < dataGridView4.ColumnCount; j++)
                {
                    if ((i == 0 || i==1) && j == 2 && Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        res1 += 1;
                    }
                    if (i == 0  && j == 3 && Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        res1 += 2;
                    }

                    if (((i==0 && j==4)||(i == 1 && j == 3) ||(i == 2 && j == 2))&& Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        res1 += 3;
                    }
                    if (((i == 1 && j == 4) || (i == 2 && j == 3) ) && Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        res1 += 4;
                    }
                    if (i == 2 && j == 4 && Convert.ToBoolean(dataGridView4.Rows[i].Cells[j].Value))
                    {
                        res1 += 5;
                    }
                }
            }
            //5
            for (int i = 0; i < dataGridView5.RowCount; i++)
            {
                for (int j = 1; j < dataGridView5.ColumnCount; j++)
                {
                    if (((j == 1 && (i == 0 || i == 1)) || (j == 2 && i == 2)) && Convert.ToBoolean(dataGridView5.Rows[i].Cells[j].Value))
                    {
                        res2 += 2;
                    }
                    if (((j == 1 && i == 2) || (j == 2 && i == 3)) && Convert.ToBoolean(dataGridView5.Rows[i].Cells[j].Value))
                    {
                        res2 += 3;
                    }
                    if (i==3 && j== 1 && Convert.ToBoolean(dataGridView5.Rows[i].Cells[j].Value))
                    {
                        res2 += 5;
                    }
                    if ((j==2 && (i==0 || i==2))&& Convert.ToBoolean(dataGridView5.Rows[i].Cells[j].Value))
                    {
                        res2 += 1;
                    }
                }
            }
            //11
            for (int i = 0; i < dataGridView11.RowCount; i++)
            {
                for (int j = 1; j < dataGridView11.ColumnCount; j++)
                {
                    if (((i == 0 && j == 2) || (i == 1 && j == 2)) && Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        res2 += 1;
                    }
                    if (((i==2 && j==2)|| (j==3 &&(i==0 || i==1)) ) && Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        res2 += 2;
                    }
                    if (((i == 3 && j == 2) || (i == 2 && j == 3) || (j == 4 && (i == 0 || i == 1))) && Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        res2 += 3;
                    }
                    if (i == 3 && j == 4 && Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        res2 += 5;
                    }
                    if (((i == 3 && j == 3) || (i == 2 && j == 4)) && Convert.ToBoolean(dataGridView11.Rows[i].Cells[j].Value))
                    {
                        res2 += 4;
                    }
                
            }

            }
            //6
            for (int i = 0; i < dataGridView6.RowCount; i++)
            {
                for (int j = 1; j < dataGridView6.ColumnCount; j++)
                {
                    if ((i == 1 || i == 0) && j == 2 && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 1;
                    }
                    if (i == 2 && j == 2 && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 2;
                    }
                    if (i == 3 && j == 2 && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 3;
                    }

                    if ((i == 1 || i == 0) && j == 3 && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 2;
                    }
                    if (i == 2 && j == 3 && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 3;
                    }
                    if (((i == 3 && j == 3) || (i == 2 && j == 4)) && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 4;
                    }
                    if (j == 4 && (i == 0 || i == 1) && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 3;
                    }
                    if ((i == 3 && j == 4) && Convert.ToBoolean(dataGridView6.Rows[i].Cells[j].Value))
                    {
                        res2 += 5;
                    }

                }
            }
            //7
            for (int i = 0; i < dataGridView7.RowCount; i++)
            {
                for (int j = 1; j < dataGridView7.ColumnCount; j++)
                {
                    if ((i == 1 || i == 0) && j == 2 && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 1;
                    }
                    if (i == 2 && j == 2 && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                    }
                    if (i == 3 && j == 2 && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }

                    if ((i == 1 || i == 0) && j == 3 && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                    }
                    if (i == 2 && j == 3 && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }
                    if (((i == 3 && j == 3) || (i == 2 && j == 4)) && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 4;
                    }
                    if (j == 4 && (i == 0 || i == 1) && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }
                    if ((i == 3 && j == 4) && Convert.ToBoolean(dataGridView7.Rows[i].Cells[j].Value))
                    {
                        res3 += 5;
                    }

                }
            }
            //8
            for (int i = 0; i < dataGridView8.RowCount; i++)
            {
                for (int j = 1; j < dataGridView8.ColumnCount; j++)
                {
                    if ((i == 1 || i == 0) && j == 2 && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 1;
                    }
                    if (i == 2 && j == 2 && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                    }
                    if (i == 3 && j == 2 && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }

                    if ((i == 1 || i == 0) && j == 3 && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                    }
                    if (i == 2 && j == 3 && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }
                    if (((i == 3 && j == 3) || (i == 2 && j == 4)) && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 4;
                    }
                    if (j == 4 && (i == 0 || i == 1) && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                    }
                    if ((i == 3 && j == 4) && Convert.ToBoolean(dataGridView8.Rows[i].Cells[j].Value))
                    {
                        res3 += 5;
                    }

                }
            }
            //9
            for (int i = 0; i < dataGridView9.RowCount; i++)
            {
                for (int j = 1; j < dataGridView9.ColumnCount; j++)
                {
                    if ((j==3 && (i==0 || i==1 )) && Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        res3 += 1;
                        Console.WriteLine("ADD 1");
                    }
                    if (((j==2 && (i==0 || i==1)) || (j==3 && i==2)) && Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                        Console.WriteLine("ADD 2");
                    }
                    if (((j == 1 && (i == 0 || i == 1)) || (j == 2 && i == 2) || (j == 3 && (i == 3 || i == 4))) && Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        res3 += 3;
                        Console.WriteLine("ADD 3");
                    }
                    if (((j==1 && i==2)||(j==2 & (i==3 || i==4)))&& Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        res3 += 4;
                        Console.WriteLine("ADD 4");
                    }
                    if ((j==1 && (i==3 || i==4))&& Convert.ToBoolean(dataGridView9.Rows[i].Cells[j].Value))
                    {
                        res3 += 5;
                        Console.WriteLine("ADD 5");
                    }

                }

            }
            //10
            for (int i = 0; i < dataGridView10.RowCount; i++)
            {
                for (int j = 1; j < dataGridView10.ColumnCount; j++)
                {
                    if (j == 1 && (i == 0 || i == 1) && Convert.ToBoolean(dataGridView10.Rows[i].Cells[j].Value))
                    {
                        res3 += 2;
                    }
                }
            }
            //radio
            //1
            {
                if (!radioButton1.Checked)
                {
                    res1 += 2;
                }
            }
            //2
            {
                if (radioButton3.Checked)
                {
                    res4 += 1;
                }
                if (radioButton5.Checked)
                {
                    res4 += 2;
                }
            }
            //3
            {
                if (radioButton8.Checked)
                {
                    res4 += 3;
                }
                if (radioButton7.Checked)
                {
                    res4 += 1;
                }
            }
            //4
            {
                if (radioButton10.Checked)
                {
                    res4 += 2;
                }
            }
            //5
            {
                if (radioButton13.Checked)
                {
                    res4 += 1;
                }
                if (radioButton12.Checked)
                {
                    res4 += 2;
                }
                if (radioButton9.Checked)
                {
                    res4 += 3;
                }

            }
            //6
            {
                if (radioButton16.Checked)
                {
                    res4 += 1;
                }
                if (radioButton15.Checked)
                {
                    res4 += 2;
                }
                if (radioButton18.Checked)
                {
                    res4 += 3;
                }
            }

            //результат
            //1
            string r1="";
            if (res1 < 6)
            {
                r1 = "Нет риска";
            }
            else
            {
                if (res1 < 18)
                {
                    r1 = "Низкий риск";
                }
                else
                {
                    if (res1 < 33)
                    {
                        r1 = "Средний риск";
                    }
                    else
                    {
                        r1 = "Высокий риск";
                    }
                }
            }
            //2
            string r2 = "";
            if (res2 < 6)
            {
                r2 = "Нет риска";
            }
            else
            {
                if (res2 < 17)
                {
                    r2 = "Низкий риск";
                }
                else
                {
                    if (res2 < 38)
                    {
                        r2 = "Средний риск";
                    }
                    else
                    {
                        r2 = "Высокий риск";
                    }
                }
            }
            //3
            string r3 = "";
            if (res3 < 8)
            {
                r3 = "Нет риска";
            }
            else
            {
                if (res3 < 23)
                {
                    r3 = "Низкий риск";
                }
                else
                {
                    if (res3 < 43)
                    {
                        r3 = "Средний риск";
                    }
                    else
                    {
                        r3 = "Высокий риск";
                    }
                }
            }
            //4
            string r4 = "";
            if (res4 < 6)
            {
                r4 = "Нет риска";
            }
            else
            {
                if (res4 < 11)
                {
                    r4 = "Низкий риск";
                }
                else
                {
                    if (res4 < 17)
                    {
                        r4 = "Средний риск";
                    }
                    else
                    {
                        r4 = "Высокий риск";
                    }
                }
            }
            string r= "Семейный: " +r1 +", \n Психологический : "+ r2+", \n Ближайшего окружения:" + r3 + ", \n Образовательный :" + r4;
            MessageBox.Show(r, "Результаты", MessageBoxButtons.OK);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Check())
            {
                Анализ();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены или выбрано более одного варианта", "Внимание", MessageBoxButtons.OK);
            }
        }
    }
}
