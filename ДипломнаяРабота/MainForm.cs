using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДипломнаяРабота
{
    public partial class MainForm : Form
    {
        //Объявление активной формы
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }
        //Открытие форм в панели
        private void OpenChildForm(Form childForm, object btnSender)
        {if (activeForm != null){activeForm.Close();}
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //При запуске программы
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 1119;
            this.Height = 560;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer1_Tick;
            timer.Enabled = true;
            //label3.Visible = false;
            //groupBox1.Width = 201;
            //groupBox1.Height = 40;
            if (data.dolgnost == "Директор")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                //groupBox1.Visible = true;
            }
            if (data.dolgnost == "Администратор")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                //groupBox1.Visible = true;
            }
            if (data.dolgnost == "Управляющий")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button7.Visible = true;
                button6.Visible = false;
                button6.Enabled = false;
                //groupBox1.Visible = true;
                button1.Location = new Point(9, 202);
                button2.Location = new Point(9, 53);
                button7.Location = new Point(9, 124);
                button3.Location = new Point(9, 279);
                button4.Location = new Point(9, 356);
                button4.Location = new Point(9, 436);
            }
            if (data.dolgnost == "Менеджер")
            {
                button1.Visible = true;
                button7.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button2.Visible = false;
                //groupBox1.Visible = false;
            }
            if (data.dolgnost == "Специалист по продажам")
            {
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                button7.Visible = true;
                //groupBox1.Visible = false;
                button1.Location = new Point(9, 202);
                button2.Location = new Point(9, 53);
                button7.Location = new Point(9, 124);
                button3.Location = new Point(9, 279);
                button4.Location = new Point(9, 356);
                button4.Location = new Point(9, 436);
            }
            if (data.dolgnost == "Продавец")
            {
                button7.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                //groupBox1.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
                button4.Visible = false;
                button4.Enabled = false;
                button6.Visible = false;
                button6.Enabled = false;
                button7.Location = new Point(9, 120);
                button1.Location = new Point(9, 198);
                button3.Location = new Point(9, 272);
                button5.Location = new Point(9, 349);
            }
            if (data.dolgnost == "Консультант")
            {
                button7.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                //groupBox1.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
                button6.Visible = false;
                button6.Enabled = false;
            }
            else if (data.dolgnost == null)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button6.Enabled = false;
                button7.Visible = false;
                label1.Visible = false;
                //groupBox1.Visible = false;
            }
            timer1.Start();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Форма заказы
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Заказы(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Заказы";
        }
        //Форма Службы доставки
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new СлужбаДоставки(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Служба доставки";
        }
        //Форма сотрудники
        private void button2_Click(object sender, EventArgs e)
        {OpenChildForm(new Сотрудники(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Сотрудники";
        }
        //Форма товары
        private void button3_Click(object sender, EventArgs e)
        {OpenChildForm(new Товары(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Товары";
        }
        //Форма Поставщики
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Поставщики(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Поставщики";
        }
        //Форма Пользователи
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Пользователи(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Пользователи";
        }
        //Форма клиенты
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Клиенты(), sender);
            this.Size = new Size(1119, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Клиенты";
        }
        //Меняет цвет и стиль элемента
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(101, 169, 215);
            button2.FlatStyle = FlatStyle.Flat;
        }
        //Меняет цвет и стиль элемента
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(118, 176, 212);
            button2.FlatStyle = FlatStyle.Standard;
        }
        //Меняет цвет и стиль элемента
        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.FromArgb(101, 169, 215);
            button7.FlatStyle = FlatStyle.Flat;
        }
        //Меняет цвет и стиль элемента
        private void button7_MouseLeave(object sender, EventArgs e)
        { 
            button7.BackColor = Color.FromArgb(118, 176, 212);
            button7.FlatStyle = FlatStyle.Standard;
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
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(101, 169, 215);
            button3.FlatStyle = FlatStyle.Flat;
        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(101, 169, 215);
            button4.FlatStyle = FlatStyle.Flat;
        }
        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.FromArgb(101, 169, 215);
            button5.FlatStyle = FlatStyle.Flat;
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.FromArgb(101, 169, 215);
            button6.FlatStyle = FlatStyle.Flat;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(118, 176, 212);
            button3.FlatStyle = FlatStyle.Standard;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(118, 176, 212);
            button4.FlatStyle = FlatStyle.Standard;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(118, 176, 212);
            button5.FlatStyle = FlatStyle.Standard;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(118, 176, 212);
            button6.FlatStyle = FlatStyle.Standard;
        }
        //При нажатие кнопки на форме
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Escape)
            {
                if (MessageBox.Show("Выйти из программы?", "Выход.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { Application.Exit(); }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Показывет время
        private void timer1_Tick(object sender, EventArgs e)
        {
            var str = DateTime.Now.ToString();
            if (label1.InvokeRequired) label1.Invoke(new Action<string>((s) => label1.Text = s), str);
            else label1.Text = str;
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(button2, null);
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7_Click(button7, null);
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(button1, null);
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(button3, null);
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(button4, null);
        }
        //Происходит при нажатие элемента в тул стрип меню
        private void службаДоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5_Click(button5, null);
        }
        private void panel1_Enter(object sender, EventArgs e)
        {

        }
        //Происходит во время нажатия на надпись
        //private void label2_Click(object sender, EventArgs e)
        //{
        //    groupBox1.Width = 201;
        //    groupBox1.Height = 154;
        //    label2.Visible = false;
        //    label3.Visible = true;
        //}
        //Происходит во время нажатия на надпись
        //private void label3_Click(object sender, EventArgs e)
        //{
        //    groupBox1.Width = 201;
        //    groupBox1.Height = 40;
        //    label2.Visible = true;
        //    label3.Visible = false;
        //}
        ////Форма расчет заработной платы сотрудников
        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new РасчетЗарплаты(), sender);
            this.Size = new Size(1280, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Расчет заработной платы сотрудников";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Учет_продаж_товаров(), sender);
            this.Size = new Size(1280, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Учет продаж товаров";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ПриклодныеНаклодные(), sender);
            this.Size = new Size(1280, 560);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Text = "Документы о приходе товаров";
        }

        //private void button9_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button9.BackColor = Color.FromArgb(101, 169, 215);
        //    button9.FlatStyle = FlatStyle.Flat;
        //}

        //private void button9_MouseLeave(object sender, EventArgs e)
        //{
        //    button9.BackColor = Color.FromArgb(118, 176, 212);
        //    button9.FlatStyle = FlatStyle.Standard;
        //}

        //private void button10_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button10.BackColor = Color.FromArgb(101, 169, 215);
        //    button10.FlatStyle = FlatStyle.Flat;
        //}

        //private void button10_MouseLeave(object sender, EventArgs e)
        //{
        //    button10.BackColor = Color.FromArgb(118, 176, 212);
        //    button10.FlatStyle = FlatStyle.Standard;
        //}

        //private void button11_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button11.BackColor = Color.FromArgb(101, 169, 215);
        //    button11.FlatStyle = FlatStyle.Flat;
        //}

        //private void button11_MouseLeave(object sender, EventArgs e)
        //{
        //    button11.BackColor = Color.FromArgb(118, 176, 212);
        //    button11.FlatStyle = FlatStyle.Standard;
        //}

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(101, 169, 215);
            button8.FlatStyle = FlatStyle.Flat;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(118, 176, 212);
            button8.FlatStyle = FlatStyle.Standard;
        }
        //Форма Пользователи
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

    }
}
