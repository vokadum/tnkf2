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
    public partial class ПриклодныеНаклодные : Form
    {
        public void Es()
        {
            for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
            {
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
            }
        }
        public void Noy()
        {
            for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
            {
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                приклоднаяНаклоднаяDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
            }
        }
        public ПриклодныеНаклодные()
        {
            InitializeComponent();
        }

        private void приклоднаяНаклоднаяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.приклоднаяНаклоднаяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void ПриклодныеНаклодные_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная". При необходимости она может быть перемещена или удалена.
            this.приклоднаяНаклоднаяTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная);
            groupBox3.Width = 200;
            groupBox3.Height = 39;
            label7.Visible = true;
            label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Var.switcher = 1;
            Var.getPanel = 1;

            НаклодныеФорма форма = new НаклодныеФорма();
            форма.ShowDialog();
            приклоднаяНаклоднаяTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.ПриклоднаяНаклоднаяRow)((System.Data.DataRowView)приклоднаяНаклоднаяBindingSource.Current).Row).Код);
            НаклодныеФорма форма = new НаклодныеФорма();
            форма.ShowDialog();
            приклоднаяНаклоднаяTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.ПриклоднаяНаклодная);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in приклоднаяНаклоднаяDataGridView.SelectedRows)
                    { приклоднаяНаклоднаяDataGridView.Rows.RemoveAt(row.Index); }
                    this.Validate();
                    this.приклоднаяНаклоднаяDataGridView.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1Poisc_Click(object sender, EventArgs e)
        {
            String NameField = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Код";
                    for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
                        if (приклоднаяНаклоднаяDataGridView[0, i].Value.ToString() == poisc.Text)
                        {
                            Es();
                        }
                        else
                        {
                            Noy();

                        }
                    break;
                case 1:
                    NameField = "Товар";
                    for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
                        if (приклоднаяНаклоднаяDataGridView[1, i].Value.ToString() == poisc.Text)
                        {
                            Es();
                        }
                        else
                        {
                            Noy();
                        }
                    break;
                case 2:
                    NameField = "Цена";
                    for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
                        if (приклоднаяНаклоднаяDataGridView[3, i].Value.ToString() == poisc.Text)
                        {
                            Es();
                        }
                        else
                        {
                            Noy();
                        }
                    break;
            }
            int index = 0;
            index = приклоднаяНаклоднаяBindingSource.Find(NameField, poisc.Text);
            if (index > -1)
            {
                приклоднаяНаклоднаяBindingSource.Position = index;
            }
            else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            poisc.Clear();
            for (int i = 0; i < приклоднаяНаклоднаяDataGridView.RowCount - 1; i++)
            {
                Noy();
            }
        }

        private void button2Filtr_Click(object sender, EventArgs e)
        {
            String NameField = "";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    NameField = "Товар";
                    break;
                case 1:
                    NameField = "ДатаПоступление";
                    break;
            }
            приклоднаяНаклоднаяBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            filtr.Clear();
            приклоднаяНаклоднаяBindingSource.Filter = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int kol = 0;
                string tovar;
                var firstColumnValues =
               from DataGridViewRow row in приклоднаяНаклоднаяDataGridView.Rows
               group row by row.Cells[1].Value
               into res
               select new { res.Key, Count = res.Count() };
                StringBuilder result = new StringBuilder();
                foreach (var value in firstColumnValues)
                {
                    if (товарыBindingSource.Find("Название товара", value.Key) != -1) // Проверяем логин на наличие в базе данных
                    {
                        int index = 0;
                        int index2 = 0;
                        index = товарыBindingSource.Find("Название товара", value.Key);
                        index2 = приклоднаяНаклоднаяBindingSource.Find("Товар", value.Key);
                        if (index > -1)
                        {
                            товарыBindingSource.Position = index;
                            приклоднаяНаклоднаяBindingSource.Position = index2;
                            if (Convert.ToString(value.Key) != "")
                            {
                                int kod,cena, kolvo, pos, raz;
                                string name, ed;
                                name = товарыDataGridView.CurrentRow.Cells[1].Value.ToString();
                                cena = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[2].Value.ToString());
                                kolvo = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[3].Value.ToString()) + Convert.ToInt32(приклоднаяНаклоднаяDataGridView.CurrentRow.Cells[2].Value.ToString());
                                pos = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[4].Value.ToString());
                                raz = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[5].Value.ToString());
                                ed = товарыDataGridView.CurrentRow.Cells[6].Value.ToString();
                                kod = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[0].Value.ToString());
                                this.товарыTableAdapter.UpdateQuery(name,cena,kolvo,pos,raz,ed,kod);
                                this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
                            }

                        }
                    }

                }
                MessageBox.Show(result.ToString());
            }
            catch
            {

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            groupBox3.Width = 200;
            groupBox3.Height = 93;
            label7.Visible = false;
            label8.Visible = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            groupBox3.Width = 200;
            groupBox3.Height = 39;
            label7.Visible = true;
            label8.Visible = false;
        }

        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.Text = "Учет продаж товаров";
        }
    }
    
}

