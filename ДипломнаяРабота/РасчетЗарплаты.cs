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
    public partial class РасчетЗарплаты : Form
    {
        public РасчетЗарплаты()
        {
            InitializeComponent();
        }

        private void расчет_зарплатыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.расчет_зарплатыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void РасчетЗарплаты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Расчет_зарплаты". При необходимости она может быть перемещена или удалена.
            this.расчет_зарплатыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Расчет_зарплаты);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                data.mode = 1; Var.switcher = 1; Var.getPanel = 1;
                РасчетЗарплатыФорма расчетЗП = new РасчетЗарплатыФорма();
                расчетЗП.ShowDialog();
                расчетЗП.Text = "Расчет зарплаты";
                расчет_зарплатыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Расчет_зарплаты);
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчику", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                data.mode = 2; Var.switcher = 1; Var.getPanel = 1;
                data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.Расчет_зарплатыRow)((System.Data.DataRowView)расчет_зарплатыBindingSource.Current).Row).Код);
                РасчетЗарплатыФорма расчетЗП = new РасчетЗарплатыФорма();
                расчетЗП.ShowDialog();
                расчетЗП.Text = "Изменение данных о расчетах зарплаты";
                расчет_зарплатыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Расчет_зарплаты);
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчику", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in расчет_зарплатыDataGridView.SelectedRows) {расчет_зарплатыDataGridView.Rows.RemoveAt(row.Index); }
                    this.Validate();
                    this.расчет_зарплатыBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void button1Poisc_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        NameField = "Код";
                        for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                            if (расчет_зарплатыDataGridView[0, i].Value.ToString() == poisc.Text)
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.White;
                            }
                        break;
                    case 1:
                        NameField = "Фамилия";
                        for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                            if (расчет_зарплатыDataGridView[1, i].Value.ToString() == poisc.Text)
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.White;
                            }
                        break;
                    case 2:
                        NameField = "Имя";
                        for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                            if (расчет_зарплатыDataGridView[2, i].Value.ToString() == poisc.Text)
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.White;
                            }
                        break;
                    case 3:
                        NameField = "Отчество";
                        for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                            if (расчет_зарплатыDataGridView[3, i].Value.ToString() == poisc.Text)
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.White;
                            }
                        break;
                    case 4:
                        NameField = "Должность";
                        for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                            if (расчет_зарплатыDataGridView[4, i].Value.ToString() == poisc.Text)
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[10].Style.BackColor = Color.White;
                                расчет_зарплатыDataGridView.Rows[i].Cells[11].Style.BackColor = Color.White;
                            }

                        break;
                }
                int index = 0;
                index = расчет_зарплатыBindingSource.Find(NameField, poisc.Text);
                if (index > -1)
                { расчет_зарплатыBindingSource.Position = index; }
                else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                poisc.Clear();
                for (int i = 0; i < расчет_зарплатыDataGridView.RowCount - 1; i++)
                {
                    расчет_зарплатыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[8].Style.BackColor = Color.White;
                    расчет_зарплатыDataGridView.Rows[i].Cells[9].Style.BackColor = Color.White;
                }     
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        NameField = "Сотрудник";
                        break;
                    case 1:
                        NameField = "Должность";
                        break;
                }
                расчет_зарплатыBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Text = "";
                filtr.Clear();
                расчет_зарплатыBindingSource.Filter = "";
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
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
            main.Text = "Учет продаж товаров";
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
