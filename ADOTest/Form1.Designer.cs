namespace ADOTest
{
    partial class Form1
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
            System.Windows.Forms.Label кодЗаказаLabel;
            System.Windows.Forms.Label кодРаботыLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label кодПредметаLabel;
            System.Windows.Forms.Label количествоЗадачLabel;
            System.Windows.Forms.Label вариантLabel;
            System.Windows.Forms.Label кодВидаLabel;
            System.Windows.Forms.Label кодВузаLabel;
            System.Windows.Forms.Label кодЗаказчикаLabel;
            System.Windows.Forms.Label номерЗаказаLabel;
            System.Windows.Forms.Label датаПринятияLabel;
            System.Windows.Forms.Label датаСдачиLabel;
            this.заказыDataSet = new ADOTest.ЗаказыDataSet();
            this.заказыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вузыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вузыTableAdapter = new ADOTest.ЗаказыDataSetTableAdapters.ВузыTableAdapter();
            this.вузыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new ADOTest.ЗаказыDataSetTableAdapters.ЗаказыTableAdapter();
            this.кодЗаказаTextBox = new System.Windows.Forms.TextBox();
            this.кодРаботыTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.кодПредметаTextBox = new System.Windows.Forms.TextBox();
            this.количествоЗадачTextBox = new System.Windows.Forms.TextBox();
            this.вариантTextBox = new System.Windows.Forms.TextBox();
            this.кодВидаTextBox = new System.Windows.Forms.TextBox();
            this.кодВузаTextBox = new System.Windows.Forms.TextBox();
            this.кодЗаказчикаTextBox = new System.Windows.Forms.TextBox();
            this.номерЗаказаTextBox = new System.Windows.Forms.TextBox();
            this.датаПринятияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаСдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            кодЗаказаLabel = new System.Windows.Forms.Label();
            кодРаботыLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            кодПредметаLabel = new System.Windows.Forms.Label();
            количествоЗадачLabel = new System.Windows.Forms.Label();
            вариантLabel = new System.Windows.Forms.Label();
            кодВидаLabel = new System.Windows.Forms.Label();
            кодВузаLabel = new System.Windows.Forms.Label();
            кодЗаказчикаLabel = new System.Windows.Forms.Label();
            номерЗаказаLabel = new System.Windows.Forms.Label();
            датаПринятияLabel = new System.Windows.Forms.Label();
            датаСдачиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вузыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вузыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыDataSetBindingSource
            // 
            this.заказыDataSetBindingSource.DataSource = this.заказыDataSet;
            this.заказыDataSetBindingSource.Position = 0;
            // 
            // вузыBindingSource
            // 
            this.вузыBindingSource.DataMember = "Вузы";
            this.вузыBindingSource.DataSource = this.заказыDataSet;
            // 
            // вузыTableAdapter
            // 
            this.вузыTableAdapter.ClearBeforeFill = true;
            // 
            // вузыDataGridView
            // 
            this.вузыDataGridView.AutoGenerateColumns = false;
            this.вузыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.вузыDataGridView.DataSource = this.вузыBindingSource;
            this.вузыDataGridView.Location = new System.Drawing.Point(334, 10);
            this.вузыDataGridView.Name = "вузыDataGridView";
            this.вузыDataGridView.Size = new System.Drawing.Size(308, 307);
            this.вузыDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодВуза";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодВуза";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вуз";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вуз";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "ВузыЗаказы";
            this.заказыBindingSource.DataSource = this.вузыBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // кодЗаказаLabel
            // 
            кодЗаказаLabel.AutoSize = true;
            кодЗаказаLabel.Location = new System.Drawing.Point(9, 14);
            кодЗаказаLabel.Name = "кодЗаказаLabel";
            кодЗаказаLabel.Size = new System.Drawing.Size(69, 13);
            кодЗаказаLabel.TabIndex = 24;
            кодЗаказаLabel.Text = "Код Заказа:";
            // 
            // кодЗаказаTextBox
            // 
            this.кодЗаказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодЗаказа", true));
            this.кодЗаказаTextBox.Location = new System.Drawing.Point(117, 11);
            this.кодЗаказаTextBox.Name = "кодЗаказаTextBox";
            this.кодЗаказаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодЗаказаTextBox.TabIndex = 25;
            // 
            // кодРаботыLabel
            // 
            кодРаботыLabel.AutoSize = true;
            кодРаботыLabel.Location = new System.Drawing.Point(9, 40);
            кодРаботыLabel.Name = "кодРаботыLabel";
            кодРаботыLabel.Size = new System.Drawing.Size(70, 13);
            кодРаботыLabel.TabIndex = 26;
            кодРаботыLabel.Text = "Код Работы:";
            // 
            // кодРаботыTextBox
            // 
            this.кодРаботыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодРаботы", true));
            this.кодРаботыTextBox.Location = new System.Drawing.Point(117, 37);
            this.кодРаботыTextBox.Name = "кодРаботыTextBox";
            this.кодРаботыTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодРаботыTextBox.TabIndex = 27;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(9, 66);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 28;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(117, 63);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 20);
            this.ценаTextBox.TabIndex = 29;
            // 
            // кодПредметаLabel
            // 
            кодПредметаLabel.AutoSize = true;
            кодПредметаLabel.Location = new System.Drawing.Point(9, 92);
            кодПредметаLabel.Name = "кодПредметаLabel";
            кодПредметаLabel.Size = new System.Drawing.Size(83, 13);
            кодПредметаLabel.TabIndex = 30;
            кодПредметаLabel.Text = "Код Предмета:";
            // 
            // кодПредметаTextBox
            // 
            this.кодПредметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодПредмета", true));
            this.кодПредметаTextBox.Location = new System.Drawing.Point(117, 89);
            this.кодПредметаTextBox.Name = "кодПредметаTextBox";
            this.кодПредметаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодПредметаTextBox.TabIndex = 31;
            // 
            // количествоЗадачLabel
            // 
            количествоЗадачLabel.AutoSize = true;
            количествоЗадачLabel.Location = new System.Drawing.Point(9, 118);
            количествоЗадачLabel.Name = "количествоЗадачLabel";
            количествоЗадачLabel.Size = new System.Drawing.Size(102, 13);
            количествоЗадачLabel.TabIndex = 32;
            количествоЗадачLabel.Text = "Количество Задач:";
            // 
            // количествоЗадачTextBox
            // 
            this.количествоЗадачTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КоличествоЗадач", true));
            this.количествоЗадачTextBox.Location = new System.Drawing.Point(117, 115);
            this.количествоЗадачTextBox.Name = "количествоЗадачTextBox";
            this.количествоЗадачTextBox.Size = new System.Drawing.Size(200, 20);
            this.количествоЗадачTextBox.TabIndex = 33;
            // 
            // вариантLabel
            // 
            вариантLabel.AutoSize = true;
            вариантLabel.Location = new System.Drawing.Point(9, 144);
            вариантLabel.Name = "вариантLabel";
            вариантLabel.Size = new System.Drawing.Size(52, 13);
            вариантLabel.TabIndex = 34;
            вариантLabel.Text = "Вариант:";
            // 
            // вариантTextBox
            // 
            this.вариантTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Вариант", true));
            this.вариантTextBox.Location = new System.Drawing.Point(117, 141);
            this.вариантTextBox.Name = "вариантTextBox";
            this.вариантTextBox.Size = new System.Drawing.Size(200, 20);
            this.вариантTextBox.TabIndex = 35;
            // 
            // кодВидаLabel
            // 
            кодВидаLabel.AutoSize = true;
            кодВидаLabel.Location = new System.Drawing.Point(9, 170);
            кодВидаLabel.Name = "кодВидаLabel";
            кодВидаLabel.Size = new System.Drawing.Size(57, 13);
            кодВидаLabel.TabIndex = 36;
            кодВидаLabel.Text = "Код Вида:";
            // 
            // кодВидаTextBox
            // 
            this.кодВидаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодВида", true));
            this.кодВидаTextBox.Location = new System.Drawing.Point(117, 167);
            this.кодВидаTextBox.Name = "кодВидаTextBox";
            this.кодВидаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодВидаTextBox.TabIndex = 37;
            // 
            // кодВузаLabel
            // 
            кодВузаLabel.AutoSize = true;
            кодВузаLabel.Location = new System.Drawing.Point(9, 196);
            кодВузаLabel.Name = "кодВузаLabel";
            кодВузаLabel.Size = new System.Drawing.Size(56, 13);
            кодВузаLabel.TabIndex = 38;
            кодВузаLabel.Text = "Код Вуза:";
            // 
            // кодВузаTextBox
            // 
            this.кодВузаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодВуза", true));
            this.кодВузаTextBox.Location = new System.Drawing.Point(117, 193);
            this.кодВузаTextBox.Name = "кодВузаTextBox";
            this.кодВузаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодВузаTextBox.TabIndex = 39;
            // 
            // кодЗаказчикаLabel
            // 
            кодЗаказчикаLabel.AutoSize = true;
            кодЗаказчикаLabel.Location = new System.Drawing.Point(9, 222);
            кодЗаказчикаLabel.Name = "кодЗаказчикаLabel";
            кодЗаказчикаLabel.Size = new System.Drawing.Size(86, 13);
            кодЗаказчикаLabel.TabIndex = 40;
            кодЗаказчикаLabel.Text = "Код Заказчика:";
            // 
            // кодЗаказчикаTextBox
            // 
            this.кодЗаказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодЗаказчика", true));
            this.кодЗаказчикаTextBox.Location = new System.Drawing.Point(117, 219);
            this.кодЗаказчикаTextBox.Name = "кодЗаказчикаTextBox";
            this.кодЗаказчикаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодЗаказчикаTextBox.TabIndex = 41;
            // 
            // номерЗаказаLabel
            // 
            номерЗаказаLabel.AutoSize = true;
            номерЗаказаLabel.Location = new System.Drawing.Point(9, 248);
            номерЗаказаLabel.Name = "номерЗаказаLabel";
            номерЗаказаLabel.Size = new System.Drawing.Size(84, 13);
            номерЗаказаLabel.TabIndex = 42;
            номерЗаказаLabel.Text = "Номер Заказа:";
            // 
            // номерЗаказаTextBox
            // 
            this.номерЗаказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "НомерЗаказа", true));
            this.номерЗаказаTextBox.Location = new System.Drawing.Point(117, 245);
            this.номерЗаказаTextBox.Name = "номерЗаказаTextBox";
            this.номерЗаказаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номерЗаказаTextBox.TabIndex = 43;
            // 
            // датаПринятияLabel
            // 
            датаПринятияLabel.AutoSize = true;
            датаПринятияLabel.Location = new System.Drawing.Point(9, 275);
            датаПринятияLabel.Name = "датаПринятияLabel";
            датаПринятияLabel.Size = new System.Drawing.Size(88, 13);
            датаПринятияLabel.TabIndex = 44;
            датаПринятияLabel.Text = "Дата Принятия:";
            // 
            // датаПринятияDateTimePicker
            // 
            this.датаПринятияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаПринятия", true));
            this.датаПринятияDateTimePicker.Location = new System.Drawing.Point(117, 271);
            this.датаПринятияDateTimePicker.Name = "датаПринятияDateTimePicker";
            this.датаПринятияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаПринятияDateTimePicker.TabIndex = 45;
            // 
            // датаСдачиLabel
            // 
            датаСдачиLabel.AutoSize = true;
            датаСдачиLabel.Location = new System.Drawing.Point(9, 301);
            датаСдачиLabel.Name = "датаСдачиLabel";
            датаСдачиLabel.Size = new System.Drawing.Size(69, 13);
            датаСдачиLabel.TabIndex = 46;
            датаСдачиLabel.Text = "Дата Сдачи:";
            // 
            // датаСдачиDateTimePicker
            // 
            this.датаСдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаСдачи", true));
            this.датаСдачиDateTimePicker.Location = new System.Drawing.Point(117, 297);
            this.датаСдачиDateTimePicker.Name = "датаСдачиDateTimePicker";
            this.датаСдачиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаСдачиDateTimePicker.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 336);
            this.Controls.Add(кодЗаказаLabel);
            this.Controls.Add(this.кодЗаказаTextBox);
            this.Controls.Add(кодРаботыLabel);
            this.Controls.Add(this.кодРаботыTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(кодПредметаLabel);
            this.Controls.Add(this.кодПредметаTextBox);
            this.Controls.Add(количествоЗадачLabel);
            this.Controls.Add(this.количествоЗадачTextBox);
            this.Controls.Add(вариантLabel);
            this.Controls.Add(this.вариантTextBox);
            this.Controls.Add(кодВидаLabel);
            this.Controls.Add(this.кодВидаTextBox);
            this.Controls.Add(кодВузаLabel);
            this.Controls.Add(this.кодВузаTextBox);
            this.Controls.Add(кодЗаказчикаLabel);
            this.Controls.Add(this.кодЗаказчикаTextBox);
            this.Controls.Add(номерЗаказаLabel);
            this.Controls.Add(this.номерЗаказаTextBox);
            this.Controls.Add(датаПринятияLabel);
            this.Controls.Add(this.датаПринятияDateTimePicker);
            this.Controls.Add(датаСдачиLabel);
            this.Controls.Add(this.датаСдачиDateTimePicker);
            this.Controls.Add(this.вузыDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вузыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вузыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource заказыDataSetBindingSource;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource вузыBindingSource;
        private ADOTest.ЗаказыDataSetTableAdapters.ВузыTableAdapter вузыTableAdapter;
        private System.Windows.Forms.DataGridView вузыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private ADOTest.ЗаказыDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.TextBox кодЗаказаTextBox;
        private System.Windows.Forms.TextBox кодРаботыTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox кодПредметаTextBox;
        private System.Windows.Forms.TextBox количествоЗадачTextBox;
        private System.Windows.Forms.TextBox вариантTextBox;
        private System.Windows.Forms.TextBox кодВидаTextBox;
        private System.Windows.Forms.TextBox кодВузаTextBox;
        private System.Windows.Forms.TextBox кодЗаказчикаTextBox;
        private System.Windows.Forms.TextBox номерЗаказаTextBox;
        private System.Windows.Forms.DateTimePicker датаПринятияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаСдачиDateTimePicker;
    }
}

