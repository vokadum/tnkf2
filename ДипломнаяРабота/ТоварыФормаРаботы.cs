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
    public partial class ТоварыФормаРаботы : Form
    {
        public ТоварыФормаРаботы()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void ТоварыФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.КаталогТоваров". При необходимости она может быть перемещена или удалена.
            this.каталогТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.КаталогТоваров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {

                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(2, 0);

                        this.Width = 456;
                        this.Height = 364;

                        if (data.mode == 1)
                        {
                            товарыBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о товаре";
                        }
                        if (data.mode == 2)
                        {
                            int pos = товарыBindingSource.Find("КодТ", data.kod);
                            товарыBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о товаре";
                        }
                        if (data.mode == 3)
                        {
                            int pos = товарыBindingSource.Find("КодТ", data.kod);
                            товарыBindingSource.Position = pos;
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
               
                    if (кодТTextBox.Text != "")
                    {
                        if (название_товараTextBox.Text != "")
                        {
                            if (ценаTextBox.Text != "")
                            {
                                if (количествоСкладTextBox.Text != "")
                                {
                                    if (comboBox1.Text != "")
                                    {
                                        if (comboBox2.Text != "")
                                        {
                                            if (единицаИзмеренияTextBox.Text != "")
                                            {
                                                if (data.mode == 1)
                                                {
                                                    единицаИзмеренияTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    comboBox1.BackColor = Color.LightGreen;
                                                    количествоСкладTextBox.BackColor = Color.LightGreen;
                                                    ценаTextBox.BackColor = Color.LightGreen;
                                                    название_товараTextBox.BackColor = Color.LightGreen;
                                                    кодТTextBox.BackColor = Color.LightGreen;
                                                    this.Validate();
                                                    this.товарыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();
                                                    MessageBox.Show("Запись о товаре успешно добавлена.", "Товары.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                }
                                                else if (data.mode == 2)
                                                {
                                                    единицаИзмеренияTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    comboBox1.BackColor = Color.LightGreen;
                                                    количествоСкладTextBox.BackColor = Color.LightGreen;
                                                    ценаTextBox.BackColor = Color.LightGreen;
                                                    название_товараTextBox.BackColor = Color.LightGreen;
                                                    кодТTextBox.BackColor = Color.LightGreen;
                                                    this.Validate();
                                                    this.товарыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();
                                                    MessageBox.Show("Данные успешно изменены.", "Товары.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                            else
                                            {
                                                единицаИзмеренияTextBox.BackColor = Color.LightPink;
                                                единицаИзмеренияTextBox.Focus();
                                                MessageBox.Show("Укажите единицу измерения.", "Данные не заполнены!!!");
                                            }
                                        }
                                        else
                                        {
                                            единицаИзмеренияTextBox.BackColor = Color.LightPink;
                                            comboBox1.BackColor = Color.LightPink;
                                            comboBox2.Focus();
                                            MessageBox.Show("Заполните данные о коде раздела.", "Данные не заполнены!!!");
                                        }
                                    }
                                    else
                                    {
                                        единицаИзмеренияTextBox.BackColor = Color.LightPink;
                                        comboBox2.BackColor = Color.LightPink;
                                        comboBox1.BackColor = Color.LightPink;
                                        comboBox1.Focus();
                                        MessageBox.Show("Заполните данные о коде поставщика.", "Данные не заполнены!!!");
                                    }
                                }
                                else
                                {
                                    единицаИзмеренияTextBox.BackColor = Color.LightPink;
                                    comboBox2.BackColor = Color.LightPink;
                                    comboBox1.BackColor = Color.LightPink;
                                    количествоСкладTextBox.BackColor = Color.LightPink;
                                    количествоСкладTextBox.Focus();
                                    MessageBox.Show("Укажите количество товара на складе.", "Данные не заполнены!!!");
                                }
                            }
                            else
                            {
                                единицаИзмеренияTextBox.BackColor = Color.LightPink;
                                comboBox2.BackColor = Color.LightPink;
                                comboBox1.BackColor = Color.LightPink;
                                количествоСкладTextBox.BackColor = Color.LightPink;
                                ценаTextBox.BackColor = Color.LightPink;
                                ценаTextBox.Focus();
                                MessageBox.Show("Укажите цену товара.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            единицаИзмеренияTextBox.BackColor = Color.LightPink;
                            comboBox2.BackColor = Color.LightPink;
                            comboBox1.BackColor = Color.LightPink;
                            количествоСкладTextBox.BackColor = Color.LightPink;
                            ценаTextBox.BackColor = Color.LightPink;
                            название_товараTextBox.BackColor = Color.LightPink;
                            название_товараTextBox.Focus();
                            MessageBox.Show("Введите название товара.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        единицаИзмеренияTextBox.BackColor = Color.LightPink;
                        comboBox2.BackColor = Color.LightPink;
                        comboBox1.BackColor = Color.LightPink;
                        количествоСкладTextBox.BackColor = Color.LightPink;
                        ценаTextBox.BackColor = Color.LightPink;
                        название_товараTextBox.BackColor = Color.LightPink;
                        кодТTextBox.BackColor = Color.LightPink;
                        кодТTextBox.Focus();
                        MessageBox.Show("Укажите код товара.", "Данные не заполнены!!!");
                    }
            }
            catch { Console.WriteLine("Ошибка программы! \n Обратитесь к разарботчику.", "Системаная ошибка.", MessageBoxIcon.Warning); }
        }

        private void ценаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ценаTextBox.BackColor = Color.White;
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

        private void ТоварыФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?","Выход.",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                { this.Close(); }
            }
        }

        private void название_товараTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            название_товараTextBox.BackColor = Color.White;
        }

        private void количествоСкладTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            количествоСкладTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void единицаИзмеренияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            единицаИзмеренияTextBox.BackColor = Color.White;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }
    }
}


