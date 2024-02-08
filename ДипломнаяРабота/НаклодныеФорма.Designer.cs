namespace ДипломнаяРабота
{
    partial class НаклодныеФорма
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
            System.Windows.Forms.Label товарLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label общаяСтоимостьLabel;
            System.Windows.Forms.Label датаПоступлениеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(НаклодныеФорма));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.приклоднаяНаклоднаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаПоступлениеTextBox = new System.Windows.Forms.TextBox();
            this.общаяСтоимостьTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.товарTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.приклоднаяНаклоднаяTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ПриклоднаяНаклоднаяTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            this.товарыTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter();
            кодLabel = new System.Windows.Forms.Label();
            товарLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            общаяСтоимостьLabel = new System.Windows.Forms.Label();
            датаПоступлениеLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.приклоднаяНаклоднаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.ForeColor = System.Drawing.Color.White;
            кодLabel.Location = new System.Drawing.Point(16, 22);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(34, 16);
            кодLabel.TabIndex = 0;
            кодLabel.Text = "Код:";
            // 
            // товарLabel
            // 
            товарLabel.AutoSize = true;
            товарLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            товарLabel.ForeColor = System.Drawing.Color.White;
            товарLabel.Location = new System.Drawing.Point(16, 50);
            товарLabel.Name = "товарLabel";
            товарLabel.Size = new System.Drawing.Size(51, 16);
            товарLabel.TabIndex = 2;
            товарLabel.Text = "Товар:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количествоLabel.ForeColor = System.Drawing.Color.White;
            количествоLabel.Location = new System.Drawing.Point(16, 78);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(88, 16);
            количествоLabel.TabIndex = 4;
            количествоLabel.Text = "Количество:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ценаLabel.ForeColor = System.Drawing.Color.White;
            ценаLabel.Location = new System.Drawing.Point(16, 106);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 6;
            ценаLabel.Text = "Цена:";
            // 
            // общаяСтоимостьLabel
            // 
            общаяСтоимостьLabel.AutoSize = true;
            общаяСтоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            общаяСтоимостьLabel.ForeColor = System.Drawing.Color.White;
            общаяСтоимостьLabel.Location = new System.Drawing.Point(16, 134);
            общаяСтоимостьLabel.Name = "общаяСтоимостьLabel";
            общаяСтоимостьLabel.Size = new System.Drawing.Size(125, 16);
            общаяСтоимостьLabel.TabIndex = 8;
            общаяСтоимостьLabel.Text = "Общая Стоимость:";
            // 
            // датаПоступлениеLabel
            // 
            датаПоступлениеLabel.AutoSize = true;
            датаПоступлениеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаПоступлениеLabel.ForeColor = System.Drawing.Color.White;
            датаПоступлениеLabel.Location = new System.Drawing.Point(16, 162);
            датаПоступлениеLabel.Name = "датаПоступлениеLabel";
            датаПоступлениеLabel.Size = new System.Drawing.Size(133, 16);
            датаПоступлениеLabel.TabIndex = 10;
            датаПоступлениеLabel.Text = "Дата Поступление:";
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
            this.panel1.Size = new System.Drawing.Size(404, 291);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(датаПоступлениеLabel);
            this.groupBox1.Controls.Add(this.датаПоступлениеTextBox);
            this.groupBox1.Controls.Add(общаяСтоимостьLabel);
            this.groupBox1.Controls.Add(this.общаяСтоимостьTextBox);
            this.groupBox1.Controls.Add(ценаLabel);
            this.groupBox1.Controls.Add(this.ценаTextBox);
            this.groupBox1.Controls.Add(количествоLabel);
            this.groupBox1.Controls.Add(this.количествоTextBox);
            this.groupBox1.Controls.Add(товарLabel);
            this.groupBox1.Controls.Add(this.товарTextBox);
            this.groupBox1.Controls.Add(кодLabel);
            this.groupBox1.Controls.Add(this.кодTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 195);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.приклоднаяНаклоднаяBindingSource, "Товар", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Название товара", true));
            this.comboBox1.DataSource = this.товарыBindingSource;
            this.comboBox1.DisplayMember = "Название товара";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Название товара";
            // 
            // приклоднаяНаклоднаяBindingSource
            // 
            this.приклоднаяНаклоднаяBindingSource.DataMember = "ПриклоднаяНаклодная";
            this.приклоднаяНаклоднаяBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
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
            // датаПоступлениеTextBox
            // 
            this.датаПоступлениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "ДатаПоступление", true));
            this.датаПоступлениеTextBox.Enabled = false;
            this.датаПоступлениеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаПоступлениеTextBox.Location = new System.Drawing.Point(190, 159);
            this.датаПоступлениеTextBox.Name = "датаПоступлениеTextBox";
            this.датаПоступлениеTextBox.Size = new System.Drawing.Size(189, 22);
            this.датаПоступлениеTextBox.TabIndex = 11;
            // 
            // общаяСтоимостьTextBox
            // 
            this.общаяСтоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "ОбщаяСтоимость", true));
            this.общаяСтоимостьTextBox.Enabled = false;
            this.общаяСтоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.общаяСтоимостьTextBox.Location = new System.Drawing.Point(190, 131);
            this.общаяСтоимостьTextBox.Name = "общаяСтоимостьTextBox";
            this.общаяСтоимостьTextBox.Size = new System.Drawing.Size(189, 22);
            this.общаяСтоимостьTextBox.TabIndex = 9;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "Цена", true));
            this.ценаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ценаTextBox.Location = new System.Drawing.Point(190, 103);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(189, 22);
            this.ценаTextBox.TabIndex = 7;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоTextBox.Location = new System.Drawing.Point(190, 75);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(189, 22);
            this.количествоTextBox.TabIndex = 5;
            // 
            // товарTextBox
            // 
            this.товарTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "Товар", true));
            this.товарTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.товарTextBox.Location = new System.Drawing.Point(190, 47);
            this.товарTextBox.Name = "товарTextBox";
            this.товарTextBox.Size = new System.Drawing.Size(189, 22);
            this.товарTextBox.TabIndex = 3;
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приклоднаяНаклоднаяBindingSource, "Код", true));
            this.кодTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодTextBox.Location = new System.Drawing.Point(190, 19);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(189, 22);
            this.кодTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Добавить запись о заказе";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(253, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 32);
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
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // приклоднаяНаклоднаяTableAdapter
            // 
            this.приклоднаяНаклоднаяTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПриклоднаяНаклоднаяTableAdapter = this.приклоднаяНаклоднаяTableAdapter;
            this.tableAdapterManager.Расчет_зарплатыTableAdapter = null;
            this.tableAdapterManager.СлужбаДоставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтатусЗаказаTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = null;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // НаклодныеФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "НаклодныеФорма";
            this.Text = "Приклодная накладная";
            this.Load += new System.EventHandler(this.НаклодныеФорма_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.приклоднаяНаклоднаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private МеждугородняяПродажаТоваровDataSet междугородняяПродажаТоваровDataSet;
        private System.Windows.Forms.BindingSource приклоднаяНаклоднаяBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ПриклоднаяНаклоднаяTableAdapter приклоднаяНаклоднаяTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox датаПоступлениеTextBox;
        private System.Windows.Forms.TextBox общаяСтоимостьTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox товарTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.BindingSource товарыBindingSource;
    }
}