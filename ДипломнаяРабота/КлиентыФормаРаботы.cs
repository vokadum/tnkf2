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
    public partial class КлиентыФормаРаботы : Form
    {
        public КлиентыФормаРаботы()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void КлиентыФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {

                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(2, 0);

                        this.Width = 334;
                        this.Height = 383;

                        if (data.mode == 1)
                        {
                           клиентыBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о клиенте";
                        }
                        if (data.mode == 2)
                        {
                            int pos =клиентыBindingSource.Find("Код", data.kod);
                           клиентыBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о клиенте";
                            maskedTextBox1.Text = номерТелефонаTextBox.Text;
                        }
                        if (data.mode == 3)
                        {
                            int pos = клиентыBindingSource.Find("Код", data.kod);
                           клиентыBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(кодTextBox.Text != "")
                {
                    if (фамилияTextBox.Text != "")
                    {   
                        if(имяTextBox.Text != "")
                        {
                            if (отчетсвоTextBox.Text != "")
                            {
                                if(серияИНомерTextBox.Text != "")
                                {
                                    if(адресПроживанияTextBox.Text != "")
                                    {
                                        if(кодЗаказаTextBox.Text != "")
                                        {
                                            if (maskedTextBox1.Text != "")
                                            {
                                                if(maskedTextBox1.MaskCompleted == true)
                                                {
                                                    if (data.mode == 1)
                                                    {
                                                        номерТелефонаTextBox.Text = maskedTextBox1.Text;
                                                        maskedTextBox1.BackColor = Color.LightGreen;
                                                        кодЗаказаTextBox.BackColor = Color.LightGreen;
                                                        адресПроживанияTextBox.BackColor = Color.LightGreen;
                                                        серияИНомерTextBox.BackColor = Color.LightGreen;

                                                        отчетсвоTextBox.BackColor = Color.LightGreen;
                                                        имяTextBox.BackColor = Color.LightGreen;
                                                        фамилияTextBox.BackColor = Color.LightGreen;
                                                        кодTextBox.BackColor = Color.LightGreen;
                                                        MessageBox.Show("Клиент успешно добавлен", "Клиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.клиентыBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                        this.Close();

                                                    }
                                                    if (data.mode == 2)
                                                    {
                                                        номерТелефонаTextBox.Text = maskedTextBox1.Text;
                                                        maskedTextBox1.BackColor = Color.LightGreen;
                                                        кодЗаказаTextBox.BackColor = Color.LightGreen;
                                                        адресПроживанияTextBox.BackColor = Color.LightGreen;
                                                        серияИНомерTextBox.BackColor = Color.LightGreen;

                                                        отчетсвоTextBox.BackColor = Color.LightGreen;
                                                        имяTextBox.BackColor = Color.LightGreen;
                                                        фамилияTextBox.BackColor = Color.LightGreen;
                                                        кодTextBox.BackColor = Color.LightGreen;
                                                        MessageBox.Show("Данные успешно изменены.", "Клиенты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.клиентыBindingSource.EndEdit();
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
                                                maskedTextBox1.BackColor = Color.LightPink;
                                                maskedTextBox1.Focus();
                                                MessageBox.Show("Заполните данные о номере телефона.", "Данные не заполнены!!!");
                                            }
                                        }
                                        else
                                        {
                                            maskedTextBox1.BackColor = Color.LightPink;
                                            кодЗаказаTextBox.BackColor = Color.LightPink;
                                            кодЗаказаTextBox.Focus();
                                            MessageBox.Show("Укажите код заказа клиента.", "Данные не заполнены!!!");
                                        }
                                    }
                                    else
                                    {
                                        maskedTextBox1.BackColor = Color.LightPink;
                                        кодЗаказаTextBox.BackColor = Color.LightPink;
                                        адресПроживанияTextBox.BackColor = Color.LightPink;
                                        адресПроживанияTextBox.Focus();
                                        MessageBox.Show("Укажите адрес проживания.", "Данные не заполнены!!!");
                                    }
                                }
                                else
                                {
                                    maskedTextBox1.BackColor = Color.LightPink;
                                    кодЗаказаTextBox.BackColor = Color.LightPink;
                                    адресПроживанияTextBox.BackColor = Color.LightPink;
                                    серияИНомерTextBox.BackColor = Color.LightPink;
                                    серияИНомерTextBox.Focus();
                                    MessageBox.Show("Укажите серию и номер паспорта.", "Данные не заполнены!!!");
                                }
                            }
                            else
                            {
                                maskedTextBox1.BackColor = Color.LightPink;
                                кодЗаказаTextBox.BackColor = Color.LightPink;
                                адресПроживанияTextBox.BackColor = Color.LightPink;
                                серияИНомерTextBox.BackColor = Color.LightPink;
                                отчетсвоTextBox.BackColor = Color.LightPink;
                                отчетсвоTextBox.Focus();
                                MessageBox.Show("Укажите отчество клиента.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            maskedTextBox1.BackColor = Color.LightPink;
                            кодЗаказаTextBox.BackColor = Color.LightPink;
                            адресПроживанияTextBox.BackColor = Color.LightPink;
                            серияИНомерTextBox.BackColor = Color.LightPink;
                            отчетсвоTextBox.BackColor = Color.LightPink;
                            имяTextBox.BackColor = Color.LightPink;
                            имяTextBox.Focus();
                            MessageBox.Show("Укажите имя клиента.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        maskedTextBox1.BackColor = Color.LightPink;
                        кодЗаказаTextBox.BackColor = Color.LightPink;
                        адресПроживанияTextBox.BackColor = Color.LightPink;
                        серияИНомерTextBox.BackColor = Color.LightPink;
                        отчетсвоTextBox.BackColor = Color.LightPink;
                        имяTextBox.BackColor = Color.LightPink;
                        фамилияTextBox.BackColor = Color.LightPink;
                        фамилияTextBox.Focus();
                        MessageBox.Show("Укажите фамилию клиента.", "Данные не заполнены!!!");
                        
                    }
                }
                else
                {
                    maskedTextBox1.BackColor = Color.LightPink;
                    кодЗаказаTextBox.BackColor = Color.LightPink;
                    адресПроживанияTextBox.BackColor = Color.LightPink;
                    серияИНомерTextBox.BackColor = Color.LightPink;
                    отчетсвоTextBox.BackColor = Color.LightPink;
                    имяTextBox.BackColor = Color.LightPink;
                    фамилияTextBox.BackColor = Color.LightPink;
                    кодTextBox.BackColor = Color.LightPink;
                    кодTextBox.Focus();
                    MessageBox.Show("Укажите код заказа клиента.", "Данные не заполнены!!!");
                }
                
                
                            
            }
            catch { Console.WriteLine("Ошибка программы!" + "Обратитесь к разрботчику.", "Системаная ошибка!", MessageBoxIcon.Warning); }
        }



        private void фамилияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            фамилияTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void кодTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void фамилияTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void имяTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void отчетсвоTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void КлиентыФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            { button1_Click(button1, null); }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Зарыть форму?","Закрытие.",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void имяTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            имяTextBox.BackColor = Color.White;
        }

        private void отчетсвоTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            отчетсвоTextBox.BackColor = Color.White;
        }

        private void датаРожденияDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            датаРожденияDateTimePicker.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void адресПроживанияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            адресПроживанияTextBox.BackColor = Color.White;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void кодЗаказаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            кодЗаказаTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void серияИНомерTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            серияИНомерTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void кодЗаказаTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
