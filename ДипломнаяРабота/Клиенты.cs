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
    public partial class Клиенты : Form
    {
        
        //При запуске формы клиенты
        public Клиенты()
        {
            InitializeComponent();
        }
        //Метод отвечающий за покраску таблицы при поиске данных
        public void Es()
        {
            for (int i = 0; i < клиентыDataGridView.RowCount - 1; i++)
            {
                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
            }
        }
        //Метод отвечающий за очистки таблицы после поиска данных
        public void Noy()
        {
            for (int i = 0; i < клиентыDataGridView.RowCount - 1; i++)
            {
                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.PaleTurquoise;
                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.PaleTurquoise;
            } 
        }
        //При загрузки формы
        private void Клиенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
        }
        //Поиск данных
        private void button1Poisc_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        NameField = "Фамилия";
                        for (int i = 0; i < клиентыDataGridView.RowCount - 1; i++)
                            if (клиентыDataGridView[1, i].Value.ToString() == poisc.Text)
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.PaleTurquoise;
                            }
                        break;
                    case 1:
                        NameField = "Имя";
                        for (int i = 0; i < клиентыDataGridView.RowCount - 1; i++)
                            if (клиентыDataGridView[2, i].Value.ToString() == poisc.Text)
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.PaleTurquoise;
                            }
                        break;
                    case 2:
                        NameField = "Отчество";
                        for (int i = 0; i < клиентыDataGridView.RowCount - 1; i++)
                            if (клиентыDataGridView[3, i].Value.ToString() == poisc.Text)
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                клиентыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.PaleTurquoise;
                                клиентыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.PaleTurquoise;
                            }
                        break;
                }
                int index = 0;
                index = клиентыBindingSource.Find(NameField, poisc.Text);
                if (index > -1)
                {
                    клиентыBindingSource.Position = index;
                }
                else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
            }
            catch
            {
                MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Очистка полей и таблицы после поиска данных
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            poisc.Clear();
            Noy();
        }
        //Фильтрация данных
        private void button2Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        NameField = "Фамилия";
                        break;
                    case 1:
                        NameField = "Имя";
                        break;
                    case 2:
                        NameField = "Отчество";
                        break;
                }
                клиентыBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Очистка полей и таблицы после фильтрации данных
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            filtr.Clear();
            клиентыBindingSource.Filter = "";
        }
        //Кнопка отвещающая за добавление записей в таблице
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                data.mode = 1;
                Var.switcher = 1;
                Var.getPanel = 1;
                КлиентыФормаРаботы клиенты = new КлиентыФормаРаботы();
                клиенты.Text = "Добавление записи о новом клиенте";
                клиенты.ShowDialog();
                клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
            }
            catch
            {
                MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Кнопка отвещающая за изменение записей в таблице
        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;
            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.КлиентыRow)((System.Data.DataRowView)клиентыBindingSource.Current).Row).Код);
            КлиентыФормаРаботы клиенты = new КлиентыФормаРаботы();
            клиенты.Text = "Изменение данных";
            клиенты.ShowDialog();
            клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
        }
        //Кнопка отвещающая за удаление записей в таблице
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in клиентыDataGridView.SelectedRows)
                    { 
                        клиентыDataGridView.Rows.RemoveAt(row.Index);
                    }
                    this.Validate();
                    this.клиентыBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //Изменение цвета кнопки и внешнего вида
        private void button1Poisc_MouseMove(object sender, MouseEventArgs e)
        {
            button1Poisc.BackColor = Color.FromArgb(101, 169, 215);
            button1Poisc.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button1Poisc_MouseLeave(object sender, EventArgs e)
        {
            button1Poisc.BackColor = Color.FromArgb(118, 176, 212);
            button1Poisc.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(101, 169, 215);
            button1.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(118, 176, 212);
            button1.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button2Filtr_MouseMove(object sender, MouseEventArgs e)
        {
            button2Filtr.BackColor = Color.FromArgb(101, 169, 215);
            button2Filtr.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button2Filtr_MouseLeave(object sender, EventArgs e)
        {
            button2Filtr.BackColor = Color.FromArgb(118, 176, 212);
            button2Filtr.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(101, 169, 215);
            button3.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(118, 176, 212);
            button3.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            Add.BackColor = Color.FromArgb(101, 169, 215);
            Add.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Add_MouseLeave(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(118, 176, 212);
            Add.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Update_MouseMove(object sender, MouseEventArgs e)
        {
            Update.BackColor = Color.FromArgb(101, 169, 215);
            Update.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Update_MouseLeave(object sender, EventArgs e)
        {
            Update.BackColor = Color.FromArgb(118, 176, 212);
            Update.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Delete_MouseMove(object sender, MouseEventArgs e)
        {
            Delete.BackColor = Color.FromArgb(101, 169, 215);
            Delete.FlatStyle = FlatStyle.Flat;
        }
        //Изменение цвета кнопки и внешнего вида
        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(118, 176, 212);
            Delete.FlatStyle = FlatStyle.Standard;
        }
        //Изменение цвета кнопки и внешнего вида
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Click(Add, null);
        }
        //Изменение цвета кнопки и внешнего вида
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Click(Update, null);
        }
        //Изменение цвета кнопки и внешнего вида
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Click(Delete, null);
        }
        //Изменение цвета кнопки и внешнего вида
       
        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.Text = "Учет продаж товаров";
        }
        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
