using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ATSDataSet.Stoimost". При необходимости она может быть перемещена или удалена.
            this.StoimostTableAdapter.Fill(this.ATSDataSet.Stoimost);
            SqlConnection sqlConnection; // Для подкл к БД
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ООП\OOP\курсач\Kursach\ATS.mdf;Integrated Security=True";//Где наша БД
            sqlConnection = new SqlConnection(constring);//Подключаемся к БД
            //обновления диаграммы
            string sql = "SELECT * FROM Stoimost"; //Выбор данных
            //Для работы с БД
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();

            sqlConnection.Open();//Открываем подключение
            dataadapter.Fill(ds, "Stoimost");//Записываем данные в датасет
            sqlConnection.Close();//Закрываем
            StoimostBindingSource.DataSource = ds;
            this.reportViewer1.RefreshReport();
        }
    }
}
