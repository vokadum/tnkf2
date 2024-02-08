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
   
    public partial class СтатусЗаказа : Form
    {
        DateTime date = DateTime.Now;


        public void Method ()
        {
            for (int i = 0; i < статусЗаказаDataGridView.RowCount - 1; i++)
            {
                if (статусЗаказаBindingSource.Find("Статус", "Ожидает отправки") != -1)
                {
                    if (статусЗаказаDataGridView[4, i].Value.ToString() == "Ожидает отправки")
                    {
                        статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Orange;
                        статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Orange;
                        статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Orange;
                        статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Orange;
                        статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Orange;
                        статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Orange;
                    }
                }
                if (статусЗаказаBindingSource.Find("Статус", "Доставлен") != -1)
                {
                    if (статусЗаказаDataGridView[4, i].Value.ToString() == "Доставлен")
                    {
                        статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Green;
                        статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Green;
                        статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Green;
                        статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Green;
                        статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Green;
                        статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                if (статусЗаказаBindingSource.Find("Статус", "Отменен") != -1)
                {
                    if (статусЗаказаDataGridView[4, i].Value.ToString() == "Отменен")
                    {
                        статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    }
                }
                if (статусЗаказаBindingSource.Find("Статус", "В пути") != -1)
                {
                    if (статусЗаказаDataGridView[4, i].Value.ToString() == "В пути")
                    {
                        статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Red;
                        статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Red;
                    }
                }
            }

        }
        public СтатусЗаказа()
        {
            InitializeComponent();
        }

        private void статусЗаказаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.статусЗаказаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void СтатусЗаказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.СтатусЗаказа". При необходимости она может быть перемещена или удалена.
            this.статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            if (data.mode == 1)
            {
                string kodz, kodk, sb, st, dt;
                kodz = statys.kodZakaza;
                kodk = statys.KodKlienta;
                sb = statys.Sbzakaza;
                st = statys.Statys;
                dt = statys.dataZakaza;
                this.статусЗаказаTableAdapter.InsertQuery(kodz, dt, sb, st, kodk);
                this.статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            }
            if (data.mode == 2)
            {
                int kod;
                string kodk, kodz, sb, st, dt;
                kodz = statys.kodZakaza;
                kodk = statys.KodKlienta;
                sb = statys.Sbzakaza;
                st = statys.Statys;
                dt = statys.dataZakaza;
                kod = statys.kod;
                this.статусЗаказаTableAdapter.UpdateQuery(kodz, dt, sb, st, kodk, kod);
                this.статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            }
            if (data.mode == 4)
            {
                int kod;
                string kodk, kodz, sb, st, dt;
                kodz = statys.kodZakaza;
                kodk = statys.KodKlienta;
                sb = statys.Sbzakaza;
                st = statys.Statys;
                dt = statys.dataZakaza;
                kod = statys.kod;
                this.статусЗаказаTableAdapter.UpdateQuery(kodz, dt, sb, st, kodk, kod);
                this.статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            }
            Method();  
        }
                        

        private void Poisc_Click(object sender, EventArgs e)
        {
            try
            {
                String NF = "";
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        NF = "КодЗаказа";
                        for (int i = 0; i < статусЗаказаDataGridView.RowCount - 1; i++)
                            if (статусЗаказаDataGridView[1, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            }
                        break;
                    case 1:
                        NF = "КодКлиента";
                        for (int i = 0; i < статусЗаказаDataGridView.RowCount - 1; i++)
                            if (статусЗаказаDataGridView[5, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            }
                        break;
                    case 2:
                        NF = "Статус";
                        for (int i = 0; i < статусЗаказаDataGridView.RowCount - 1; i++)
                            if (статусЗаказаDataGridView[4, i].Value.ToString() == textBoxPoisc.Text)
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                статусЗаказаDataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[1].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[2].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[3].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[4].Style.BackColor = Color.White;
                                статусЗаказаDataGridView.Rows[i].Cells[5].Style.BackColor = Color.White;
                            }
                        break;
                }
                int Index = 0;
                Index = статусЗаказаBindingSource.Find(NF, textBoxPoisc.Text);
                if (Index > -1)
                {
                    статусЗаказаBindingSource.Position = Index;
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные и попробуйте еще раз." +
                                        "Если не погмогло обратитесь в тех.поддержку.", "Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные и попробуйте еще раз." +
                                        "Если не погмогло обратитесь в тех.поддержку.", "Ошибка!");
            }
            Method();
        }

        private void Ob_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBoxPoisc.Clear();
            Method();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
            data.mode = 4;
            Var.switcher = 1;
            Var.getPanel = 1;

            data.kod = Convert.ToInt32(((МеждугородняяПродажаТоваровDataSet.СтатусЗаказаRow)((System.Data.DataRowView)статусЗаказаBindingSource.Current).Row).Код);

            ЗаказыФормаРаботы заказы = new ЗаказыФормаРаботы();
            заказы.ShowDialog();
            заказы.Text = "Изменение данных";
            статусЗаказаTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.СтатусЗаказа);
            Method();
            
        }


        private void button2Filtr_Click(object sender, EventArgs e)
        {
            try
            {
                String NameField = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        NameField = "Служба доставки";
                        break;
                            case 1:
                        NameField = "Статус";
                        break;
                }
                статусЗаказаBindingSource.Filter = NameField + " like '" + filtr.Text + "%'";
                Method();
            }

            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Text = "";
                filtr.Clear();
                статусЗаказаBindingSource.Filter = "";
                Method();
            }
            catch { MessageBox.Show("Системаная ошибка, обратитесь к разработчкиу", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void статусЗаказаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(button1, null);
        }

        private void вернутьсяНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            main.Text = "Учет продаж товаров";
        }
    }
}
