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
    public partial class Товары : Form
    {
        
        public Товары()
        {
            InitializeComponent();
        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void Товары_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.КаталогТоваров". При необходимости она может быть перемещена или удалена.
            this.каталогТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.КаталогТоваров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);

        }

        private void Poisc_Click(object sender, EventArgs e)
        {
            String NameField = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Название товара";
                    for (int i = 0; i <товарыDataGridView.RowCount - 1; i++)
                        if (товарыDataGridView[1, i].Value.ToString() == textBoxPoisc.Text)
                        {
                          товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                          товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                           товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                           товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                           товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                          товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                          товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                           товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                           товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                           товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                           товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                        }
                    break;
                case 1:
                    NameField = "ЕдиницаИзмерения";
                    for (int i = 0; i < товарыDataGridView.RowCount - 1; i++)
                        if (товарыDataGridView[6, i].Value.ToString() == textBoxPoisc.Text)
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                        }
                    break;
                case 2:
                    NameField = "КодТ";
                    for (int i = 0; i < товарыDataGridView.RowCount - 1; i++)
                        if (товарыDataGridView[0, i].Value.ToString() == textBoxPoisc.Text)
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                        }
                    break;
                case 3:
                    NameField = "Цена";
                    for (int i = 0; i < товарыDataGridView.RowCount - 1; i++)
                        if (товарыDataGridView[2, i].Value.ToString() == textBoxPoisc.Text)
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
                        }
                    break;
            }
            int index = 0;
            index = товарыBindingSource.Find(NameField, textBoxPoisc.Text);
            if (index > -1)
            {
                товарыBindingSource.Position = index;
            }
            else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning ); }
        }

        private void Ob_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBoxPoisc.Clear();
            for (int i = 0; i < товарыDataGridView.RowCount - 1; i++)
            {
                товарыDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                товарыDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                товарыDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                товарыDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                товарыDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
               товарыDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                товарыDataGridView.Rows[i].Cells[6].Style.BackColor = Color.White;
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
                        NameField = "ЕдиницаИзмерения";
                        break;
                }
                товарыBindingSource.Filter = NameField + " like '" + textBox2Filtr.Text + "%'";
                
            }
            catch { MessageBox.Show("Ошибка!!! Проверьте введенные данные!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Obn_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            textBox2Filtr.Clear();
            товарыBindingSource.Filter = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            Var.switcher = 1;
            Var.getPanel = 1;

            ТоварыФормаРаботы товары = new ТоварыФормаРаботы();
            товары.ShowDialog();
            товары.Text = "Новый товар";

            товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.ТоварыRow)((System.Data.DataRowView)товарыBindingSource.Current).Row).КодТ);

            ТоварыФормаРаботы товары = new ТоварыФормаРаботы();
            товары.ShowDialog();
            товары.Text = "Изменения данных";
            товарыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Товары);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("При удаление записи отменить действие будет не возможно. Вы уверены?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in товарыDataGridView.SelectedRows)
                    {товарыDataGridView.Rows.RemoveAt(row.Index);}
                       this.Validate();
                       this.товарыBindingSource.EndEdit();
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
