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
    public partial class Dannie_Form : Form
    {
        public Dannie_Form()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aTSDataSet.Abonent". При необходимости она может быть перемещена или удалена.
            this.abonentTableAdapter.Fill(this.aTSDataSet.Abonent);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Номер абонента")// Столбец для поиска
            {
                abonentBindingSource.Filter = "[Nomer]" + " LIKE" + " '" + textBox1.Text + "*'"; //Где и что ищем
            } else abonentBindingSource.Filter = "[Kategoriya]" + " LIKE" + " '" + textBox1.Text + "*'";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                abonentDataGridView.ReadOnly = false;
            else abonentDataGridView.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                abonentTableAdapter.Update(aTSDataSet.Abonent);
            }
        }

        private void abonentDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else e.Cancel = true;
        }
    }
}
