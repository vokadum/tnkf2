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
    public partial class РасчетЗарплатыФорма : Form
    {
        public РасчетЗарплатыФорма()
        {
            InitializeComponent();
        }
        private void РасчетЗарплатыФорма_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Расчет_зарплаты". При необходимости она может быть перемещена или удалена.
            this.расчет_зарплатыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Расчет_зарплаты);
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {

                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(0, 0);


                        if (data.mode == 1)
                        {
                            расчет_зарплатыBindingSource.AddNew();
                            button1.Text = "Рассчитать";
                            премияCheckBox.Checked = false;
                        }
                        if (data.mode == 2)
                        {
                            int pos = расчет_зарплатыBindingSource.Find("Код", data.kod);
                            расчет_зарплатыBindingSource.Position = pos;
                            button1.Text = "Изменить данные";
                            textBox1.Text = кодTextBox.Text;
                            
                            comboBox2.Text = должностьTextBox.Text;
                        }
                        if (data.mode == 3)
                        {
                            int pos = расчет_зарплатыBindingSource.Find("Код", data.kod);
                            расчет_зарплатыBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "")
                {
                    if (фамилияTextBox.Text != "")
                    {
                        if (имяTextBox.Text != "")
                        {
                            if (отчествоTextBox.Text != "")
                            {
                                if (comboBox2.Text != "")
                                {
                                    if (рабочих_днейTextBox.Text != "")
                                    {
                                        if (окладTextBox.Text != "")
                                        {
                                            int b = Convert.ToInt32(окладTextBox.Text) / 100 * 13;
                                            налоговые_вычитыTextBox.Text = b.ToString();
                                            int d = Convert.ToInt32(окладTextBox.Text) / 100 * 1;
                                            пенсионные_вычетыTextBox.Text = d.ToString();
                                            if (премияCheckBox.Checked == true)
                                            {
                                                int pr = Convert.ToInt32(окладTextBox.Text) / 100 * 30;
                                                int oklad = Convert.ToInt32(окладTextBox.Text);
                                                int kviplate = oklad + pr - b - d;
                                                кВыплатеTextBox.Text = kviplate.ToString();
                                                if (data.mode == 1)
                                                {
                                                    должностьTextBox.Text = comboBox2.Text;
                                                    textBox1.BackColor = Color.LightGreen;
                                                    фамилияTextBox.BackColor = Color.LightGreen;
                                                    имяTextBox.BackColor = Color.LightGreen;
                                                    отчествоTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    рабочих_днейTextBox.BackColor = Color.LightGreen;
                                                    окладTextBox.BackColor = Color.LightGreen;
                                                    налоговые_вычитыTextBox.BackColor = Color.LightGreen;
                                                    пенсионные_вычетыTextBox.BackColor = Color.LightGreen;
                                                    премияCheckBox.BackColor = Color.LightGreen;
                                                    кВыплатеTextBox.BackColor = Color.LightGreen;
                                                    кодTextBox.Text = textBox1.Text;
                                                    MessageBox.Show("Расчет зарплаты сотрудника: " + фамилияTextBox.Text + " " + имяTextBox.Text + " " + отчествоTextBox.Text + " выполнен", "Расчет зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.расчет_зарплатыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();

                                                }
                                                if (data.mode == 2)
                                                {
                                                    должностьTextBox.Text = comboBox2.Text;
                                                    textBox1.BackColor = Color.LightGreen;
                                                    фамилияTextBox.BackColor = Color.LightGreen;
                                                    имяTextBox.BackColor = Color.LightGreen;
                                                    отчествоTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    рабочих_днейTextBox.BackColor = Color.LightGreen;
                                                    окладTextBox.BackColor = Color.LightGreen;
                                                    налоговые_вычитыTextBox.BackColor = Color.LightGreen;
                                                    пенсионные_вычетыTextBox.BackColor = Color.LightGreen;
                                                    премияCheckBox.BackColor = Color.LightGreen;
                                                    кВыплатеTextBox.BackColor = Color.LightGreen;
                                                    кодTextBox.Text = textBox1.Text;
                                                    MessageBox.Show("Данные успешно изменены о заработной плате" +
                                                        "\n сотрудника: " + фамилияTextBox.Text + " " + имяTextBox.Text + " " + отчествоTextBox.Text, "Расчет зарплаты.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.расчет_зарплатыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();
                                                }
                                            }
                                            else if (премияCheckBox.Checked == false)
                                            {
                                                int a = Convert.ToInt32(окладTextBox.Text);
                                                int kvaplate = a - b - d;
                                                кВыплатеTextBox.Text = kvaplate.ToString();
                                                if (data.mode == 1)
                                                {
                                                    должностьTextBox.Text = comboBox2.Text;
                                                    textBox1.BackColor = Color.LightGreen;
                                                    фамилияTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    рабочих_днейTextBox.BackColor = Color.LightGreen;
                                                    окладTextBox.BackColor = Color.LightGreen;
                                                    налоговые_вычитыTextBox.BackColor = Color.LightGreen;
                                                    пенсионные_вычетыTextBox.BackColor = Color.LightGreen;
                                                    премияCheckBox.BackColor = Color.LightGreen;
                                                    кВыплатеTextBox.BackColor = Color.LightGreen;
                                                    textBox1.Text = кодTextBox.Text;
                                                    MessageBox.Show("Расчет зарплаты сотрудника: " + фамилияTextBox.Text + " " + имяTextBox.Text + " " + отчествоTextBox.Text + " выполнен.", "Расчет зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.расчет_зарплатыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();

                                                }
                                                if (data.mode == 2)
                                                {
                                                    должностьTextBox.Text = comboBox2.Text;
                                                    textBox1.BackColor = Color.LightGreen;
                                                    фамилияTextBox.BackColor = Color.LightGreen;
                                                    comboBox2.BackColor = Color.LightGreen;
                                                    рабочих_днейTextBox.BackColor = Color.LightGreen;
                                                    окладTextBox.BackColor = Color.LightGreen;
                                                    налоговые_вычитыTextBox.BackColor = Color.LightGreen;
                                                    пенсионные_вычетыTextBox.BackColor = Color.LightGreen;
                                                    премияCheckBox.BackColor = Color.LightGreen;
                                                    кВыплатеTextBox.BackColor = Color.LightGreen;
                                                    textBox1.Text = кодTextBox.Text;
                                                    MessageBox.Show("Данные успешно изменены о заработной плате" +
                                                        "\n сотрудника: " + фамилияTextBox.Text + " " + имяTextBox.Text + " " + отчествоTextBox.Text, "Расчет зарплаты.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.расчет_зарплатыBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                                                    this.Close();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            окладTextBox.BackColor = Color.LightPink;
                                            окладTextBox.Focus();
                                            MessageBox.Show("Укажите оклад сотрудника.", "Данные не заполнены!!!");
                                        }
                                    }
                                    else
                                    {
                                        рабочих_днейTextBox.BackColor = Color.LightPink;
                                        рабочих_днейTextBox.Focus();
                                        MessageBox.Show("Заполните данные о количестве рабочих дней сотрудника.", "Данные не заполнены!!!");
                                    }
                                }
                                else
                                {
                                    comboBox2.BackColor = Color.LightPink;
                                    comboBox2.Focus();
                                    MessageBox.Show("Заполните данные о должности сотрудника.", "Данные не заполнены!!!");
                                }
                            }
                            else
                            {
                                отчествоTextBox.BackColor = Color.LightPink;
                                отчествоTextBox.Focus();
                                MessageBox.Show("Укажите отчество сотрудника.", "Данные не заполнены!!!");
                            }
                        }
                        else
                        {
                            имяTextBox.BackColor = Color.LightPink;
                            имяTextBox.Focus();
                            MessageBox.Show("Укажите имя сотрудника.", "Данные не заполнены!!!");
                        }
                    }
                    else
                    {
                        фамилияTextBox.BackColor = Color.LightPink;
                        фамилияTextBox.Focus();
                        MessageBox.Show("Заполните данные о сотруднике.", "Данные не заполнены!!!");
                    }
                }
                else
                {
                    textBox1.BackColor = Color.LightPink;
                    textBox1.Focus();
                    MessageBox.Show("Заполните данные о номере документа, расчета зарплаты.", "Данные не заполнены!!!");
                }
            }
            catch
            {
                MessageBox.Show("Системаная ошибка, обратитесь к разработчику", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void окладTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            окладTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void рабочих_днейTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            рабочих_днейTextBox.BackColor = Color.White;
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void налоговые_вычитыTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsLetter(e.KeyChar)) e.Handled = true;
            MessageBox.Show("Данное поле расчитывается автоматически, для этого укажите все данные о документе и нажмите кнопку 'Подтвердить'");
            if (textBox1.Text == "")
            { textBox1.Focus(); }
            if (фамилияTextBox.Text == "")
            { фамилияTextBox.Focus(); }
            if (имяTextBox.Text == "")
            { имяTextBox.Focus(); }
            if (отчествоTextBox.Text == "")
            { отчествоTextBox.Focus(); }
            if (comboBox2.Text == "")
            { comboBox2.Focus(); }
            if (рабочих_днейTextBox.Text == "")
            { рабочих_днейTextBox.Focus(); }
            if (окладTextBox.Text == "")
            { окладTextBox.Focus(); }
            else if (textBox1.Text != "" && фамилияTextBox.Text != "" && имяTextBox.Text != "" && отчествоTextBox.Text != "" && comboBox2.Text != "" && рабочих_днейTextBox.Text != "" && окладTextBox.Text != "")
            {
                button1.Focus();
                button1.BackColor = Color.Gray;
            }
        }

        private void пенсионные_вычетыTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsLetter(e.KeyChar)) e.Handled = true;
            MessageBox.Show("Данное поле расчитывается автоматически, для этого укажите все данные о документе и нажмите кнопку 'Подтвердить'");
            if (textBox1.Text == "")
            { textBox1.Focus(); }
            if (фамилияTextBox.Text == "")
            { фамилияTextBox.Focus(); }
            if (имяTextBox.Text == "")
            { имяTextBox.Focus(); }
            if (отчествоTextBox.Text == "")
            { отчествоTextBox.Focus(); }
            if (comboBox2.Text == "")
            { comboBox2.Focus(); }
            if (рабочих_днейTextBox.Text == "")
            { рабочих_днейTextBox.Focus(); }
            if (окладTextBox.Text == "")
            { окладTextBox.Focus(); }
            else if (textBox1.Text != "" && фамилияTextBox.Text != "" && имяTextBox.Text != "" && отчествоTextBox.Text != "" && comboBox2.Text != "" && рабочих_днейTextBox.Text != "" && окладTextBox.Text != "")
            {
                button1.Focus();
                button1.BackColor = Color.Gray;
            }
        }

        private void кВыплатеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsLetter(e.KeyChar)) e.Handled = true;
            MessageBox.Show("Данное поле расчитывается автоматически, для этого укажите все данные о документе и нажмите кнопку 'Подтвердить'");
            if (textBox1.Text == "")
            { textBox1.Focus(); }
            if (фамилияTextBox.Text == "")
            { фамилияTextBox.Focus(); }
            if (имяTextBox.Text == "")
            { имяTextBox.Focus(); }
            if (отчествоTextBox.Text == "")
            { отчествоTextBox.Focus(); }
            if (comboBox2.Text == "")
            { comboBox2.Focus(); }
            if (рабочих_днейTextBox.Text == "")
            { рабочих_днейTextBox.Focus(); }
            if (окладTextBox.Text == "")
            { окладTextBox.Focus(); }
            else if (textBox1.Text != "" && фамилияTextBox.Text != "" && имяTextBox.Text != "" && отчествоTextBox.Text != "" && comboBox2.Text != "" && рабочих_днейTextBox.Text != "" && окладTextBox.Text != "")
            {
                button1.Focus();
                button1.BackColor = Color.Gray;
            }
        }
    }
}
