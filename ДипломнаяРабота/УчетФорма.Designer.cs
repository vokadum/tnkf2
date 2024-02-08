namespace ДипломнаяРабота
{
    partial class УчетФорма
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
            System.Windows.Forms.Label номерДокументаLabel;
            System.Windows.Forms.Label товарLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label общаяСтоимостьLabel;
            System.Windows.Forms.Label датаУчетаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(УчетФорма));
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.товарTextBox = new System.Windows.Forms.TextBox();
            this.учетПродажТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.междугородняяПродажаТоваровDataSet = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSet();
            this.датаУчетаTextBox = new System.Windows.Forms.TextBox();
            this.общаяСтоимостьTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.номерДокументаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.учетПродажТоваровTableAdapter = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.УчетПродажТоваровTableAdapter();
            this.tableAdapterManager = new ДипломнаяРабота.МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager();
            номерДокументаLabel = new System.Windows.Forms.Label();
            товарLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            общаяСтоимостьLabel = new System.Windows.Forms.Label();
            датаУчетаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учетПродажТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // номерДокументаLabel
            // 
            номерДокументаLabel.AutoSize = true;
            номерДокументаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерДокументаLabel.ForeColor = System.Drawing.Color.White;
            номерДокументаLabel.Location = new System.Drawing.Point(11, 22);
            номерДокументаLabel.Name = "номерДокументаLabel";
            номерДокументаLabel.Size = new System.Drawing.Size(128, 16);
            номерДокументаLabel.TabIndex = 0;
            номерДокументаLabel.Text = "Номер Документа:";
            // 
            // товарLabel
            // 
            товарLabel.AutoSize = true;
            товарLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            товарLabel.ForeColor = System.Drawing.Color.White;
            товарLabel.Location = new System.Drawing.Point(11, 48);
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
            количествоLabel.Location = new System.Drawing.Point(11, 78);
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
            ценаLabel.Location = new System.Drawing.Point(11, 106);
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
            общаяСтоимостьLabel.Location = new System.Drawing.Point(11, 134);
            общаяСтоимостьLabel.Name = "общаяСтоимостьLabel";
            общаяСтоимостьLabel.Size = new System.Drawing.Size(125, 16);
            общаяСтоимостьLabel.TabIndex = 8;
            общаяСтоимостьLabel.Text = "Общая Стоимость:";
            // 
            // датаУчетаLabel
            // 
            датаУчетаLabel.AutoSize = true;
            датаУчетаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаУчетаLabel.ForeColor = System.Drawing.Color.White;
            датаУчетаLabel.Location = new System.Drawing.Point(11, 162);
            датаУчетаLabel.Name = "датаУчетаLabel";
            датаУчетаLabel.Size = new System.Drawing.Size(85, 16);
            датаУчетаLabel.TabIndex = 10;
            датаУчетаLabel.Text = "Дата Учета:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 314);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.товарTextBox);
            this.groupBox1.Controls.Add(датаУчетаLabel);
            this.groupBox1.Controls.Add(this.датаУчетаTextBox);
            this.groupBox1.Controls.Add(общаяСтоимостьLabel);
            this.groupBox1.Controls.Add(this.общаяСтоимостьTextBox);
            this.groupBox1.Controls.Add(ценаLabel);
            this.groupBox1.Controls.Add(this.ценаTextBox);
            this.groupBox1.Controls.Add(количествоLabel);
            this.groupBox1.Controls.Add(this.количествоTextBox);
            this.groupBox1.Controls.Add(товарLabel);
            this.groupBox1.Controls.Add(номерДокументаLabel);
            this.groupBox1.Controls.Add(this.номерДокументаTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 201);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // товарTextBox
            // 
            this.товарTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "Товар", true));
            this.товарTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.товарTextBox.Location = new System.Drawing.Point(175, 47);
            this.товарTextBox.Name = "товарTextBox";
            this.товарTextBox.Size = new System.Drawing.Size(189, 22);
            this.товарTextBox.TabIndex = 12;
            // 
            // учетПродажТоваровBindingSource
            // 
            this.учетПродажТоваровBindingSource.DataMember = "УчетПродажТоваров";
            this.учетПродажТоваровBindingSource.DataSource = this.междугородняяПродажаТоваровDataSet;
            // 
            // междугородняяПродажаТоваровDataSet
            // 
            this.междугородняяПродажаТоваровDataSet.DataSetName = "МеждугородняяПродажаТоваровDataSet";
            this.междугородняяПродажаТоваровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаУчетаTextBox
            // 
            this.датаУчетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "ДатаУчета", true));
            this.датаУчетаTextBox.Enabled = false;
            this.датаУчетаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаУчетаTextBox.Location = new System.Drawing.Point(175, 159);
            this.датаУчетаTextBox.Name = "датаУчетаTextBox";
            this.датаУчетаTextBox.Size = new System.Drawing.Size(189, 22);
            this.датаУчетаTextBox.TabIndex = 11;
            // 
            // общаяСтоимостьTextBox
            // 
            this.общаяСтоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "ОбщаяСтоимость", true));
            this.общаяСтоимостьTextBox.Enabled = false;
            this.общаяСтоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.общаяСтоимостьTextBox.Location = new System.Drawing.Point(175, 131);
            this.общаяСтоимостьTextBox.Name = "общаяСтоимостьTextBox";
            this.общаяСтоимостьTextBox.Size = new System.Drawing.Size(189, 22);
            this.общаяСтоимостьTextBox.TabIndex = 9;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "Цена", true));
            this.ценаTextBox.Enabled = false;
            this.ценаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ценаTextBox.Location = new System.Drawing.Point(175, 103);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(189, 22);
            this.ценаTextBox.TabIndex = 7;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "Количество", true));
            this.количествоTextBox.Enabled = false;
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоTextBox.Location = new System.Drawing.Point(175, 75);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(189, 22);
            this.количествоTextBox.TabIndex = 5;
            // 
            // номерДокументаTextBox
            // 
            this.номерДокументаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетПродажТоваровBindingSource, "НомерДокумента", true));
            this.номерДокументаTextBox.Enabled = false;
            this.номерДокументаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерДокументаTextBox.Location = new System.Drawing.Point(175, 19);
            this.номерДокументаTextBox.Name = "номерДокументаTextBox";
            this.номерДокументаTextBox.Size = new System.Drawing.Size(189, 22);
            this.номерДокументаTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Информация о товаре";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(153, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // учетПродажТоваровTableAdapter
            // 
            this.учетПродажТоваровTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.УчетПродажТоваровTableAdapter = this.учетПродажТоваровTableAdapter;
            // 
            // УчетФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(407, 314);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "УчетФорма";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж товаров";
            this.Load += new System.EventHandler(this.УчетФорма_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учетПродажТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.междугородняяПродажаТоваровDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private МеждугородняяПродажаТоваровDataSet междугородняяПродажаТоваровDataSet;
        private System.Windows.Forms.BindingSource учетПродажТоваровBindingSource;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.УчетПродажТоваровTableAdapter учетПродажТоваровTableAdapter;
        private МеждугородняяПродажаТоваровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox датаУчетаTextBox;
        private System.Windows.Forms.TextBox общаяСтоимостьTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox номерДокументаTextBox;
        private System.Windows.Forms.TextBox товарTextBox;
    }
}