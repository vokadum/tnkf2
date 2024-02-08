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
    public partial class Учет_продаж_товаров : Form
    {
        DateTime date = DateTime.Now;
        private void Es()
        {
            for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
            {
                учетПродажТоваровDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                учетПродажТоваровDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                учетПродажТоваровDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                учетПродажТоваровDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                учетПродажТоваровDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                учетПродажТоваровDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
            }

        }
        private void Noy()
        {
            for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
            {
                учетПродажТоваровDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                учетПродажТоваровDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                учетПродажТоваровDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                учетПродажТоваровDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                учетПродажТоваровDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                учетПродажТоваровDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
            }
        }
        public Учет_продаж_товаров()
        {
            InitializeComponent();
        }

        private void button1Poisc_Click(object sender, EventArgs e)
        {
            //Не открывать
            String NameField = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "НомерДокумента";
                    for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
                        if (учетПродажТоваровDataGridView[0, i].Value.ToString() == poisc.Text)
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
                    for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
                        if (учетПродажТоваровDataGridView[1, i].Value.ToString() == poisc.Text)
                        {
                            Es();
                        }
                        else
                        {
                            Noy();
                        }
                    break;
                case 2:
                    NameField = "ДатаУчета";
                    for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
                        if (учетПродажТоваровDataGridView[2, i].Value.ToString() == poisc.Text)
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
            index = учетПродажТоваровBindingSource.Find(NameField, poisc.Text);
            if (index > -1)
            {
                учетПродажТоваровBindingSource.Position = index;
            }
            else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            poisc.Clear();
            for (int i = 0; i < учетПродажТоваровDataGridView.RowCount - 1; i++)
            {
                Noy();
            }
        }

        private void RabotaSTable_Enter(object sender, EventArgs e)
        {

        }


        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.УчетПродажТоваровRow)((System.Data.DataRowView)учетПродажТоваровBindingSource.Current).Row).НомерДокумента);

            УчетФорма заказы = new УчетФорма();
            заказы.ShowDialog();
            учетПродажТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.УчетПродажТоваров);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in учетПродажТоваровDataGridView.SelectedRows)
                    { учетПродажТоваровDataGridView.Rows.RemoveAt(row.Index); }
                    this.Validate();
                    this.учетПродажТоваровBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2Filtr_Click(object sender, EventArgs e)
        {
            String NameField = "";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    NameField = "Товар";
                    break;
            }
            учетПродажТоваровBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            filtr.Clear();
            учетПродажТоваровBindingSource.Filter = "";
        }

        private void учетПродажТоваровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетПродажТоваровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void Учет_продаж_товаров_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.УчетПродажТоваров". При необходимости она может быть перемещена или удалена.
            this.учетПродажТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.УчетПродажТоваров);
            groupBox3.Width = 207;
            groupBox3.Height = 36;
            label8.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int kol = 0;
                string tovar;
                var firstColumnValues =
               from DataGridViewRow row in заказыDataGridView.Rows
               group row by row.Cells[1].Value
               into res
               select new { res.Key, Count = res.Count() };

                StringBuilder result = new StringBuilder();

                foreach (var value in firstColumnValues)
                {
                    if (товарыBindingSource.Find("Название товара", value.Key) != -1) // Проверяем логин на наличие в базе данных
                    {
                        int index = 0;
                        index = товарыBindingSource.Find("Название товара", value.Key);
                        if (index > -1)
                        {
                            товарыBindingSource.Position = index;
                            if (Convert.ToString(value.Key) != "")
                            {
                                tovar = Convert.ToString(value.Key);
                                int cena = Convert.ToInt32(товарыDataGridView.CurrentRow.Cells[2].Value.ToString());
                                kol = value.Count;
                                string dt;
                                int summ;
                                summ = cena * kol;
                                dt = date.ToString("dd.MM.yyyy");
                                this.учетПродажТоваровTableAdapter.InsertQuery(tovar, kol, cena, summ, dt);
                                this.учетПродажТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.УчетПродажТоваров);
                                result.Append("Товары = {").Append(value.Key).Append("Количество = ").Append(value.Count).AppendLine();
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

        private void label7_Click(object sender, EventArgs e)
        {
            groupBox3.Width = 207;
            groupBox3.Height = 115;
            label7.Visible = false;
            label8.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            groupBox3.Width = 207;
            groupBox3.Height = 36; 
            label7.Visible = true;
            label8.Visible = false;
        }

        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.Text = "Учет продаж товаров";
            this.Close();
        }
    }
}
