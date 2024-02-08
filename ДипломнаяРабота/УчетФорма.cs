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
    public partial class УчетФорма : Form
    {
        public УчетФорма()
        {
            InitializeComponent();
        }

        private void учетПродажТоваровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетПродажТоваровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.междугородняяПродажаТоваровDataSet);

        }

        private void УчетФорма_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "междугородняяПродажаТоваровDataSet.УчетПродажТоваров". При необходимости она может быть перемещена или удалена.
            this.учетПродажТоваровTableAdapter.Fill(this.междугородняяПродажаТоваровDataSet.УчетПродажТоваров);
            this.Width = 413;
            this.Height = 339;
            switch (Var.switcher)
            {
                case 1:
                    if (Var.getPanel == 1)
                    {
                        panel1.Enabled = true;
                        panel1.Visible = true;
                        panel1.Location = new Point(2, 0);

                        if (data.mode == 2)
                        {
                            int pos = учетПродажТоваровBindingSource.Find("НомерДокумента", data.kod);
                            учетПродажТоваровBindingSource.Position = pos;
                        }
                    }
                    else { panel1.Enabled = false; panel1.Visible = false; }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
