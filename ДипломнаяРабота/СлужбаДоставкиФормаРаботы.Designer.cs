namespace ДипломнаяРабота
{
    partial class СлужбаДоставкиФормаРаботы
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
            System.Windows.Forms.Label кодСДLabel;
            System.Windows.Forms.Label наименование_ОгранизацииLabel;
            System.Windows.Forms.Label номерДоговораLabel;
            System.Windows.Forms.Label датаЗаключенияLabel;
            System.Windows.Forms.Label датаОкончанияLabel;
            System.Windows.Forms.Label факсLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СлужбаДоставкиФормаРаботы));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.службаДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.факсTextBox = new System.Windows.Forms.TextBox();
            this.датаОкончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаЗаключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номерДоговораTextBox = new System.Windows.Forms.TextBox();
            this.наименование_ОгранизацииTextBox = new System.Windows.Forms.TextBox();
            this.кодСДTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.службаДоставкиTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.СлужбаДоставкиTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            кодСДLabel = new System.Windows.Forms.Label();
            наименование_ОгранизацииLabel = new System.Windows.Forms.Label();
            номерДоговораLabel = new System.Windows.Forms.Label();
            датаЗаключенияLabel = new System.Windows.Forms.Label();
            датаОкончанияLabel = new System.Windows.Forms.Label();
            факсLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.службаДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // кодСДLabel
            // 
            кодСДLabel.AutoSize = true;
            кодСДLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодСДLabel.ForeColor = System.Drawing.Color.White;
            кодСДLabel.Location = new System.Drawing.Point(11, 22);
            кодСДLabel.Name = "кодСДLabel";
            кодСДLabel.Size = new System.Drawing.Size(55, 16);
            кодСДLabel.TabIndex = 0;
            кодСДLabel.Text = "Код СД:";
            // 
            // наименование_ОгранизацииLabel
            // 
            наименование_ОгранизацииLabel.AutoSize = true;
            наименование_ОгранизацииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_ОгранизацииLabel.ForeColor = System.Drawing.Color.White;
            наименование_ОгранизацииLabel.Location = new System.Drawing.Point(11, 49);
            наименование_ОгранизацииLabel.Name = "наименование_ОгранизацииLabel";
            наименование_ОгранизацииLabel.Size = new System.Drawing.Size(200, 16);
            наименование_ОгранизацииLabel.TabIndex = 2;
            наименование_ОгранизацииLabel.Text = "Наименование Огранизации:";
            // 
            // номерДоговораLabel
            // 
            номерДоговораLabel.AutoSize = true;
            номерДоговораLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерДоговораLabel.ForeColor = System.Drawing.Color.White;
            номерДоговораLabel.Location = new System.Drawing.Point(11, 73);
            номерДоговораLabel.Name = "номерДоговораLabel";
            номерДоговораLabel.Size = new System.Drawing.Size(119, 16);
            номерДоговораLabel.TabIndex = 4;
            номерДоговораLabel.Text = "Номер Договора:";
            // 
            // датаЗаключенияLabel
            // 
            датаЗаключенияLabel.AutoSize = true;
            датаЗаключенияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаЗаключенияLabel.ForeColor = System.Drawing.Color.White;
            датаЗаключенияLabel.Location = new System.Drawing.Point(11, 102);
            датаЗаключенияLabel.Name = "датаЗаключенияLabel";
            датаЗаключенияLabel.Size = new System.Drawing.Size(126, 16);
            датаЗаключенияLabel.TabIndex = 6;
            датаЗаключенияLabel.Text = "Дата Заключения:";
            // 
            // датаОкончанияLabel
            // 
            датаОкончанияLabel.AutoSize = true;
            датаОкончанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаОкончанияLabel.ForeColor = System.Drawing.Color.White;
            датаОкончанияLabel.Location = new System.Drawing.Point(11, 128);
            датаОкончанияLabel.Name = "датаОкончанияLabel";
            датаОкончанияLabel.Size = new System.Drawing.Size(117, 16);
            датаОкончанияLabel.TabIndex = 8;
            датаОкончанияLabel.Text = "Дата Окончания:";
            // 
            // факсLabel
            // 
            факсLabel.AutoSize = true;
            факсLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            факсLabel.ForeColor = System.Drawing.Color.White;
            факсLabel.Location = new System.Drawing.Point(11, 151);
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
            телефонLabel.Location = new System.Drawing.Point(11, 177);
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
            e_mailLabel.Location = new System.Drawing.Point(11, 203);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(47, 16);
            e_mailLabel.TabIndex = 14;
            e_mailLabel.Text = "e-mail:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 336);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(факсLabel);
            this.groupBox1.Controls.Add(this.факсTextBox);
            this.groupBox1.Controls.Add(датаОкончанияLabel);
            this.groupBox1.Controls.Add(this.датаОкончанияDateTimePicker);
            this.groupBox1.Controls.Add(датаЗаключенияLabel);
            this.groupBox1.Controls.Add(this.датаЗаключенияDateTimePicker);
            this.groupBox1.Controls.Add(номерДоговораLabel);
            this.groupBox1.Controls.Add(this.номерДоговораTextBox);
            this.groupBox1.Controls.Add(наименование_ОгранизацииLabel);
            this.groupBox1.Controls.Add(this.наименование_ОгранизацииTextBox);
            this.groupBox1.Controls.Add(кодСДLabel);
            this.groupBox1.Controls.Add(this.кодСДTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(211, 176);
            this.maskedTextBox1.Mask = "+7(999) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "e-mail", true));
            this.e_mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_mailTextBox.Location = new System.Drawing.Point(211, 202);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(200, 22);
            this.e_mailTextBox.TabIndex = 15;
            // 
            // службаДоставкиBindingSource
            // 
            this.службаДоставкиBindingSource.DataMember = "СлужбаДоставки";
            this.службаДоставкиBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "Телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(211, 176);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(128, 22);
            this.телефонTextBox.TabIndex = 13;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номерДоговораTextBox_KeyPress);
            // 
            // факсTextBox
            // 
            this.факсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "Факс", true));
            this.факсTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.факсTextBox.Location = new System.Drawing.Point(211, 150);
            this.факсTextBox.Name = "факсTextBox";
            this.факсTextBox.Size = new System.Drawing.Size(200, 22);
            this.факсTextBox.TabIndex = 11;
            this.факсTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номерДоговораTextBox_KeyPress);
            // 
            // датаОкончанияDateTimePicker
            // 
            this.датаОкончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.службаДоставкиBindingSource, "ДатаОкончания", true));
            this.датаОкончанияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаОкончанияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаОкончанияDateTimePicker.Location = new System.Drawing.Point(211, 124);
            this.датаОкончанияDateTimePicker.Name = "датаОкончанияDateTimePicker";
            this.датаОкончанияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаОкончанияDateTimePicker.TabIndex = 9;
            this.датаОкончанияDateTimePicker.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // датаЗаключенияDateTimePicker
            // 
            this.датаЗаключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.службаДоставкиBindingSource, "ДатаЗаключения", true));
            this.датаЗаключенияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаЗаключенияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаЗаключенияDateTimePicker.Location = new System.Drawing.Point(211, 98);
            this.датаЗаключенияDateTimePicker.Name = "датаЗаключенияDateTimePicker";
            this.датаЗаключенияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаЗаключенияDateTimePicker.TabIndex = 7;
            this.датаЗаключенияDateTimePicker.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // номерДоговораTextBox
            // 
            this.номерДоговораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "НомерДоговора", true));
            this.номерДоговораTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерДоговораTextBox.Location = new System.Drawing.Point(211, 72);
            this.номерДоговораTextBox.Name = "номерДоговораTextBox";
            this.номерДоговораTextBox.Size = new System.Drawing.Size(200, 22);
            this.номерДоговораTextBox.TabIndex = 5;
            this.номерДоговораTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.номерДоговораTextBox_KeyPress);
            // 
            // наименование_ОгранизацииTextBox
            // 
            this.наименование_ОгранизацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "Наименование Огранизации", true));
            this.наименование_ОгранизацииTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_ОгранизацииTextBox.Location = new System.Drawing.Point(211, 46);
            this.наименование_ОгранизацииTextBox.Name = "наименование_ОгранизацииTextBox";
            this.наименование_ОгранизацииTextBox.Size = new System.Drawing.Size(200, 22);
            this.наименование_ОгранизацииTextBox.TabIndex = 3;
            // 
            // кодСДTextBox
            // 
            this.кодСДTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.службаДоставкиBindingSource, "КодСД", true));
            this.кодСДTextBox.Enabled = false;
            this.кодСДTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодСДTextBox.Location = new System.Drawing.Point(211, 21);
            this.кодСДTextBox.Name = "кодСДTextBox";
            this.кодСДTextBox.Size = new System.Drawing.Size(200, 22);
            this.кодСДTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Добавить запись о службе доставки.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(352, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
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
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // службаДоставкиTableAdapter
            // 
            this.службаДоставкиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПриклоднаяНаклоднаяTableAdapter = null;
            this.tableAdapterManager.Расчет_зарплатыTableAdapter = null;
            this.tableAdapterManager.СлужбаДоставкиTableAdapter = this.службаДоставкиTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтатусЗаказаTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = null;
            // 
            // СлужбаДоставкиФормаРаботы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(439, 336);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "СлужбаДоставкиФормаРаботы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Служба доставки";
            this.Load += new System.EventHandler(this.СлужбаДоставкиФормаРаботы_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.СлужбаДоставкиФормаРаботы_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.службаДоставкиBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource службаДоставкиBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.СлужбаДоставкиTableAdapter службаДоставкиTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox факсTextBox;
        private System.Windows.Forms.DateTimePicker датаОкончанияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаЗаключенияDateTimePicker;
        private System.Windows.Forms.TextBox номерДоговораTextBox;
        private System.Windows.Forms.TextBox наименование_ОгранизацииTextBox;
        private System.Windows.Forms.TextBox кодСДTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}