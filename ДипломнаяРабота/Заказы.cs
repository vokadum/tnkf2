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
    public partial class Заказы : Form
    {
        public Заказы()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.СлужбаДоставки". При необходимости она может быть перемещена или удалена.
            this.службаДоставкиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СлужбаДоставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);

        }

        private void Poisc_Click(object sender, EventArgs e)
        {
            try
            {
                String NF = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        NF = "[Название товара]";
                        for (int i = 0; i < заказыDataGridView.RowCount - 1; i++)
                            if (заказыDataGridView[1, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                            }
                        break;
                    case 1:
                        NF = "[Адрес доставки]";
                        for (int i = 0; i < заказыDataGridView.RowCount - 1; i++)
                            if (заказыDataGridView[2, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                            }
                        break;
                    case 2:
                        NF = "[НомерЗаказа]";
                        for (int i = 0; i < заказыDataGridView.RowCount - 1; i++)
                            if (заказыDataGridView[0, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                            }
                        break;
                }
                int Index = 0;
                Index = заказыBindingSource.Find(NF, textBoxPoisc.Text);
                if (Index > -1)
                {
                    заказыBindingSource.Position = Index;
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные и попробуйте еще раз." +
                                        "Если не погмогло обратитесь в тех.поддержку.", "Ошибка!");
                }
            }
            catch
            {
                Console.WriteLine("Обратитесь к разработчику.", "Ошибка программы!");
            }
        }

        private void Ob_Click(object sender, EventArgs e)
        {
            textBoxPoisc.Clear();
            comboBox1.Text = "";
            for (int i = 0; i < заказыDataGridView.RowCount - 1; i++)
            {
                заказыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                заказыDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
            }
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        NameField = "[Название товара]";
                        break;
                    case 1:
                        NameField = "[Адрес доставки]";
                        break;
                }
                заказыBindingSource.Filter = NameField + " like '" + textBox2Filtr.Text + "%'";
            }
            catch { MessageBox.Show("Ошибка!!! Проверьте введенные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Obn_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
            textBox2Filtr.Clear();
            comboBox2.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
            data.mode = 1;
            Var.switcher = 1;
            Var.getPanel = 1;
            ЗаказыФормаРаботы заказы = new ЗаказыФормаРаботы();
            заказы.ShowDialog();
            заказы.Text = "Новый заказ";
            заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
            }
            catch { }
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.ЗаказыRow)((System.Data.DataRowView)заказыBindingSource.Current).Row).НомерЗаказа);

            ЗаказыФормаРаботы заказы = new ЗаказыФормаРаботы();
            заказы.ShowDialog();
            заказы.Text = "Изменение данных";
            заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in заказыDataGridView.SelectedRows)
                    { заказыDataGridView.Rows.RemoveAt(row.Index); }
                    this.Validate();
                    this.заказыBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void Poisc_MouseMove(object sender, MouseEventArgs e)
        {
            Poisc.BackColor = Color.FromArgb(101, 169, 215);
            Poisc.FlatStyle = FlatStyle.Flat;
        }

        private void Poisc_MouseLeave(object sender, EventArgs e)
        {
          Poisc.BackColor = Color.FromArgb(118, 176, 212);
            Poisc.FlatStyle = FlatStyle.Standard;
        }

        private void Ob_MouseMove(object sender, MouseEventArgs e)
        {
            Ob.BackColor = Color.FromArgb(101, 169, 215);
            Ob.FlatStyle = FlatStyle.Flat;
        }

        private void Ob_MouseLeave(object sender, EventArgs e)
        {
            Ob.BackColor = Color.FromArgb(118, 176, 212);
            Ob.FlatStyle = FlatStyle.Standard;
        }

        private void Filtr_MouseMove(object sender, MouseEventArgs e)
        {
            Filtr.BackColor = Color.FromArgb(101, 169, 215);
            Filtr.FlatStyle = FlatStyle.Flat;
        }

        private void Filtr_MouseLeave(object sender, EventArgs e)
        {
            Filtr.BackColor = Color.FromArgb(118, 176, 212);
            Filtr.FlatStyle = FlatStyle.Standard;
        }

        private void Obn_MouseMove(object sender, MouseEventArgs e)
        {
            Obn.BackColor = Color.FromArgb(101, 169, 215);
            Obn.FlatStyle = FlatStyle.Flat;
        }

        private void Obn_MouseLeave(object sender, EventArgs e)
        {
            Obn.BackColor = Color.FromArgb(118, 176, 212);
            Obn.FlatStyle = FlatStyle.Standard;
        }

        private void заказыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void заказыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            СтатусЗаказа form = new СтатусЗаказа();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.Text = "Учет продаж товаров";
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
