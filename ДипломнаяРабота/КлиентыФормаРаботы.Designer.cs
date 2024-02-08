namespace ДипломнаяРабота
{
    partial class КлиентыФормаРаботы
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
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчетсвоLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label серияИНомерLabel;
            System.Windows.Forms.Label адресПроживанияLabel;
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label кодЗаказаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(КлиентыФормаРаботы));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.кодЗаказаTextBox = new System.Windows.Forms.TextBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.адресПроживанияTextBox = new System.Windows.Forms.TextBox();
            this.серияИНомерTextBox = new System.Windows.Forms.TextBox();
            this.датаРожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.отчетсвоTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.клиентыTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            кодLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчетсвоLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            серияИНомерLabel = new System.Windows.Forms.Label();
            адресПроживанияLabel = new System.Windows.Forms.Label();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            кодЗаказаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.ForeColor = System.Drawing.Color.White;
            кодLabel.Location = new System.Drawing.Point(11, 22);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(91, 16);
            кодLabel.TabIndex = 0;
            кодLabel.Text = "Код клиента:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.ForeColor = System.Drawing.Color.White;
            фамилияLabel.Location = new System.Drawing.Point(11, 48);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.ForeColor = System.Drawing.Color.White;
            имяLabel.Location = new System.Drawing.Point(11, 74);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчетсвоLabel
            // 
            отчетсвоLabel.AutoSize = true;
            отчетсвоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            отчетсвоLabel.ForeColor = System.Drawing.Color.White;
            отчетсвоLabel.Location = new System.Drawing.Point(11, 100);
            отчетсвоLabel.Name = "отчетсвоLabel";
            отчетсвоLabel.Size = new System.Drawing.Size(73, 16);
            отчетсвоLabel.TabIndex = 6;
            отчетсвоLabel.Text = "Отчетсво:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаРожденияLabel.ForeColor = System.Drawing.Color.White;
            датаРожденияLabel.Location = new System.Drawing.Point(11, 129);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(109, 16);
            датаРожденияLabel.TabIndex = 8;
            датаРожденияLabel.Text = "Дата рождения:";
            // 
            // серияИНомерLabel
            // 
            серияИНомерLabel.AutoSize = true;
            серияИНомерLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            серияИНомерLabel.ForeColor = System.Drawing.Color.White;
            серияИНомерLabel.Location = new System.Drawing.Point(11, 152);
            серияИНомерLabel.Name = "серияИНомерLabel";
            серияИНомерLabel.Size = new System.Drawing.Size(105, 16);
            серияИНомерLabel.TabIndex = 10;
            серияИНомерLabel.Text = "Серия и номер:";
            // 
            // адресПроживанияLabel
            // 
            адресПроживанияLabel.AutoSize = true;
            адресПроживанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресПроживанияLabel.ForeColor = System.Drawing.Color.White;
            адресПроживанияLabel.Location = new System.Drawing.Point(11, 179);
            адресПроживанияLabel.Name = "адресПроживанияLabel";
            адресПроживанияLabel.Size = new System.Drawing.Size(133, 16);
            адресПроживанияLabel.TabIndex = 12;
            адресПроживанияLabel.Text = "Адрес проживания:";
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерТелефонаLabel.ForeColor = System.Drawing.Color.White;
            номерТелефонаLabel.Location = new System.Drawing.Point(11, 205);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(122, 16);
            номерТелефонаLabel.TabIndex = 14;
            номерТелефонаLabel.Text = "Номер телефона:";
            // 
            // кодЗаказаLabel
            // 
            кодЗаказаLabel.AutoSize = true;
            кодЗаказаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодЗаказаLabel.ForeColor = System.Drawing.Color.White;
            кодЗаказаLabel.Location = new System.Drawing.Point(11, 229);
            кодЗаказаLabel.Name = "кодЗаказаLabel";
            кодЗаказаLabel.Size = new System.Drawing.Size(84, 16);
            кодЗаказаLabel.TabIndex = 16;
            кодЗаказаLabel.Text = "Код заказа:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 358);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(кодЗаказаLabel);
            this.groupBox1.Controls.Add(this.кодЗаказаTextBox);
            this.groupBox1.Controls.Add(номерТелефонаLabel);
            this.groupBox1.Controls.Add(this.номерТелефонаTextBox);
            this.groupBox1.Controls.Add(адресПроживанияLabel);
            this.groupBox1.Controls.Add(this.адресПроживанияTextBox);
            this.groupBox1.Controls.Add(серияИНомерLabel);
            this.groupBox1.Controls.Add(this.серияИНомерTextBox);
            this.groupBox1.Controls.Add(датаРожденияLabel);
            this.groupBox1.Controls.Add(this.датаРожденияDateTimePicker);
            this.groupBox1.Controls.Add(отчетсвоLabel);
            this.groupBox1.Controls.Add(this.отчетсвоTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(кодLabel);
            this.groupBox1.Controls.Add(this.кодTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 266);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 202);
            this.maskedTextBox1.Mask = "+7 (999) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(147, 22);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // кодЗаказаTextBox
            // 
            this.кодЗаказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "КодЗаказа", true));
            this.кодЗаказаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодЗаказаTextBox.Location = new System.Drawing.Point(152, 226);
            this.кодЗаказаTextBox.Name = "кодЗаказаTextBox";
            this.кодЗаказаTextBox.Size = new System.Drawing.Size(147, 22);
            this.кодЗаказаTextBox.TabIndex = 17;
            this.кодЗаказаTextBox.TextChanged += new System.EventHandler(this.кодЗаказаTextBox_TextChanged);
            this.кодЗаказаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.кодЗаказаTextBox_KeyPress);
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "НомерТелефона", true));
            this.номерТелефонаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(152, 202);
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(131, 22);
            this.номерТелефонаTextBox.TabIndex = 15;
            // 
            // адресПроживанияTextBox
            // 
            this.адресПроживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "АдресПроживания", true));
            this.адресПроживанияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресПроживанияTextBox.Location = new System.Drawing.Point(152, 176);
            this.адресПроживанияTextBox.Name = "адресПроживанияTextBox";
            this.адресПроживанияTextBox.Size = new System.Drawing.Size(147, 22);
            this.адресПроживанияTextBox.TabIndex = 13;
            this.адресПроживанияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.адресПроживанияTextBox_KeyPress);
            // 
            // серияИНомерTextBox
            // 
            this.серияИНомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "СерияИНомер", true));
            this.серияИНомерTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.серияИНомерTextBox.Location = new System.Drawing.Point(152, 149);
            this.серияИНомерTextBox.Name = "серияИНомерTextBox";
            this.серияИНомерTextBox.Size = new System.Drawing.Size(147, 22);
            this.серияИНомерTextBox.TabIndex = 11;
            this.серияИНомерTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.серияИНомерTextBox_KeyPress);
            // 
            // датаРожденияDateTimePicker
            // 
            this.датаРожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "ДатаРождения", true));
            this.датаРожденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаРожденияDateTimePicker.Location = new System.Drawing.Point(152, 123);
            this.датаРожденияDateTimePicker.MaxDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.датаРожденияDateTimePicker.Name = "датаРожденияDateTimePicker";
            this.датаРожденияDateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.датаРожденияDateTimePicker.TabIndex = 9;
            this.датаРожденияDateTimePicker.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.датаРожденияDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.датаРожденияDateTimePicker_KeyPress);
            // 
            // отчетсвоTextBox
            // 
            this.отчетсвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Отчетсво", true));
            this.отчетсвоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетсвоTextBox.Location = new System.Drawing.Point(152, 97);
            this.отчетсвоTextBox.Name = "отчетсвоTextBox";
            this.отчетсвоTextBox.Size = new System.Drawing.Size(147, 22);
            this.отчетсвоTextBox.TabIndex = 7;
            this.отчетсвоTextBox.TextChanged += new System.EventHandler(this.отчетсвоTextBox_TextChanged);
            this.отчетсвоTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.отчетсвоTextBox_KeyPress);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.имяTextBox.Location = new System.Drawing.Point(152, 71);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(147, 22);
            this.имяTextBox.TabIndex = 5;
            this.имяTextBox.TextChanged += new System.EventHandler(this.имяTextBox_TextChanged);
            this.имяTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.имяTextBox_KeyPress);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фамилияTextBox.Location = new System.Drawing.Point(152, 45);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(147, 22);
            this.фамилияTextBox.TabIndex = 3;
            this.фамилияTextBox.TextChanged += new System.EventHandler(this.фамилияTextBox_TextChanged);
            this.фамилияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.фамилияTextBox_KeyPress);
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код", true));
            this.кодTextBox.Enabled = false;
            this.кодTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодTextBox.Location = new System.Drawing.Point(152, 19);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(147, 22);
            this.кодTextBox.TabIndex = 1;
            this.кодTextBox.TextChanged += new System.EventHandler(this.кодTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Изменить данные о клиенте";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(241, 320);
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КаталогТоваровTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПриклоднаяНаклоднаяTableAdapter = null;
            this.tableAdapterManager.Расчет_зарплатыTableAdapter = null;
            this.tableAdapterManager.СлужбаДоставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтатусЗаказаTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = null;
            // 
            // КлиентыФормаРаботы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(328, 358);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "КлиентыФормаРаботы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.КлиентыФормаРаботы_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.КлиентыФормаРаботы_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодЗаказаTextBox;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.TextBox адресПроживанияTextBox;
        private System.Windows.Forms.TextBox серияИНомерTextBox;
        private System.Windows.Forms.DateTimePicker датаРожденияDateTimePicker;
        private System.Windows.Forms.TextBox отчетсвоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}