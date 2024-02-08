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
    public partial class AddingForm : Form
    {
        ПользователиФормаРаботы пользователи = new ПользователиФормаРаботы();
        public string Txt
        {
            get
            {
                return Sotr.Text;
            }
            set
            {
                Sotr.Text = value;
            }
        }
        public string Txt2
        {
            get
            {
                return pol.Text;
            }
            set
            {
                pol.Text = value;
            }
        }
        public AddingForm()
        {
            InitializeComponent();
            
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            телефонTextBox.Visible = false;
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {

                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(2, 0);

                        this.Width = 415;
                        this.Height = 335;

                        if (data.mode == 1)
                        {
                            сотрудникиBindingSource.AddNew();
                            button1.Text = "Добавить запись";
                            label1.Text = "Добавление записи о сотруднике";
                        }
                        if (data.mode == 2)
                        {
                            int pos = сотрудникиBindingSource.Find("НомерСотрудника", data.kod);
                            сотрудникиBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            label1.Text = "Изменения данных о сотруднике";
                            maskedTextBox1.Text = телефонTextBox.Text;
                        }
                        if (data.mode == 3)
                        {
                            int pos = сотрудникиBindingSource.Find("НомерСотрудника", data.kod);
                            сотрудникиBindingSource.Position = pos;
                        }
                    }
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (номерСотрудникаTextBox.Text != "")
                {
                    if (фамилияTextBox.Text != "")
                    {
                        if (имяTextBox.Text != "")
                        {
                            if (отчествоTextBox.Text != "")
                            {

                                if (maskedTextBox1.Text != "")
                                {
                                    if (maskedTextBox1.MaskCompleted == true)
                                    {
                                        if (data.mode == 1)
                                        {
                                            номерСотрудникаTextBox.BackColor = Color.LightGreen;
                                            фамилияTextBox.BackColor = Color.LightGreen;
                                            имяTextBox.BackColor = Color.LightGreen;
                                            отчествоTextBox.BackColor = Color.LightGreen;
                                            comboBox1.BackColor = Color.LightGreen;
                                            comboBox1.Text = должностьTextBox.Text;
                                            maskedTextBox1.BackColor = Color.LightGreen;
                                            телефонTextBox.Text = maskedTextBox1.Text; this.Validate();
                                            this.сотрудникиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                            MessageBox.Show("Сотрудник успешно добавлен", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        if (data.mode == 2)
                                        {
                                            номерСотрудникаTextBox.BackColor = Color.LightGreen;
                                            фамилияTextBox.BackColor = Color.LightGreen;
                                            имяTextBox.BackColor = Color.LightGreen;
                                            отчествоTextBox.BackColor = Color.LightGreen;
                                            comboBox1.BackColor = Color.LightGreen;
                                            maskedTextBox1.BackColor = Color.LightGreen;
                                            телефонTextBox.Text = maskedTextBox1.Text;
                                            MessageBox.Show("Данные успешно изменены.", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Validate();
                                            this.сотрудникиBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                            this.Close();
                                        }
                                    }
                                    else if (maskedTextBox1.MaskCompleted == false)
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
                                отчествоTextBox.BackColor = Color.LightPink;
                                maskedTextBox1.BackColor = Color.LightPink;
                                comboBox1.BackColor = Color.LightPink;
                                отчествоTextBox.Focus();
                                MessageBox.Show("Заполните данные о должности сотрудника.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            отчествоTextBox.BackColor = Color.LightPink;
                            maskedTextBox1.BackColor = Color.LightPink;
                            comboBox1.BackColor = Color.LightPink;
                            имяTextBox.BackColor = Color.LightPink;
                            имяTextBox.Focus();
                            MessageBox.Show("Заполните данные о должности сотрудника.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        отчествоTextBox.BackColor = Color.LightPink;
                        maskedTextBox1.BackColor = Color.LightPink;
                        comboBox1.BackColor = Color.LightPink;
                        имяTextBox.BackColor = Color.LightPink;
                        фамилияTextBox.BackColor = Color.LightPink;
                        фамилияTextBox.Focus();
                        MessageBox.Show("Заполните данные о должности сотрудника.", "Данные не заполнены!!!");
                    }
                }
                else
                {
                    номерСотрудникаTextBox.BackColor = Color.LightPink;
                    номерСотрудникаTextBox.Focus();
                    MessageBox.Show("Заполните данные о номере сотрудника.", "Данные не заполнены!!!");
                }
            }
            catch
            {

            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "Удалить запись", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    int kod;
                    kod = Convert.ToInt32(Sotr.Text);
                    int kodP = Convert.ToInt32(pol.Text);

                    this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
                    this.пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
                }
                else 
                { 
                    this.Close();
                    MainForm mn = new MainForm(); 
                    mn.ShowDialog();
                }

                this.Validate();
                this.сотрудникиBindingSource.EndEdit();
                this.пользователиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Проверьте данные или обратитесь в службу поддержки", "Ошибка!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(118, 176, 212);
            button1.FlatStyle = FlatStyle.Standard;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(101, 169, 215);
            button1.FlatStyle = FlatStyle.Flat;
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

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Gray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Gray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightGray;
        }

        private void AddingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            { button1_Click(button1, null); }
            if (e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Закрыть форму?", "Выход.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { this.Close(); }
            }
        }

        private void должностьTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }
        
        private void номерСотрудникаTextBox_TextChanged(object sender, EventArgs e)
        {
            номерСотрудникаTextBox.Enabled = false;
        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void фиоTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            фамилияTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if ((char)e.KeyChar == (Char)Keys.Space) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
