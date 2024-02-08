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

    public partial class ПользователиФормаРаботы : Form
    {
        

        public ПользователиФормаРаботы()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void ПользователиФормаРаботы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
            this.Width = 413;
            this.Height = 295;
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
                            textBox1.Focus();
                            пользователиBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи \n о пользоваетиле";
                        }
                        if (data.mode == 2)
                        {
                            int pos = пользователиBindingSource.Find("Код", data.kod);
                            пользователиBindingSource.Position = pos;
                            textBox1.Text = кодTextBox.Text;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных \n о пользователе" +
                                "";
                        }
                        if (data.mode == 3)
                        {
                            int pos = пользователиBindingSource.Find("Код", data.kod);
                            пользователиBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (логинTextBox.Text != "")
                {
                    if (comboBox2.Text != "")
                    {
                        if (парольTextBox.Text != "")
                        {

                            if (data.mode == 1)
                            {
                                if (сотрудникиBindingSource.Find("НомерСотрудника", textBox1.Text) != -1) // Проверяем логин на наличие в базе данных
                                {
                                    кодTextBox.Text = textBox1.Text;
                                    кодTextBox.BackColor = Color.LightGreen;
                                    логинTextBox.BackColor = Color.LightGreen;
                                    comboBox2.BackColor = Color.LightGreen;
                                    парольTextBox.BackColor = Color.LightGreen;
                                    MessageBox.Show("Учетная запись сотрудника, успешно создана", "Пользователи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Validate();
                                    this.пользователиBindingSource.EndEdit();
                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Данные сотрудника не обнаружены, проверьте вводимы номер сотрудника", "Система", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    textBox1.Focus();
                                }
                            }
                            if (data.mode == 2)
                            {
                                кодTextBox.BackColor = Color.LightGreen;
                                логинTextBox.BackColor = Color.LightGreen;
                                comboBox2.BackColor = Color.LightGreen;
                                парольTextBox.BackColor = Color.LightGreen;
                                MessageBox.Show("Данные успешно изменены.", "Пользователи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Validate();
                                this.пользователиBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                this.Close();
                            }
                        }
                        else
                        {
                            парольTextBox.BackColor = Color.LightPink;
                            парольTextBox.Focus();
                            MessageBox.Show("Придумайте пароль, для входа в систему.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        comboBox2.BackColor = Color.LightPink;
                        comboBox2.Focus();
                        MessageBox.Show("Укажите должность сотрудника.", "Данные не заполнены!!!");
                    }
                }
                else
                {
                    логинTextBox.BackColor = Color.LightPink;
                    логинTextBox.Focus();
                    MessageBox.Show("Придумайте логин пользователя, для входа в систему.", "Данные не заполнены!!!");
                }


            }
            catch { Console.WriteLine("Ошибка программы!" + "Обратитесь к разрботчику.", "Системаная ошибка!", MessageBoxIcon.Warning); }
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

        private void ПользователиФормаРаботы_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?", "Закрыте.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void пользователиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (data.mode == 2)
            //{
            //    foreach (DataGridViewRow row in сотрудникиDataGridView.Rows)
            //    {
                    
            //    }
                
            //}
        }

        private void логинTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            логинTextBox.BackColor = Color.White;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void парольTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            парольTextBox.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
