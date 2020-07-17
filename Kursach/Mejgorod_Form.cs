using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Mejgorod_Form : Form
    {
        public Mejgorod_Form()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aTSDataSet.Tarif". При необходимости она может быть перемещена или удалена.
            this.tarifTableAdapter.Fill(this.aTSDataSet.Tarif);

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Поиск в таблице
        {
            if (comboBox1.Text == "Междугородний код") // Столбец для поиска
            {
                tarifBindingSource.Filter = "Convert ([Kod_mejgorod],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'"; // Строка для фильтра(что ищем)
            }
            else tarifBindingSource.Filter = "[Gorod]" + " LIKE" + " '" + textBox1.Text + "*'";
        }

        private void tarifDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            } else e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tarifDataGridView.ReadOnly = false;
            else tarifDataGridView.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tarifTableAdapter.Update(aTSDataSet.Tarif);
            }
        }
    }
}
