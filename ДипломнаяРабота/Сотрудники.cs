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
    public partial class Сотрудники : Form
    {
        public void Es()
        {
            for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)

            {
                сотрудникиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                сотрудникиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                сотрудникиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                сотрудникиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                сотрудникиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                сотрудникиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
            }
               
        }
        public void Noy()
        {
            for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                    {
                        сотрудникиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                        сотрудникиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                        сотрудникиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                        сотрудникиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                сотрудникиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                сотрудникиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
            }
        }
        public Сотрудники()
        {InitializeComponent();}
        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
        }
        private void Сотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Должность". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                data.mode = 1;
                Var.switcher = 1;
                Var.getPanel = 1;
                AddingForm сотрудники2 = new AddingForm();
                сотрудники2.ShowDialog();
                сотрудникиTableAdapter.Fill(междугородняяПродажаТоваровDataSet.Сотрудники);
            }
            catch
            {
                
            }
            
            
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                data.mode = 2;Var.switcher = 1;Var.getPanel = 1;
                data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.СотрудникиRow)((System.Data.DataRowView)сотрудникиBindingSource.Current).Row).НомерСотрудника);
                AddingForm сотрудники2 = new AddingForm();
                сотрудники2.ShowDialog();
                сотрудникиTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.Сотрудники);}
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу","Ошибка!!!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                    
                    data.mode = 4;
                    Var.switcher = 1;
                    Var.getPanel = 2;
                    AddingForm form = new AddingForm();

                    form.ShowDialog();
                    this.Validate();
                    this.сотрудникиBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button1Poisc_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        NameField = "НомерСотрудника";
                        for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                            if (сотрудникиDataGridView[0, i].Value.ToString() == poisc.Text)
                            {
                                сотрудникиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                сотрудникиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                сотрудникиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                сотрудникиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                сотрудникиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                сотрудникиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                сотрудникиDataGridView.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                                сотрудникиDataGridView.Rows[i].Cells[1].Style.BackColor = Color.PaleTurquoise;
                                сотрудникиDataGridView.Rows[i].Cells[2].Style.BackColor = Color.PaleTurquoise;
                                сотрудникиDataGridView.Rows[i].Cells[3].Style.BackColor = Color.PaleTurquoise;
                                сотрудникиDataGridView.Rows[i].Cells[4].Style.BackColor = Color.PaleTurquoise;
                                сотрудникиDataGridView.Rows[i].Cells[5].Style.BackColor = Color.PaleTurquoise;
                            }
                        break;
                    case 1:
                        NameField = "Фамилия";
                        for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                            if (сотрудникиDataGridView[1, i].Value.ToString() == poisc.Text)
                            {
                                Es();
                            }
                            else
                            {
                                Noy();
                            }
                        break;
                    case 2:
                        NameField = "Имя";
                        for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                            if (сотрудникиDataGridView[2, i].Value.ToString() == poisc.Text)
                            {
                                Es();
                            }
                            else
                            {
                                Noy();
                            }
                        break;
                    case 3:
                        NameField = "Отчество";
                        for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                            if (сотрудникиDataGridView[3, i].Value.ToString() == poisc.Text)
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
                index = сотрудникиBindingSource.Find(NameField, poisc.Text);
                if (index > -1)
                {сотрудникиBindingSource.Position = index;} 
                else { MessageBox.Show("Ошибка поиска, проверьте введенные данные!"); }
            }catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {String NameField = "";
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
                сотрудникиBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
            }catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                poisc.Clear();
                for (int i = 0; i < сотрудникиDataGridView.RowCount - 1; i++)
                {
                    Noy();
                }
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Text = "";
                filtr.Clear();
                сотрудникиBindingSource.Filter = "";
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void DeleteQerlly_Click(object sender, EventArgs e)
        {
            
            data.mode = 4;
            Var.switcher = 1;
            Var.getPanel = 2;
            AddingForm form = new AddingForm();
            form.ShowDialog();

            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
        }
        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try {this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);}
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);
        }
        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {

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

        private void RabotaSTable_Enter(object sender, EventArgs e)
        {

        }


        private void сотрудникиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

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
