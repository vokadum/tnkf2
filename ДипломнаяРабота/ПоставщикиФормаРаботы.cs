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
    public partial class ПоставщикиФормаРаботы : Form
    {
        public ПоставщикиФормаРаботы()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void ПоставщикиФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
            this.Width = 443;
            this.Height = 375;
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
                            поставщикиBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о поставщике";
                        }
                        if (data.mode == 2)
                        {
                            int pos = поставщикиBindingSource.Find("КодП", data.kod);
                            поставщикиBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о поставщике";
                            maskedTextBox3.Text = телефонTextBox.Text;
                        }
                        if (data.mode == 3)
                        {
                            int pos = поставщикиBindingSource.Find("КодП", data.kod);
                            поставщикиBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (кодПTextBox.Text != "")
            {
                    if (наименование_организацииTextBox.Text != "")
                    {
                        if (номерДоговораTextBox.Text != "")
                        {
                            if (факсTextBox.Text != "")
                            {
                                if (maskedTextBox3.Text != "")
                                {
                                if (e_mailTextBox.Text != "")
                                {
                                    if (maskedTextBox3.MaskCompleted == true)
                                    {
                                        if (data.mode == 1)
                                        {
                                            телефонTextBox.Text = maskedTextBox3.Text;
                                            e_mailTextBox.BackColor = Color.LightGreen;
                                            maskedTextBox3.BackColor = Color.LightGreen;
                                            факсTextBox.BackColor = Color.LightGreen;
                                            номерДоговораTextBox.BackColor = Color.LightGreen;
                                            наименование_организацииTextBox.BackColor = Color.LightGreen;
                                            кодПTextBox.BackColor = Color.LightGreen;
                                            MessageBox.Show("Сотрудник успешно добавлен", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Validate();
                                            this.поставщикиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                        }
                                        if (data.mode == 2)
                                        {
                                            телефонTextBox.Text = maskedTextBox3.Text;
                                            e_mailTextBox.BackColor = Color.LightGreen;
                                            maskedTextBox3.BackColor = Color.LightGreen;
                                            факсTextBox.BackColor = Color.LightGreen;
                                            номерДоговораTextBox.BackColor = Color.LightGreen;
                                            наименование_организацииTextBox.BackColor = Color.LightGreen;
                                            кодПTextBox.BackColor = Color.LightGreen;
                                            MessageBox.Show("Данные успешно изменены.", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Validate();
                                            this.поставщикиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Номер телефона должен состоять из 11 символов. \n Введите данные еще раз.");
                                        maskedTextBox3.BackColor = Color.LightPink;
                                        maskedTextBox3.Focus();
                                    }
                                }
                                else
                                {
                                    e_mailTextBox.BackColor = Color.LightPink;
                                    e_mailTextBox.Focus();
                                    MessageBox.Show("Укажие e-mail.", "Данные не заполнены!!!");
                                }

                                }
                            else
                            {
                                e_mailTextBox.BackColor = Color.LightPink;
                                maskedTextBox3.BackColor = Color.LightPink;
                                maskedTextBox3.Focus();
                                MessageBox.Show("Заполните данные о номере телефона.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            e_mailTextBox.BackColor = Color.LightPink;
                            maskedTextBox3.BackColor = Color.LightPink;
                            факсTextBox.BackColor = Color.LightPink;
                            факсTextBox.Focus();
                            MessageBox.Show("Укажите факс поставщика.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        e_mailTextBox.BackColor = Color.LightPink;
                        maskedTextBox3.BackColor = Color.LightPink;
                        факсTextBox.BackColor = Color.LightPink;
                        номерДоговораTextBox.BackColor = Color.LightPink;
                        номерДоговораTextBox.Focus();
                        MessageBox.Show("Укажите номер договора поставщика.", "Данные не заполнены!!!");
                    }
                    }
                    else
                    {
                    e_mailTextBox.BackColor = Color.LightPink;
                    maskedTextBox3.BackColor = Color.LightPink;
                    факсTextBox.BackColor = Color.LightPink;
                    номерДоговораTextBox.BackColor = Color.LightPink;
                    наименование_организацииTextBox.BackColor = Color.LightPink;
                    наименование_организацииTextBox.Focus();
                    MessageBox.Show("Укажите наименование организации поставщика.", "Данные не заполнены!!!");
                }
            }
            else
            {
                e_mailTextBox.BackColor = Color.LightPink;
                maskedTextBox3.BackColor = Color.LightPink;
                факсTextBox.BackColor = Color.LightPink;
                номерДоговораTextBox.BackColor = Color.LightPink;
                наименование_организацииTextBox.BackColor = Color.LightPink;
                кодПTextBox.BackColor = Color.LightPink;
                кодПTextBox.Focus();
                MessageBox.Show("Укажите код поставщика.", "Данные не заполнены!!!");
            }
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

        private void ПоставщикиФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            { button1_Click(button1, null); }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
