namespace ДипломнаяРабота
{
    partial class Товары
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Товары));
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            this.товарыDataGridView = new System.Windows.Forms.DataGridView();
            this.кодТDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСкладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодРазделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.каталогТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ob = new System.Windows.Forms.Button();
            this.Poisc = new System.Windows.Forms.Button();
            this.textBoxPoisc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Obn = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.textBox2Filtr = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.поставщикиTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter();
            this.каталогТоваровTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.КаталогТоваровTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RabotaSTable = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.RabotaSTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
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
            // товарыDataGridView
            // 
            this.товарыDataGridView.AutoGenerateColumns = false;
            this.товарыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.товарыDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.товарыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товарыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТDataGridViewTextBoxColumn,
            this.названиеТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоСкладDataGridViewTextBoxColumn,
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.кодРазделаDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn});
            this.товарыDataGridView.DataSource = this.товарыBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.товарыDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.товарыDataGridView.GridColor = System.Drawing.Color.Black;
            this.товарыDataGridView.Location = new System.Drawing.Point(29, 2);
            this.товарыDataGridView.Name = "товарыDataGridView";
            this.товарыDataGridView.ReadOnly = true;
            this.товарыDataGridView.Size = new System.Drawing.Size(860, 220);
            this.товарыDataGridView.TabIndex = 1;
            // 
            // кодТDataGridViewTextBoxColumn
            // 
            this.кодТDataGridViewTextBoxColumn.DataPropertyName = "КодТ";
            this.кодТDataGridViewTextBoxColumn.HeaderText = "КодТ";
            this.кодТDataGridViewTextBoxColumn.Name = "кодТDataGridViewTextBoxColumn";
            this.кодТDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеТовараDataGridViewTextBoxColumn
            // 
            this.названиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Название товара";
            this.названиеТовараDataGridViewTextBoxColumn.HeaderText = "Название товара";
            this.названиеТовараDataGridViewTextBoxColumn.Name = "названиеТовараDataGridViewTextBoxColumn";
            this.названиеТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоСкладDataGridViewTextBoxColumn
            // 
            this.количествоСкладDataGridViewTextBoxColumn.DataPropertyName = "КоличествоСклад";
            this.количествоСкладDataGridViewTextBoxColumn.HeaderText = "КоличествоСклад";
            this.количествоСкладDataGridViewTextBoxColumn.Name = "количествоСкладDataGridViewTextBoxColumn";
            this.количествоСкладDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.DataSource = this.поставщикиBindingSource;
            this.кодПоставщикаDataGridViewTextBoxColumn.DisplayMember = "Наименование организации";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "Поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПоставщикаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодПоставщикаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодПоставщикаDataGridViewTextBoxColumn.ValueMember = "КодП";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // кодРазделаDataGridViewTextBoxColumn
            // 
            this.кодРазделаDataGridViewTextBoxColumn.DataPropertyName = "КодРаздела";
            this.кодРазделаDataGridViewTextBoxColumn.DataSource = this.каталогТоваровBindingSource;
            this.кодРазделаDataGridViewTextBoxColumn.DisplayMember = "Каталог";
            this.кодРазделаDataGridViewTextBoxColumn.HeaderText = "Раздела";
            this.кодРазделаDataGridViewTextBoxColumn.Name = "кодРазделаDataGridViewTextBoxColumn";
            this.кодРазделаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодРазделаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодРазделаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодРазделаDataGridViewTextBoxColumn.ValueMember = "КодР";
            // 
            // каталогТоваровBindingSource
            // 
            this.каталогТоваровBindingSource.DataMember = "КаталогТоваров";
            this.каталогТоваровBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            this.единицаИзмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ob);
            this.groupBox1.Controls.Add(this.Poisc);
            this.groupBox1.Controls.Add(this.textBoxPoisc);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(660, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите данные поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите критирий поиска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск данных.";
            // 
            // Ob
            // 
            this.Ob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Ob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ob.Location = new System.Drawing.Point(103, 164);
            this.Ob.Name = "Ob";
            this.Ob.Size = new System.Drawing.Size(91, 23);
            this.Ob.TabIndex = 3;
            this.Ob.Text = "Очистить";
            this.Ob.UseVisualStyleBackColor = false;
            this.Ob.Click += new System.EventHandler(this.Ob_Click);
            this.Ob.MouseLeave += new System.EventHandler(this.Ob_MouseLeave);
            this.Ob.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ob_MouseMove);
            // 
            // Poisc
            // 
            this.Poisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.Poisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Poisc.Location = new System.Drawing.Point(22, 164);
            this.Poisc.Name = "Poisc";
            this.Poisc.Size = new System.Drawing.Size(75, 23);
            this.Poisc.TabIndex = 2;
            this.Poisc.Text = "Поиск";
            this.Poisc.UseVisualStyleBackColor = false;
            this.Poisc.Click += new System.EventHandler(this.Poisc_Click);
            this.Poisc.MouseLeave += new System.EventHandler(this.Poisc_MouseLeave);
            this.Poisc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Poisc_MouseMove);
            // 
            // textBoxPoisc
            // 
            this.textBoxPoisc.Location = new System.Drawing.Point(22, 121);
            this.textBoxPoisc.Name = "textBoxPoisc";
            this.textBoxPoisc.Size = new System.Drawing.Size(160, 20);
            this.textBoxPoisc.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название товара",
            "ЕдиницаИзмерения",
            "КодТ",
            "Цена"});
            this.comboBox1.Location = new System.Drawing.Point(22, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Obn);
            this.groupBox2.Controls.Add(this.Filtr);
            this.groupBox2.Controls.Add(this.textBox2Filtr);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(415, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите данные поиска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберите критирий поиска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Фильтрация данных.";
            // 
            // Obn
            // 
            this.Obn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Obn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Obn.Location = new System.Drawing.Point(114, 164);
            this.Obn.Name = "Obn";
            this.Obn.Size = new System.Drawing.Size(82, 23);
            this.Obn.TabIndex = 3;
            this.Obn.Text = "Очистить";
            this.Obn.UseVisualStyleBackColor = false;
            this.Obn.Click += new System.EventHandler(this.Obn_Click);
            this.Obn.MouseLeave += new System.EventHandler(this.Obn_MouseLeave);
            this.Obn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Obn_MouseMove);
            // 
            // Filtr
            // 
            this.Filtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.Filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filtr.Location = new System.Drawing.Point(5, 164);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(106, 23);
            this.Filtr.TabIndex = 2;
            this.Filtr.Text = "Фильтрация";
            this.Filtr.UseVisualStyleBackColor = false;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            this.Filtr.MouseLeave += new System.EventHandler(this.Filtr_MouseLeave);
            this.Filtr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Filtr_MouseMove);
            // 
            // textBox2Filtr
            // 
            this.textBox2Filtr.Location = new System.Drawing.Point(19, 121);
            this.textBox2Filtr.Name = "textBox2Filtr";
            this.textBox2Filtr.Size = new System.Drawing.Size(165, 20);
            this.textBox2Filtr.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Название товара",
            "ЕдиницаИзмерения"});
            this.comboBox2.Location = new System.Drawing.Point(19, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(41, 134);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(228, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            this.Delete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseMove);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(41, 105);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(228, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Редактировать";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            this.Update.MouseLeave += new System.EventHandler(this.Update_MouseLeave);
            this.Update.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Update_MouseMove);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(41, 76);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(228, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
            this.Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Add_MouseMove);
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // каталогТоваровTableAdapter
            // 
            this.каталогТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.вернутьсяНаГлавнуюToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 92);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вернутьсяНаГлавнуюToolStripMenuItem
            // 
            this.вернутьсяНаГлавнуюToolStripMenuItem.Name = "вернутьсяНаГлавнуюToolStripMenuItem";
            this.вернутьсяНаГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.вернутьсяНаГлавнуюToolStripMenuItem.Text = "Вернуться на главную";
            this.вернутьсяНаГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюToolStripMenuItem_Click);
            // 
            // RabotaSTable
            // 
            this.RabotaSTable.Controls.Add(this.label7);
            this.RabotaSTable.Controls.Add(this.Add);
            this.RabotaSTable.Controls.Add(this.Delete);
            this.RabotaSTable.Controls.Add(this.Update);
            this.RabotaSTable.Location = new System.Drawing.Point(29, 228);
            this.RabotaSTable.Name = "RabotaSTable";
            this.RabotaSTable.Size = new System.Drawing.Size(305, 199);
            this.RabotaSTable.TabIndex = 11;
            this.RabotaSTable.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Панель работы с таблицей";
            // 
            // Товары
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.RabotaSTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.товарыDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Товары";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Товары_Load);
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогТоваровBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.RabotaSTable.ResumeLayout(false);
            this.RabotaSTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private МеждугородняяПродажаТоваровDataSet междугородняяПродажаТоваровDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView товарыDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ob;
        private System.Windows.Forms.Button Poisc;
        private System.Windows.Forms.TextBox textBoxPoisc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Obn;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.TextBox textBox2Filtr;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource каталогТоваровBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.КаталогТоваровTableAdapter каталогТоваровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСкладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодРазделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюToolStripMenuItem;
        private System.Windows.Forms.GroupBox RabotaSTable;
        private System.Windows.Forms.Label label7;
    }
}