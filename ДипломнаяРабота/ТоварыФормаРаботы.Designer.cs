namespace ДипломнаяРабота
{
    partial class ТоварыФормаРаботы
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
            System.Windows.Forms.Label кодТLabel;
            System.Windows.Forms.Label название_товараLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label количествоСкладLabel;
            System.Windows.Forms.Label кодПоставщикаLabel;
            System.Windows.Forms.Label кодРазделаLabel;
            System.Windows.Forms.Label единицаИзмеренияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ТоварыФормаРаботы));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.каталогТоваровBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.каталогТоваровBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.единицаИзмеренияTextBox = new System.Windows.Forms.TextBox();
            this.кодТTextBox = new System.Windows.Forms.TextBox();
            this.название_товараTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.количествоСкладTextBox = new System.Windows.Forms.TextBox();
            this.каталогТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            this.каталогТоваровTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.КаталогТоваровTableAdapter();
            this.каталогТоваровDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter();
            this.поставщикиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодТLabel = new System.Windows.Forms.Label();
            название_товараLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            количествоСкладLabel = new System.Windows.Forms.Label();
            кодПоставщикаLabel = new System.Windows.Forms.Label();
            кодРазделаLabel = new System.Windows.Forms.Label();
            единицаИзмеренияLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // кодТLabel
            // 
            кодТLabel.AutoSize = true;
            кодТLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодТLabel.ForeColor = System.Drawing.Color.White;
            кодТLabel.Location = new System.Drawing.Point(15, 22);
            кодТLabel.Name = "кодТLabel";
            кодТLabel.Size = new System.Drawing.Size(84, 16);
            кодТLabel.TabIndex = 0;
            кодТLabel.Text = "Код товара:";
            // 
            // название_товараLabel
            // 
            название_товараLabel.AutoSize = true;
            название_товараLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_товараLabel.ForeColor = System.Drawing.Color.White;
            название_товараLabel.Location = new System.Drawing.Point(15, 50);
            название_товараLabel.Name = "название_товараLabel";
            название_товараLabel.Size = new System.Drawing.Size(126, 16);
            название_товараLabel.TabIndex = 2;
            название_товараLabel.Text = "Название товара:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ценаLabel.ForeColor = System.Drawing.Color.White;
            ценаLabel.Location = new System.Drawing.Point(15, 78);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 4;
            ценаLabel.Text = "Цена:";
            // 
            // количествоСкладLabel
            // 
            количествоСкладLabel.AutoSize = true;
            количествоСкладLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количествоСкладLabel.ForeColor = System.Drawing.Color.White;
            количествоСкладLabel.Location = new System.Drawing.Point(15, 106);
            количествоСкладLabel.Name = "количествоСкладLabel";
            количествоСкладLabel.Size = new System.Drawing.Size(129, 16);
            количествоСкладLabel.TabIndex = 6;
            количествоСкладLabel.Text = "Количество склад:";
            // 
            // кодПоставщикаLabel
            // 
            кодПоставщикаLabel.AutoSize = true;
            кодПоставщикаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодПоставщикаLabel.ForeColor = System.Drawing.Color.White;
            кодПоставщикаLabel.Location = new System.Drawing.Point(15, 134);
            кодПоставщикаLabel.Name = "кодПоставщикаLabel";
            кодПоставщикаLabel.Size = new System.Drawing.Size(115, 16);
            кодПоставщикаLabel.TabIndex = 8;
            кодПоставщикаLabel.Text = "Код поставщика:";
            // 
            // кодРазделаLabel
            // 
            кодРазделаLabel.AutoSize = true;
            кодРазделаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодРазделаLabel.ForeColor = System.Drawing.Color.White;
            кодРазделаLabel.Location = new System.Drawing.Point(15, 164);
            кодРазделаLabel.Name = "кодРазделаLabel";
            кодРазделаLabel.Size = new System.Drawing.Size(93, 16);
            кодРазделаLabel.TabIndex = 10;
            кодРазделаLabel.Text = "Код раздела:";
            // 
            // единицаИзмеренияLabel
            // 
            единицаИзмеренияLabel.AutoSize = true;
            единицаИзмеренияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            единицаИзмеренияLabel.ForeColor = System.Drawing.Color.White;
            единицаИзмеренияLabel.Location = new System.Drawing.Point(15, 194);
            единицаИзмеренияLabel.Name = "единицаИзмеренияLabel";
            единицаИзмеренияLabel.Size = new System.Drawing.Size(144, 16);
            единицаИзмеренияLabel.TabIndex = 12;
            единицаИзмеренияLabel.Text = "Единица измерения:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 353);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Добавить запись о товаре.\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(317, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(единицаИзмеренияLabel);
            this.groupBox2.Controls.Add(кодТLabel);
            this.groupBox2.Controls.Add(this.единицаИзмеренияTextBox);
            this.groupBox2.Controls.Add(this.кодТTextBox);
            this.groupBox2.Controls.Add(кодРазделаLabel);
            this.groupBox2.Controls.Add(this.название_товараTextBox);
            this.groupBox2.Controls.Add(название_товараLabel);
            this.groupBox2.Controls.Add(кодПоставщикаLabel);
            this.groupBox2.Controls.Add(this.ценаTextBox);
            this.groupBox2.Controls.Add(ценаLabel);
            this.groupBox2.Controls.Add(количествоСкладLabel);
            this.groupBox2.Controls.Add(this.количествоСкладTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.товарыBindingSource, "КодРаздела", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталогТоваровBindingSource1, "Каталог", true));
            this.comboBox2.DataSource = this.каталогТоваровBindingSource2;
            this.comboBox2.DisplayMember = "Каталог";
            this.comboBox2.DropDownHeight = 180;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 200;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(177, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "КодР";
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталогТоваровBindingSource1
            // 
            this.каталогТоваровBindingSource1.DataMember = "КаталогТоваров";
            this.каталогТоваровBindingSource1.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // каталогТоваровBindingSource2
            // 
            this.каталогТоваровBindingSource2.DataMember = "КаталогТоваров";
            this.каталогТоваровBindingSource2.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.товарыBindingSource, "КодПоставщика", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Наименование организации", true));
            this.comboBox1.DataSource = this.поставщикиBindingSource;
            this.comboBox1.DisplayMember = "Наименование организации";
            this.comboBox1.DropDownHeight = 180;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 200;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(177, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "КодП";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // единицаИзмеренияTextBox
            // 
            this.единицаИзмеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "ЕдиницаИзмерения", true));
            this.единицаИзмеренияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.единицаИзмеренияTextBox.Location = new System.Drawing.Point(177, 191);
            this.единицаИзмеренияTextBox.Name = "единицаИзмеренияTextBox";
            this.единицаИзмеренияTextBox.Size = new System.Drawing.Size(222, 22);
            this.единицаИзмеренияTextBox.TabIndex = 13;
            this.единицаИзмеренияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.единицаИзмеренияTextBox_KeyPress);
            // 
            // кодТTextBox
            // 
            this.кодТTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "КодТ", true));
            this.кодТTextBox.Enabled = false;
            this.кодТTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодТTextBox.Location = new System.Drawing.Point(177, 19);
            this.кодТTextBox.Name = "кодТTextBox";
            this.кодТTextBox.Size = new System.Drawing.Size(222, 22);
            this.кодТTextBox.TabIndex = 1;
            // 
            // название_товараTextBox
            // 
            this.название_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Название товара", true));
            this.название_товараTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_товараTextBox.Location = new System.Drawing.Point(177, 47);
            this.название_товараTextBox.Name = "название_товараTextBox";
            this.название_товараTextBox.Size = new System.Drawing.Size(222, 22);
            this.название_товараTextBox.TabIndex = 3;
            this.название_товараTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.название_товараTextBox_KeyPress);
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Цена", true));
            this.ценаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ценаTextBox.Location = new System.Drawing.Point(177, 75);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(222, 22);
            this.ценаTextBox.TabIndex = 5;
            this.ценаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ценаTextBox_KeyPress);
            // 
            // количествоСкладTextBox
            // 
            this.количествоСкладTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "КоличествоСклад", true));
            this.количествоСкладTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоСкладTextBox.Location = new System.Drawing.Point(177, 103);
            this.количествоСкладTextBox.Name = "количествоСкладTextBox";
            this.количествоСкладTextBox.Size = new System.Drawing.Size(222, 22);
            this.количествоСкладTextBox.TabIndex = 7;
            this.количествоСкладTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.количествоСкладTextBox_KeyPress);
            // 
            // каталогТоваровBindingSource
            // 
            this.каталогТоваровBindingSource.DataMember = "КаталогТоваров";
            this.каталогТоваровBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СлужбаДоставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтатусЗаказаTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = null;
            // 
            // каталогТоваровTableAdapter
            // 
            this.каталогТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // каталогТоваровDataGridView
            // 
            this.каталогТоваровDataGridView.AutoGenerateColumns = false;
            this.каталогТоваровDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.каталогТоваровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.каталогТоваровDataGridView.DataSource = this.каталогТоваровBindingSource;
            this.каталогТоваровDataGridView.Location = new System.Drawing.Point(613, 38);
            this.каталогТоваровDataGridView.Name = "каталогТоваровDataGridView";
            this.каталогТоваровDataGridView.Size = new System.Drawing.Size(174, 72);
            this.каталогТоваровDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодР";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодР";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Каталог";
            this.dataGridViewTextBoxColumn2.HeaderText = "Каталог";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиDataGridView
            // 
            this.поставщикиDataGridView.AutoGenerateColumns = false;
            this.поставщикиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставщикиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.поставщикиDataGridView.DataSource = this.поставщикиBindingSource;
            this.поставщикиDataGridView.Location = new System.Drawing.Point(613, 116);
            this.поставщикиDataGridView.Name = "поставщикиDataGridView";
            this.поставщикиDataGridView.Size = new System.Drawing.Size(347, 86);
            this.поставщикиDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "КодП";
            this.dataGridViewTextBoxColumn3.HeaderText = "КодП";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование организации";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование организации";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "НомерДоговора";
            this.dataGridViewTextBoxColumn5.HeaderText = "НомерДоговора";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ДатаЗаключения";
            this.dataGridViewTextBoxColumn6.HeaderText = "ДатаЗаключения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ДатаОкончания";
            this.dataGridViewTextBoxColumn7.HeaderText = "ДатаОкончания";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Факс";
            this.dataGridViewTextBoxColumn8.HeaderText = "Факс";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn9.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn10.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // ТоварыФормаРаботы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.поставщикиDataGridView);
            this.Controls.Add(this.каталогТоваровDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ТоварыФормаРаботы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ТоварыФормаРаботы_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ТоварыФормаРаботы_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel1;
        private МеждугородняяПродажаТоваровDataSet междугородняяПродажаТоваровDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox единицаИзмеренияTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox название_товараTextBox;
        private System.Windows.Forms.TextBox кодТTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.КаталогТоваровTableAdapter каталогТоваровTableAdapter;
        private System.Windows.Forms.DataGridView каталогТоваровDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridView поставщикиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox количествоСкладTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource1;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource2;
    }
}