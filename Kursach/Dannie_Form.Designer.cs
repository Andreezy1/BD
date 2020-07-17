namespace Kursach
{
    partial class Dannie_Form
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
            System.Windows.Forms.Label nomerLabel;
            System.Windows.Forms.Label kategoriyaLabel;
            this.aTSDataSet = new Kursach.ATSDataSet();
            this.abonentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentTableAdapter = new Kursach.ATSDataSetTableAdapters.AbonentTableAdapter();
            this.tableAdapterManager = new Kursach.ATSDataSetTableAdapters.TableAdapterManager();
            this.abonentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerTextBox = new System.Windows.Forms.TextBox();
            this.kategoriyaTextBox = new System.Windows.Forms.TextBox();
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
            nomerLabel = new System.Windows.Forms.Label();
            kategoriyaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomerLabel
            // 
            nomerLabel.AutoSize = true;
            nomerLabel.Location = new System.Drawing.Point(6, 13);
            nomerLabel.Name = "nomerLabel";
            nomerLabel.Size = new System.Drawing.Size(94, 13);
            nomerLabel.TabIndex = 1;
            nomerLabel.Text = "Номер абонента:";
            // 
            // kategoriyaLabel
            // 
            kategoriyaLabel.AutoSize = true;
            kategoriyaLabel.Location = new System.Drawing.Point(6, 39);
            kategoriyaLabel.Name = "kategoriyaLabel";
            kategoriyaLabel.Size = new System.Drawing.Size(63, 13);
            kategoriyaLabel.TabIndex = 3;
            kategoriyaLabel.Text = "Категория:";
            // 
            // aTSDataSet
            // 
            this.aTSDataSet.DataSetName = "ATSDataSet";
            this.aTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonentBindingSource
            // 
            this.abonentBindingSource.DataMember = "Abonent";
            this.abonentBindingSource.DataSource = this.aTSDataSet;
            // 
            // abonentTableAdapter
            // 
            this.abonentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonentTableAdapter = this.abonentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TarifTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kursach.ATSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZvonkiTableAdapter = null;
            // 
            // abonentDataGridView
            // 
            this.abonentDataGridView.AutoGenerateColumns = false;
            this.abonentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abonentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.abonentDataGridView.DataSource = this.abonentBindingSource;
            this.abonentDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.abonentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.abonentDataGridView.Name = "abonentDataGridView";
            this.abonentDataGridView.ReadOnly = true;
            this.abonentDataGridView.Size = new System.Drawing.Size(382, 450);
            this.abonentDataGridView.TabIndex = 1;
            this.abonentDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.abonentDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер абонента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kategoriya";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nomerTextBox
            // 
            this.nomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentBindingSource, "Nomer", true));
            this.nomerTextBox.Location = new System.Drawing.Point(104, 10);
            this.nomerTextBox.Name = "nomerTextBox";
            this.nomerTextBox.Size = new System.Drawing.Size(140, 20);
            this.nomerTextBox.TabIndex = 2;
            // 
            // kategoriyaTextBox
            // 
            this.kategoriyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonentBindingSource, "Kategoriya", true));
            this.kategoriyaTextBox.Location = new System.Drawing.Point(104, 36);
            this.kategoriyaTextBox.Name = "kategoriyaTextBox";
            this.kategoriyaTextBox.Size = new System.Drawing.Size(140, 20);
            this.kategoriyaTextBox.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(402, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 117);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(nomerLabel);
            this.tabPage1.Controls.Add(this.kategoriyaTextBox);
            this.tabPage1.Controls.Add(this.nomerTextBox);
            this.tabPage1.Controls.Add(kategoriyaLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 91);
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
            this.tabPage2.Size = new System.Drawing.Size(277, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите столбец";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Номер абонента",
            "Категория"});
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Номер абонента";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(277, 91);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Редактирование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Редактировать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Dannie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.abonentDataGridView);
            this.Name = "Dannie_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные об абонентах";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource abonentBindingSource;
        private ATSDataSetTableAdapters.AbonentTableAdapter abonentTableAdapter;
        private ATSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView abonentDataGridView;
        private System.Windows.Forms.TextBox nomerTextBox;
        private System.Windows.Forms.TextBox kategoriyaTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}