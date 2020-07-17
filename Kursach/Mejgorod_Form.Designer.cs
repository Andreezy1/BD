namespace Kursach
{
    partial class Mejgorod_Form
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
            System.Windows.Forms.Label kod_mejgorodLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label tarifLabel;
            this.aTSDataSet = new Kursach.ATSDataSet();
            this.tarifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifTableAdapter = new Kursach.ATSDataSetTableAdapters.TarifTableAdapter();
            this.tableAdapterManager = new Kursach.ATSDataSetTableAdapters.TableAdapterManager();
            this.tarifDataGridView = new System.Windows.Forms.DataGridView();
            this.kod_mejgorodTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.tarifTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            kod_mejgorodLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            tarifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kod_mejgorodLabel
            // 
            kod_mejgorodLabel.AutoSize = true;
            kod_mejgorodLabel.Location = new System.Drawing.Point(6, 12);
            kod_mejgorodLabel.Name = "kod_mejgorodLabel";
            kod_mejgorodLabel.Size = new System.Drawing.Size(114, 13);
            kod_mejgorodLabel.TabIndex = 2;
            kod_mejgorodLabel.Text = "Междугородный код:";
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(6, 38);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(40, 13);
            gorodLabel.TabIndex = 4;
            gorodLabel.Text = "Город:";
            // 
            // tarifLabel
            // 
            tarifLabel.AutoSize = true;
            tarifLabel.Location = new System.Drawing.Point(6, 64);
            tarifLabel.Name = "tarifLabel";
            tarifLabel.Size = new System.Drawing.Size(65, 13);
            tarifLabel.TabIndex = 6;
            tarifLabel.Text = "Стоимость:";
            // 
            // aTSDataSet
            // 
            this.aTSDataSet.DataSetName = "ATSDataSet";
            this.aTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifBindingSource
            // 
            this.tarifBindingSource.DataMember = "Tarif";
            this.tarifBindingSource.DataSource = this.aTSDataSet;
            // 
            // tarifTableAdapter
            // 
            this.tarifTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TarifTableAdapter = this.tarifTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursach.ATSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZvonkiTableAdapter = null;
            // 
            // tarifDataGridView
            // 
            this.tarifDataGridView.AutoGenerateColumns = false;
            this.tarifDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tarifDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarifDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tarifDataGridView.DataSource = this.tarifBindingSource;
            this.tarifDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarifDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tarifDataGridView.Name = "tarifDataGridView";
            this.tarifDataGridView.ReadOnly = true;
            this.tarifDataGridView.Size = new System.Drawing.Size(474, 450);
            this.tarifDataGridView.TabIndex = 1;
            this.tarifDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.tarifDataGridView_UserDeletingRow);
            // 
            // kod_mejgorodTextBox
            // 
            this.kod_mejgorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifBindingSource, "Kod_mejgorod", true));
            this.kod_mejgorodTextBox.Location = new System.Drawing.Point(126, 9);
            this.kod_mejgorodTextBox.Name = "kod_mejgorodTextBox";
            this.kod_mejgorodTextBox.Size = new System.Drawing.Size(100, 20);
            this.kod_mejgorodTextBox.TabIndex = 3;
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifBindingSource, "Gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(126, 35);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(100, 20);
            this.gorodTextBox.TabIndex = 5;
            // 
            // tarifTextBox
            // 
            this.tarifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarifBindingSource, "Tarif", true));
            this.tarifTextBox.Location = new System.Drawing.Point(126, 61);
            this.tarifTextBox.Name = "tarifTextBox";
            this.tarifTextBox.Size = new System.Drawing.Size(100, 20);
            this.tarifTextBox.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(480, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 124);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(kod_mejgorodLabel);
            this.tabPage1.Controls.Add(this.tarifTextBox);
            this.tabPage1.Controls.Add(this.kod_mejgorodTextBox);
            this.tabPage1.Controls.Add(tarifLabel);
            this.tabPage1.Controls.Add(gorodLabel);
            this.tabPage1.Controls.Add(this.gorodTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 98);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 98);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите столбец";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Междугородный код",
            "Город"});
            this.comboBox1.Location = new System.Drawing.Point(9, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Междугородный код";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(257, 98);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редактирование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Редактировать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kod_mejgorod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Междугородный код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn2.HeaderText = "Город";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tarif";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость за 1 мин. (Руб)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Mejgorod_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tarifDataGridView);
            this.Name = "Mejgorod_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Междугородные тарифы";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ATSDataSet aTSDataSet;
        private System.Windows.Forms.BindingSource tarifBindingSource;
        private ATSDataSetTableAdapters.TarifTableAdapter tarifTableAdapter;
        private ATSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tarifDataGridView;
        private System.Windows.Forms.TextBox kod_mejgorodTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox tarifTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}