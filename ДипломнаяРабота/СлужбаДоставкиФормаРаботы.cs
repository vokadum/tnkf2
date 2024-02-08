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
    public partial class СлужбаДоставкиФормаРаботы : Form
    {

        public СлужбаДоставкиФормаРаботы()
        {
            InitializeComponent();
        }

        private void службаДоставкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.службаДоставкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void СлужбаДоставкиФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.СлужбаДоставки". При необходимости она может быть перемещена или удалена.
            this.службаДоставкиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СлужбаДоставки);
            this.Width = 433;
            this.Height = 336;
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
                            службаДоставкиBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о службе доставки.";
                        }
                        if (data.mode == 2)
                        {
                            int pos = службаДоставкиBindingSource.Find("КодСД", data.kod);
                            службаДоставкиBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о службе доставки.";
                            maskedTextBox1.Text = телефонTextBox.Text;
                        }
                        if (data.mode == 3)
                        {
                            int pos = службаДоставкиBindingSource.Find("КодСД", data.kod);
                            службаДоставкиBindingSource.Position = pos;
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
                телефонTextBox.Text = maskedTextBox1.Text;
                if (кодСДTextBox.Text != "")
                {
                    if (наименование_ОгранизацииTextBox.Text != "")
                    {
                        if (номерДоговораTextBox.Text != "")
                        {
                            if(факсTextBox.Text != "")
                            {
                                if (maskedTextBox1.Text != "")
                            {
                                if (maskedTextBox1.MaskCompleted == true)
                                {
                                    if (e_mailTextBox.Text != "")
                                    {
                                        if (data.mode == 1)
                                        {
                                            maskedTextBox1.BackColor = Color.LightGreen;
                                            e_mailTextBox.BackColor = Color.LightGreen;
                                            номерДоговораTextBox.BackColor = Color.LightGreen;
                                            наименование_ОгранизацииTextBox.BackColor = Color.LightGreen;
                                            кодСДTextBox.BackColor = Color.LightGreen;
                                                факсTextBox.BackColor = Color.LightGreen;
                                                MessageBox.Show("Новая служба доставки, добавлена.", "Служба доставки.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.службаДоставкиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                        }
                                        if (data.mode == 2)
                                        {
                                            телефонTextBox.Text = maskedTextBox1.Text;
                                            maskedTextBox1.BackColor = Color.LightGreen;
                                            e_mailTextBox.BackColor = Color.LightGreen;
                                                факсTextBox.BackColor = Color.LightGreen;
                                                номерДоговораTextBox.BackColor = Color.LightGreen;
                                            наименование_ОгранизацииTextBox.BackColor = Color.LightGreen;
                                            кодСДTextBox.BackColor = Color.LightGreen;
                                            MessageBox.Show("Данные успешно изменены.", "Cлужба доставки.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.службаДоставкиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        e_mailTextBox.BackColor = Color.LightPink;
                                        e_mailTextBox.Focus();
                                        MessageBox.Show("Укажите код заказа.", "Данные не заполнены.");
                                    }
                                }
                                else if (maskedTextBox1.MaskCompleted == false)
                                {
                                    maskedTextBox1.BackColor = Color.LightPink;
                                    e_mailTextBox.BackColor = Color.LightPink;
                                    maskedTextBox1.Focus();
                                    MessageBox.Show("Номер телефона должен состоять из 11 символов. \n Введите данные еще раз.");
                                }
                            }
                            else
                            {
                                maskedTextBox1.BackColor = Color.LightPink;
                                e_mailTextBox.BackColor = Color.LightPink;
                                maskedTextBox1.Focus();
                                MessageBox.Show("Укажите номер телефона, службы доставки.", "Данные не заполнены!!!");
                            }
                            }
                            else
                            {
                                maskedTextBox1.BackColor = Color.LightPink;
                                e_mailTextBox.BackColor = Color.LightPink;
                                факсTextBox.BackColor = Color.LightPink;
                                факсTextBox.Focus();
                                MessageBox.Show("Укажите номер телефона, службы доставки.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            maskedTextBox1.BackColor = Color.LightPink;
                            факсTextBox.BackColor = Color.LightPink;
                            e_mailTextBox.BackColor = Color.LightPink;
                            номерДоговораTextBox.BackColor = Color.LightPink;
                            номерДоговораTextBox.Focus();
                            MessageBox.Show("Укажите номер договора.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        maskedTextBox1.BackColor = Color.LightPink;
                        e_mailTextBox.BackColor = Color.LightPink;
                        номерДоговораTextBox.BackColor = Color.LightPink;
                        факсTextBox.BackColor = Color.LightPink;
                        наименование_ОгранизацииTextBox.BackColor = Color.LightPink;
                        наименование_ОгранизацииTextBox.Focus();
                        MessageBox.Show("Укажите наименование организации.", "Данные не заполнены!!!");
                    }
                }
                else
                {
                    maskedTextBox1.BackColor = Color.LightPink;
                    e_mailTextBox.BackColor = Color.LightPink;
                    номерДоговораTextBox.BackColor = Color.LightPink;
                    наименование_ОгранизацииTextBox.BackColor = Color.LightPink;
                    факсTextBox.BackColor = Color.LightPink;
                    кодСДTextBox.BackColor = Color.LightPink;
                    кодСДTextBox.Focus();
                    MessageBox.Show("Укажите код службы доставки.", "Данные не заполнены!!!");
                }
            }
            catch { Console.WriteLine("Ошибка программы!" + "Обратитесь к разрботчику.", "Системаная ошибка!", MessageBoxIcon.Warning); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void номерДоговораTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
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

        private void СлужбаДоставкиФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            { button1_Click(button1, null); }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?","Выход.",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                { this.Close(); }
            }
        }
    }
}
