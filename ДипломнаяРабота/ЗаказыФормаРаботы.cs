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
    public partial class ЗаказыФормаРаботы : Form
    {
        public ЗаказыФормаРаботы()
        {
            InitializeComponent();
        }
        public static DateTime date = DateTime.Now;

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void ЗаказыФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.СтатусЗаказа". При необходимости она может быть перемещена или удалена.
            this.статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.СлужбаДоставки". При необходимости она может быть перемещена или удалена.
            this.службаДоставкиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СлужбаДоставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
            this.Width = 398;
            this.Height = 382;
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
                            comboBox6.Enabled = false;
                            заказыBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о заказе";
                            comboBox6.Text = "Ожидает отправки";


                        }
                        if (data.mode == 2)
                        {
                            comboBox6.Enabled = false;
                            int pos = заказыBindingSource.Find("НомерЗаказа", data.kod);
                            заказыBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о заказе";
                            maskedTextBox1.Text = телефонTextBox.Text;
                            nmr.Text = номерЗаказаTextBox.Text;
                            comboBox6.Text = "Ожидает отправки";

                        }
                        if (data.mode == 3)
                        {
                            comboBox6.Enabled = false;
                            int pos = заказыBindingSource.Find("НомерЗаказа", data.kod);
                            заказыBindingSource.Position = pos;
                        }
                        if (data.mode == 4)
                        {
                            comboBox6.Enabled = true;
                            int index = статусЗаказаBindingSource.Find("Код", data.kod);
                            заказыBindingSource.Position = index;
                            int pos = заказыBindingSource.Find("НомерЗаказа", data.kod);
                            заказыBindingSource.Position = pos;
                            maskedTextBox1.Text = телефонTextBox.Text;
                            nmr.Text = номерЗаказаTextBox.Text;
                            comboBox6.Text = статусTextBox.Text;
                            nmr.Enabled = false;
                            comboBox5.Enabled = false;
                            адрес_доставкиTextBox.Enabled = false;
                            maskedTextBox1.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                            comboBox3.Enabled = false;
                            comboBox4.Enabled = false;
                            comboBox6.Enabled = true;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            data.mode = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmr.Text != "")
                {
                    if (comboBox5.Text != "")
                    {
                        if (адрес_доставкиTextBox.Text != "")
                        {
                            if (maskedTextBox1.Text != "")
                            {
                                if (comboBox1.Text != "")
                                {
                                    if (comboBox2.Text != "")
                                    {
                                        if (comboBox3.Text != "")
                                        {
                                            if (comboBox4.Text != "")
                                            {
                                                if (maskedTextBox1.MaskCompleted == true)
                                                {

                                                    if (data.mode == 1)
                                                    {
                                                        номерЗаказаTextBox.Text = nmr.Text;
                                                        телефонTextBox.Text = maskedTextBox1.Text;
                                                        comboBox4.BackColor = Color.LightGreen;
                                                        comboBox3.BackColor = Color.LightGreen;
                                                        comboBox2.BackColor = Color.LightGreen;
                                                        comboBox1.BackColor = Color.LightGreen;
                                                        maskedTextBox1.BackColor = Color.LightGreen;
                                                        адрес_доставкиTextBox.BackColor = Color.LightGreen;
                                                        comboBox5.BackColor = Color.LightGreen;
                                                        nmr.BackColor = Color.LightGreen;
                                                        statys.kodZakaza = nmr.Text;
                                                        statys.KodKlienta = comboBox1.Text;
                                                        statys.Sbzakaza = comboBox3.Text;
                                                        statys.dataZakaza = date.ToString("dd.MM.yyyy | HH.mm");
                                                        statys.Statys = "Ожидает отправки";
                                                        this.Validate();
                                                        this.заказыBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                        this.Close();
                                                        MessageBox.Show("Новый заказ успешно добавлен", "Заказы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }

                                                    if (data.mode == 2)
                                                    {
                                                        телефонTextBox.Text = maskedTextBox1.Text;
                                                        comboBox4.BackColor = Color.LightGreen;
                                                        comboBox3.BackColor = Color.LightGreen;
                                                        comboBox2.BackColor = Color.LightGreen;
                                                        comboBox1.BackColor = Color.LightGreen;
                                                        maskedTextBox1.BackColor = Color.LightGreen;
                                                        адрес_доставкиTextBox.BackColor = Color.LightGreen;
                                                        comboBox5.BackColor = Color.LightGreen;
                                                        номерЗаказаTextBox.BackColor = Color.LightGreen;
                                                        nmr.BackColor = Color.LightGreen;
                                                        statys.kod = Convert.ToInt32(nmr.Text);
                                                        statys.kodZakaza = номерЗаказаTextBox.Text;
                                                        statys.KodKlienta = comboBox1.Text;
                                                        statys.dataZakaza = date.ToString("dd.MM.yyyy | HH.mm");
                                                        statys.Sbzakaza = comboBox3.Text;
                                                        statys.Statys = "Ожидает отправки";

                                                        this.Validate();
                                                        this.заказыBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                        this.Close();
                                                        MessageBox.Show("Данные успешно изменены.", "Заказы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    if (data.mode == 4)
                                                    {

                                                        телефонTextBox.Text = maskedTextBox1.Text;
                                                        comboBox4.BackColor = Color.LightGreen;
                                                        comboBox3.BackColor = Color.LightGreen;
                                                        comboBox2.BackColor = Color.LightGreen;
                                                        comboBox1.BackColor = Color.LightGreen;
                                                        comboBox6.BackColor = Color.LightGreen;
                                                        maskedTextBox1.BackColor = Color.LightGreen;
                                                        адрес_доставкиTextBox.BackColor = Color.LightGreen;
                                                        comboBox5.BackColor = Color.LightGreen;
                                                        номерЗаказаTextBox.BackColor = Color.LightGreen;
                                                        nmr.BackColor = Color.LightGreen;
                                                        data.mode = 4;
                                                        statys.kod = Convert.ToInt32(nmr.Text);
                                                        statys.kodZakaza = номерЗаказаTextBox.Text;
                                                        statys.KodKlienta = comboBox1.Text;
                                                        statys.dataZakaza = датаЗаказаTextBox.Text;
                                                        statys.Sbzakaza = comboBox3.Text;
                                                        statys.Statys = comboBox6.Text;
                                                        MessageBox.Show("Данные успешно изменены.", "Заказы - статус заказа.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        СтатусЗаказа статус = new СтатусЗаказа();
                                                        статус.Show();
                                                        this.Validate();
                                                        this.статусЗаказаBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                        this.Close();
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Номер телефона должен состоять из 11 символов. \n Введите данные еще раз.");
                                                    maskedTextBox1.BackColor = Color.LightPink;
                                                    maskedTextBox1.Focus();
                                                }
                                            }
                                            else
                                            {
                                                comboBox4.BackColor = Color.LightPink;
                                                comboBox4.Focus();
                                                MessageBox.Show("Укажите номер сотрудника, оформлявшего заказ.", "Данные не заполнены!!!");
                                            }
                                            
                                        }
                                        else
                                        {
                                            comboBox4.BackColor = Color.LightPink;
                                            comboBox3.BackColor = Color.LightPink;
                                            comboBox3.Focus();
                                            MessageBox.Show("Укажите службу доставки.", "Данные не заполнены!!!");
                                        }
                                    }
                                    else
                                    {
                                        comboBox4.BackColor = Color.LightPink;
                                        comboBox3.BackColor = Color.LightPink;
                                        comboBox2.BackColor = Color.LightPink;
                                        comboBox2.Focus();
                                        MessageBox.Show("Укажите код товара.", "Данные не заполнены!!!");
                                    }
                                }
                                else
                                {
                                    comboBox4.BackColor = Color.LightPink;
                                    comboBox3.BackColor = Color.LightPink;
                                    comboBox2.BackColor = Color.LightPink;
                                    comboBox1.BackColor = Color.LightPink;
                                    comboBox1.Focus();
                                    MessageBox.Show("Укажите код клиента.", "Данные не заполнены!!!");
                                }
                               
                            }
                            else
                            {
                                comboBox4.BackColor = Color.LightPink;
                                comboBox3.BackColor = Color.LightPink;
                                comboBox2.BackColor = Color.LightPink;
                                comboBox1.BackColor = Color.LightPink;
                                maskedTextBox1.BackColor = Color.LightPink;
                                maskedTextBox1.Focus();
                                MessageBox.Show("Укажите номер телефона.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            comboBox4.BackColor = Color.LightPink;
                            comboBox3.BackColor = Color.LightPink;
                            comboBox2.BackColor = Color.LightPink;
                            comboBox1.BackColor = Color.LightPink;
                            maskedTextBox1.BackColor = Color.LightPink;
                            адрес_доставкиTextBox.BackColor = Color.LightPink;
                            адрес_доставкиTextBox.Focus();
                            MessageBox.Show("Укажите адрес доставки, товара.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        comboBox4.BackColor = Color.LightPink;
                        comboBox3.BackColor = Color.LightPink;
                        comboBox2.BackColor = Color.LightPink;
                        comboBox1.BackColor = Color.LightPink;
                        maskedTextBox1.BackColor = Color.LightPink;
                        адрес_доставкиTextBox.BackColor = Color.LightPink;
                        comboBox5.BackColor = Color.LightPink;
                        comboBox5.Focus();
                        MessageBox.Show("Укажите название товара.", "Данные не заполнены!!!");
                    }
                }
                else
                {
                    comboBox4.BackColor = Color.LightPink;
                    comboBox3.BackColor = Color.LightPink;
                    comboBox2.BackColor = Color.LightPink;
                    comboBox1.BackColor = Color.LightPink;
                    maskedTextBox1.BackColor = Color.LightPink;
                    адрес_доставкиTextBox.BackColor = Color.LightPink;
                    comboBox5.BackColor = Color.LightPink;
                    nmr.BackColor = Color.LightPink;
                    nmr.Focus();
                    MessageBox.Show("Укажите название товара.", "Данные не заполнены!!!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте данные или обратитесь в службу поддержки", "Ошибка.");
            }
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            телефонTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void ЗаказыФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            { button1_Click(button1, null); }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?", "Закрытие.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { this.Close(); }
            }
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

        private void название_товараTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void адрес_доставкиTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            адрес_доставкиTextBox.BackColor = Color.White;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox5.BackColor = Color.White;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox3.BackColor = Color.White;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox4.BackColor = Color.White;
        }
        
    }
}
