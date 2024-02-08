using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДипломнаяРабота
{
    public partial class НаклодныеФорма : Form
    {
        public НаклодныеФорма()
        {
            InitializeComponent();
        }
        public static DateTime date = DateTime.Now;
        private void приклоднаяНаклоднаяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.приклоднаяНаклоднаяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void НаклодныеФорма_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная". При необходимости она может быть перемещена или удалена.
            this.приклоднаяНаклоднаяTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная);
            this.Width = 404;
            this.Height = 316;
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {
                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(2, 0);


                        if (data.mode == 1)
                        {
                            приклоднаяНаклоднаяBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о товаре";
                        }
                        if (data.mode == 2)
                        {
                            comboBox1.Text = товарTextBox.Text;
                            int pos = приклоднаяНаклоднаяBindingSource.Find("Код", data.kod);
                            приклоднаяНаклоднаяBindingSource.Position = pos;

                            button1.Text = "Изменить данные";
                        }
                        if (data.mode == 3)
                        {
                            int pos = приклоднаяНаклоднаяBindingSource.Find("Код", data.kod);
                            приклоднаяНаклоднаяBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (кодTextBox.Text != "")
                {
                    if (comboBox1.Text != "")
                    {
                        if (количествоTextBox.Text != "")
                        {
                            if (ценаTextBox.Text != "")
                            {

                                if (data.mode == 1)
                                {
                                    prixod.kolichestvo = Convert.ToInt32(количествоTextBox.Text);
                                    comboBox1.Visible = false;
                                    товарTextBox.Text = comboBox1.Text;
                                    кодTextBox.BackColor = Color.LightGreen;
                                    товарTextBox.BackColor = Color.LightGreen;
                                    количествоTextBox.BackColor = Color.LightGreen;
                                    ценаTextBox.BackColor = Color.LightGreen;
                                    общаяСтоимостьTextBox.BackColor = Color.LightGreen;
                                    датаПоступлениеTextBox.BackColor = Color.LightGreen;
                                    датаПоступлениеTextBox.Text = date.ToString("dd.MM.yyyy | HH.mm");
                                    int summ = 0;
                                    summ = Convert.ToInt32(ценаTextBox.Text) * Convert.ToInt32(количествоTextBox.Text);
                                    общаяСтоимостьTextBox.Text = Convert.ToString(summ);
                                    MessageBox.Show("Поступление товара успешно добавлено", "Прикладная накладная", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.приклоднаяНаклоднаяBindingSource.EndEdit();
                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                    this.Close();
                                }
                                if (data.mode == 2)
                                {
                                    prixod.kolichestvo = Convert.ToInt32(количествоTextBox.Text);
                                    comboBox1.Visible = false;
                                    товарTextBox.Text = comboBox1.Text;
                                    товарTextBox.BackColor = Color.LightGreen;
                                    количествоTextBox.BackColor = Color.LightGreen;
                                    ценаTextBox.BackColor = Color.LightGreen;
                                    общаяСтоимостьTextBox.BackColor = Color.LightGreen;
                                    датаПоступлениеTextBox.BackColor = Color.LightGreen;
                                    кодTextBox.BackColor = Color.LightGreen;
                                    int summ = 0;
                                    summ = Convert.ToInt32(ценаTextBox.Text) * Convert.ToInt32(количествоTextBox.Text);
                                    общаяСтоимостьTextBox.Text = Convert.ToString(summ);
                                    MessageBox.Show("Данные успешно изменены.", "Прикладная накладная", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.приклоднаяНаклоднаяBindingSource.EndEdit();
                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                    this.Close();
                                }
                                                
                                                
                            }
                            else
                            {
                                ценаTextBox.BackColor = Color.LightPink;
                                ценаTextBox.Focus();
                                MessageBox.Show("Укажите цену товара", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            ценаTextBox.BackColor = Color.LightPink;
                            количествоTextBox.BackColor = Color.LightPink;
                            количествоTextBox.Focus();
                            MessageBox.Show("Укажите количество товара", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        ценаTextBox.BackColor = Color.LightPink;
                        количествоTextBox.BackColor = Color.LightPink;
                        comboBox1.BackColor = Color.LightPink;
                        comboBox1.Focus();
                        MessageBox.Show("Укажите название товара.", "Данные не заполнены!!!");
                    }
                }
                else
                {

                }



            }
            catch { Console.WriteLine("Ошибка программы!" + "Обратитесь к разрботчику.", "Системаная ошибка!", MessageBoxIcon.Warning); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(101, 169, 215);
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(118, 176, 212);
            button1.FlatStyle = FlatStyle.Standard;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(101, 169, 215);
            button2.FlatStyle = FlatStyle.Flat;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(118, 176, 212);
            button2.FlatStyle = FlatStyle.Standard;
        }
    }
}
