namespace ДипломнаяРабота
{
    partial class ПоставщикиФормаРаботы
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодПLabel;
            System.Windows.Forms.Label наименование_организацииLabel;
            System.Windows.Forms.Label номерДоговораLabel;
            System.Windows.Forms.Label датаЗаключенияLabel;
            System.Windows.Forms.Label датаОкончанияLabel;
            System.Windows.Forms.Label факсLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПоставщикиФормаРаботы));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.факсTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.датаОкончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаЗаключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номерДоговораTextBox = new System.Windows.Forms.TextBox();
            this.наименование_организацииTextBox = new System.Windows.Forms.TextBox();
            this.кодПTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.поставщикиTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            кодПLabel = new System.Windows.Forms.Label();
            наименование_организацииLabel = new System.Windows.Forms.Label();
            номерДоговораLabel = new System.Windows.Forms.Label();
            датаЗаключенияLabel = new System.Windows.Forms.Label();
            датаОкончанияLabel = new System.Windows.Forms.Label();
            факсLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // кодПLabel
            // 
            кодПLabel.AutoSize = true;
            кодПLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодПLabel.ForeColor = System.Drawing.Color.White;
            кодПLabel.Location = new System.Drawing.Point(12, 22);
            кодПLabel.Name = "кодПLabel";
            кодПLabel.Size = new System.Drawing.Size(115, 16);
            кодПLabel.TabIndex = 0;
            кодПLabel.Text = "Код поставщика:";
            // 
            // наименование_организацииLabel
            // 
            наименование_организацииLabel.AutoSize = true;
            наименование_организацииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_организацииLabel.ForeColor = System.Drawing.Color.White;
            наименование_организацииLabel.Location = new System.Drawing.Point(12, 50);
            наименование_организацииLabel.Name = "наименование_организацииLabel";
            наименование_организацииLabel.Size = new System.Drawing.Size(198, 16);
            наименование_организацииLabel.TabIndex = 2;
            наименование_организацииLabel.Text = "Наименование организации:";
            // 
            // номерДоговораLabel
            // 
            номерДоговораLabel.AutoSize = true;
            номерДоговораLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерДоговораLabel.ForeColor = System.Drawing.Color.White;
            номерДоговораLabel.Location = new System.Drawing.Point(12, 78);
            номерДоговораLabel.Name = "номерДоговораLabel";
            номерДоговораLabel.Size = new System.Drawing.Size(118, 16);
            номерДоговораLabel.TabIndex = 4;
            номерДоговораLabel.Text = "Номер договора:";
            // 
            // датаЗаключенияLabel
            // 
            датаЗаключенияLabel.AutoSize = true;
            датаЗаключенияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаЗаключенияLabel.ForeColor = System.Drawing.Color.White;
            датаЗаключенияLabel.Location = new System.Drawing.Point(12, 106);
            датаЗаключенияLabel.Name = "датаЗаключенияLabel";
            датаЗаключенияLabel.Size = new System.Drawing.Size(125, 16);
            датаЗаключенияLabel.TabIndex = 6;
            датаЗаключенияLabel.Text = "Дата заключения:";
            // 
            // датаОкончанияLabel
            // 
            датаОкончанияLabel.AutoSize = true;
            датаОкончанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаОкончанияLabel.ForeColor = System.Drawing.Color.White;
            датаОкончанияLabel.Location = new System.Drawing.Point(12, 132);
            датаОкончанияLabel.Name = "датаОкончанияLabel";
            датаОкончанияLabel.Size = new System.Drawing.Size(115, 16);
            датаОкончанияLabel.TabIndex = 8;
            датаОкончанияLabel.Text = "Дата окончания:";
            // 
            // факсLabel
            // 
            факсLabel.AutoSize = true;
            факсLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            факсLabel.ForeColor = System.Drawing.Color.White;
            факсLabel.Location = new System.Drawing.Point(12, 160);
            факсLabel.Name = "факсLabel";
            факсLabel.Size = new System.Drawing.Size(43, 16);
            факсLabel.TabIndex = 10;
            факсLabel.Text = "Факс:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.White;
            телефонLabel.Location = new System.Drawing.Point(12, 188);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 12;
            телефонLabel.Text = "Телефон:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            e_mailLabel.ForeColor = System.Drawing.Color.White;
            e_mailLabel.Location = new System.Drawing.Point(12, 214);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(48, 16);
            e_mailLabel.TabIndex = 14;
            e_mailLabel.Text = "E-mail:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 350);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(this.факсTextBox);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(факсLabel);
            this.groupBox1.Controls.Add(датаОкончанияLabel);
            this.groupBox1.Controls.Add(this.датаОкончанияDateTimePicker);
            this.groupBox1.Controls.Add(датаЗаключенияLabel);
            this.groupBox1.Controls.Add(this.датаЗаключенияDateTimePicker);
            this.groupBox1.Controls.Add(номерДоговораLabel);
            this.groupBox1.Controls.Add(this.номерДоговораTextBox);
            this.groupBox1.Controls.Add(наименование_организацииLabel);
            this.groupBox1.Controls.Add(this.наименование_организацииTextBox);
            this.groupBox1.Controls.Add(кодПLabel);
            this.groupBox1.Controls.Add(this.кодПTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 253);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(448, 165);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(10, 20);
            this.телефонTextBox.TabIndex = 21;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // факсTextBox
            // 
            this.факсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Факс", true));
            this.факсTextBox.Location = new System.Drawing.Point(223, 159);
            this.факсTextBox.Name = "факсTextBox";
            this.факсTextBox.Size = new System.Drawing.Size(189, 20);
            this.факсTextBox.TabIndex = 20;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox3.Location = new System.Drawing.Point(223, 185);
            this.maskedTextBox3.Mask = "+7 (999) 000-00-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(189, 22);
            this.maskedTextBox3.TabIndex = 18;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "e-mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_mailTextBox.Location = new System.Drawing.Point(223, 211);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(189, 22);
            this.e_mailTextBox.TabIndex = 15;
            // 
            // датаОкончанияDateTimePicker
            // 
            this.датаОкончанияDateTimePicker.CustomFormat = "";
            this.датаОкончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.поставщикиBindingSource, "ДатаОкончания", true));
            this.датаОкончанияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаОкончанияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаОкончанияDateTimePicker.Location = new System.Drawing.Point(223, 131);
            this.датаОкончанияDateTimePicker.Name = "датаОкончанияDateTimePicker";
            this.датаОкончанияDateTimePicker.Size = new System.Drawing.Size(189, 22);
            this.датаОкончанияDateTimePicker.TabIndex = 9;
            this.датаОкончанияDateTimePicker.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // датаЗаключенияDateTimePicker
            // 
            this.датаЗаключенияDateTimePicker.CustomFormat = "";
            this.датаЗаключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.поставщикиBindingSource, "ДатаЗаключения", true));
            this.датаЗаключенияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаЗаключенияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаЗаключенияDateTimePicker.Location = new System.Drawing.Point(223, 103);
            this.датаЗаключенияDateTimePicker.Name = "датаЗаключенияDateTimePicker";
            this.датаЗаключенияDateTimePicker.Size = new System.Drawing.Size(189, 22);
            this.датаЗаключенияDateTimePicker.TabIndex = 7;
            this.датаЗаключенияDateTimePicker.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // номерДоговораTextBox
            // 
            this.номерДоговораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "НомерДоговора", true));
            this.номерДоговораTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерДоговораTextBox.Location = new System.Drawing.Point(223, 75);
            this.номерДоговораTextBox.Name = "номерДоговораTextBox";
            this.номерДоговораTextBox.Size = new System.Drawing.Size(189, 22);
            this.номерДоговораTextBox.TabIndex = 5;
            this.номерДоговораTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номерДоговораTextBox_KeyPress);
            // 
            // наименование_организацииTextBox
            // 
            this.наименование_организацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Наименование организации", true));
            this.наименование_организацииTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_организацииTextBox.Location = new System.Drawing.Point(223, 47);
            this.наименование_организацииTextBox.Name = "наименование_организацииTextBox";
            this.наименование_организацииTextBox.Size = new System.Drawing.Size(189, 22);
            this.наименование_организацииTextBox.TabIndex = 3;
            // 
            // кодПTextBox
            // 
            this.кодПTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "КодП", true));
            this.кодПTextBox.Enabled = false;
            this.кодПTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодПTextBox.Location = new System.Drawing.Point(223, 19);
            this.кодПTextBox.Name = "кодПTextBox";
            this.кодПTextBox.Size = new System.Drawing.Size(189, 22);
            this.кодПTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Добавить запись о поставщике";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(348, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КаталогТоваровTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.ПриклоднаяНаклоднаяTableAdapter = null;
            this.tableAdapterManager.Расчет_зарплатыTableAdapter = null;
            this.tableAdapterManager.СлужбаДоставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтатусЗаказаTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = null;
            // 
            // ПоставщикиФормаРаботы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(437, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ПоставщикиФормаРаботы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.ПоставщикиФормаРаботы_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ПоставщикиФормаРаботы_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private МеждугородняяПродажаТоваровDataSet междугородняяПродажаТоваровDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.DateTimePicker датаОкончанияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаЗаключенияDateTimePicker;
        private System.Windows.Forms.TextBox номерДоговораTextBox;
        private System.Windows.Forms.TextBox наименование_организацииTextBox;
        private System.Windows.Forms.TextBox кодПTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox факсTextBox;
    }
}