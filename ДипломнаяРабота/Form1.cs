using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ДипломнаяРабота
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_АлиекспресDataSet.Профиль". При необходимости она может быть перемещена или удалена.
            password.UseSystemPasswordChar = true;
            this.Width = 370;
            this.Height = 417;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        { 
        }
        //Отчевает за проверку данных и вход в систему
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "";
                if ( пользователиBindingSource.Find("Логин",textBox1.Text) != -1) // Проверяем логин на наличие в базе данных
                {
                    пользователиBindingSource.Position = пользователиBindingSource.Find("Логин", textBox1.Text);
                    if (пользователиDataGridView.CurrentRow.Cells[1].Value.ToString() == comboBox2.Text) // проверяем введенную должность сотрудника
                    {
                        if(пользователиDataGridView.CurrentRow.Cells[2].Value.ToString() == password.Text) // Проверяем на соответствие с паролем
                        {
                            textBox1.BackColor = Color.White;
                            comboBox2.BackColor = Color.White;
                            password.BackColor = Color.White;
                            Vxod.Enabled = false;
                            password.Enabled = false;
                            data.name = textBox1.Text;
                            data.dolgnost = comboBox2.Text;
                            Thread.Sleep(3000);
                            this.Hide();
                            MessageBox.Show("Вход в систему, выполнен","Вход",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            MainForm mainform = new MainForm();
                            mainform.Show(new MainForm()); 

                        }
                        else
                        {
                            Vxod.Location = new Point(23, 199);
                            Otmena.Location = new Point(229, 199);
                            label3.Visible = true;
                            label3.Text = "Введен не правильные пароль.\n Введите данные еще раз.";
                            password.BackColor = Color.LightPink;

                        }
                    }
                    else
                    {
                        groupBox1.Size = new Size(356, 253);
                        Thread.Sleep(100);
                        Vxod.Location = new Point(23, 199);
                        Otmena.Location = new Point(229, 199);
                        label3.Visible = true;
                        label3.Text = "Введена не правильная должность сотрудника.\n Введите данные еще раз.";
                        comboBox2.Focus();
                        comboBox2.BackColor = Color.LightPink;
                    }
                }
                else
                {
                    groupBox1.Location = new Point(0, 196);
                    groupBox1.Size = new Size(356, 253);
                    Thread.Sleep(100);
                    Vxod.Location = new Point(23, 199);
                    Otmena.Location = new Point(229, 199);
                    label3.Visible = true;
                    label3.Text = "Неправильно введённый логин \n Введите данные еще раз.";
                    textBox1.BackColor = Color.LightPink;
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте правильность введеных данных или обратитесь к разработчику!", "Системное оповещение");
            }
        }

        //Отвечает за покраску фона кнопки при наведение на нее курсором мишки
        private void Vxod_MouseMove(object sender, MouseEventArgs e)
        {
            Vxod.BackColor = Color.FromArgb(101, 169, 215);
            Vxod.FlatStyle = FlatStyle.Flat;
        }
        //Отвчеает за покрас кнопки, когда курсор мыши вышел из диапозона действия кнопки
        private void Vxod_MouseLeave(object sender, EventArgs e)
        {
            Vxod.BackColor = Color.FromArgb(118, 176, 212);
            Vxod.FlatStyle = FlatStyle.Standard;
        }
        //Отвечает за выход из программы, при нажатие на кнопку отмена
        private void Otmena_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Отвчеает за покрас кнопки, когда курсор мыши вышел из диапозона действия кнопки
        private void Otmena_MouseLeave(object sender, EventArgs e)
        {
            Otmena.BackColor = Color.FromArgb(118, 176, 212);
            Otmena.FlatStyle = FlatStyle.Standard;
        }
        //Отвечает за покраску фона кнопки при наведение на нее курсором мишки
        private void Otmena_MouseMove(object sender, MouseEventArgs e)
        {
            Otmena.BackColor = Color.FromArgb(101, 169, 215);
            Otmena.FlatStyle = FlatStyle.Flat;
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        //Отвечает за скрытие пароля
        private void label4_MouseLeave(object sender, EventArgs e)
        {  
            password.UseSystemPasswordChar = true;
        }
        //Отвечает за показ пароля
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
            password.PasswordChar = (char)0;
        }
        //Отвечает за проверку вводимих данных
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            { button1_Click(Vxod, null); }
            if (e.KeyValue == (char)Keys.Escape)
            { if (MessageBox.Show("Выйти из программы?","Выход.",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                { Application.Exit(); }
            } 
        }
        //Отвечает за расположение текста
        private void label3_Click(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }
        //Отвечает за прокрас фона текст бокса
        private void парольTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            password.BackColor = Color.White;
        }
        //Отвечает за прокрас фона текст бокса
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }
        //Отвечает за прокрас фона комбо бокса
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }
        //Отвечает за прокрас фона текст бокса
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}



