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
    public partial class Поставщики : Form
    {
        public Поставщики()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void Поставщики_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);

        }

        private void button1Poisc_Click(object sender, EventArgs e)
        {
            //Не открывать
            String NameField = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Наименование организации";
                    for (int i = 0; i < поставщикиDataGridView.RowCount - 1; i++)
                        if (поставщикиDataGridView[1, i].Value.ToString() == poisc.Text)
                        {
                            поставщикиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            поставщикиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                        }
                    break;
                case 1:
                    NameField = "e-mail";
                    for (int i = 0; i < поставщикиDataGridView.RowCount - 1; i++)
                        if (поставщикиDataGridView[7, i].Value.ToString() == poisc.Text)
                        {
                            поставщикиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                            поставщикиDataGridView.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            поставщикиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                            поставщикиDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
                        }
                    break;
            }
            int index = 0;
            index = поставщикиBindingSource.Find(NameField, poisc.Text);
            if (index > -1)
            {
                поставщикиBindingSource.Position = index;
            }
            else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            poisc.Clear();
            for (int i = 0; i < поставщикиDataGridView.RowCount - 1; i++)
            {
                поставщикиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                поставщикиDataGridView.Rows[i].Cells[7].Style.BackColor = Color.White;
            }
        }

        private void button2Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        NameField = "[Наименование организации]";
                        break;
                    case 1:
                        NameField = "[e-mail]";
                        break;
                }
                поставщикиBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные или обратитесь к разработчику", "Ошибка");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            поставщикиBindingSource.Filter = "";
            filtr.Clear();
            comboBox2.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Var.switcher = 1;
            Var.getPanel = 1;

            ПоставщикиФормаРаботы поставщики = new ПоставщикиФормаРаботы();
            поставщики.ShowDialog();
            поставщики.Text = "Новый поставщик";

            поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.ПоставщикиRow)((System.Data.DataRowView)поставщикиBindingSource.Current).Row).КодП);

            ПоставщикиФормаРаботы поставщики = new ПоставщикиФормаРаботы();
            поставщики.ShowDialog();
            поставщики.Text = "Изменить данные о поставщике";

            поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 
                    foreach (DataGridViewRow row in поставщикиDataGridView.SelectedRows)
                    {
                поставщикиDataGridView.Rows.RemoveAt(row.Index);
                    }
                        this.Validate();
                        this.поставщикиBindingSource.EndEdit();
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

        private void поставщикиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void поставщикиBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void поставщикиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
