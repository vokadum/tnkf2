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
    public partial class Пользователи : Form
    {
        public Пользователи()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void Пользователи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);

        }

        private void button1Poisc_Click(object sender, EventArgs e)
        {
            //Не открывать
            String NameField = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Логин";
                    for (int i = 0; i < пользователиDataGridView.RowCount - 1; i++)
                        if (пользователиDataGridView[1, i].Value.ToString() == poisc.Text)
                        {
                            пользователиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            пользователиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            пользователиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            пользователиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            пользователиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            пользователиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                        }
                    break;
            }
            int index = 0;
            index = пользователиBindingSource.Find(NameField, poisc.Text);
            if (index > -1)
            {
                пользователиBindingSource.Position = index;
            }
            else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            poisc.Clear();
            for (int i = 0; i < пользователиDataGridView.RowCount - 1; i++)
            {
                пользователиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                пользователиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                пользователиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
            }
        }

        private void button2Filtr_Click(object sender, EventArgs e)
        {
            String NameField = "";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    NameField = "Должность";
                    break;
            }
            пользователиBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            filtr.Clear();
            пользователиBindingSource.Filter = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Var.switcher = 1;
            Var.getPanel = 1;

            ПользователиФормаРаботы пользователи = new ПользователиФормаРаботы();
            пользователи.ShowDialog();
            пользователи.Text = "Новый пользователь";

            пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.ПользователиRow)((System.Data.DataRowView)пользователиBindingSource.Current).Row).Код);

            ПользователиФормаРаботы пользователи = new ПользователиФормаРаботы();
            пользователи.ShowDialog();
            пользователи.Text = "Изменить данные";

            пользователиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Пользователи);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "Удалить запись.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                 foreach (DataGridViewRow row in пользователиDataGridView.SelectedRows)
                    {пользователиDataGridView.Rows.RemoveAt(row.Index);}       
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void button1Poisc_MouseMove(object sender, MouseEventArgs e)
        {
            button1Poisc.BackColor = Color.FromArgb(101, 169, 215);
            button1Poisc.FlatStyle = FlatStyle.Flat;
        }

        private void button1Poisc_MouseLeave(object sender, EventArgs e)
        {
            button1Poisc.BackColor = Color.FromArgb(118, 176, 212);
            button1Poisc.FlatStyle = FlatStyle.Standard;
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

        private void button2Filtr_MouseMove(object sender, MouseEventArgs e)
        {
            button2Filtr.BackColor = Color.FromArgb(101, 169, 215);
            button2Filtr.FlatStyle = FlatStyle.Flat;
        }

        private void button2Filtr_MouseLeave(object sender, EventArgs e)
        {
            button2Filtr.BackColor = Color.FromArgb(118, 176, 212);
            button2Filtr.FlatStyle = FlatStyle.Standard;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(101, 169, 215);
            button3.FlatStyle = FlatStyle.Flat;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(118, 176, 212);
            button3.FlatStyle = FlatStyle.Standard;
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            Add.BackColor = Color.FromArgb(101, 169, 215);
            Add.FlatStyle = FlatStyle.Flat;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(118, 176, 212);
            Add.FlatStyle = FlatStyle.Standard;
        }

        private void Update_MouseMove(object sender, MouseEventArgs e)
        {
            Update.BackColor = Color.FromArgb(101, 169, 215);
            Update.FlatStyle = FlatStyle.Flat;
        }

        private void Update_MouseLeave(object sender, EventArgs e)
        {
            Update.BackColor = Color.FromArgb(118, 176, 212);
            Update.FlatStyle = FlatStyle.Standard;
        }

        private void Delete_MouseMove(object sender, MouseEventArgs e)
        {
            Delete.BackColor = Color.FromArgb(101, 169, 215);
            Delete.FlatStyle = FlatStyle.Flat;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(118, 176, 212);
            Delete.FlatStyle = FlatStyle.Standard;
        }


        private void пользователиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void пользователиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Click(Add, null);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Click(Update, null);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Click(Delete, null);
        }


        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            main.Text = "Учет продаж товаров";
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
