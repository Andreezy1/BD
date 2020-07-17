using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Diagramma : Form
    {
        public Diagramma()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aTSDataSet.report". При необходимости она может быть перемещена или удалена.
            this.reportTableAdapter.Fill(this.aTSDataSet.report);
            SqlConnection sqlConnection; // Для подкл к БД
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ООП\OOP\курсач\Kursach\ATS.mdf;Integrated Security=True";//Где наша БД
            sqlConnection = new SqlConnection(constring);//Подключаемся к БД
            //обновления диаграммы
            string sql = "SELECT * FROM Report"; //Выбор данных
            //Для работы с БД
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();

            sqlConnection.Open();//Открываем подключение
            dataadapter.Fill(ds, "Report");//Записываем данные в датасет
            sqlConnection.Close();//Закрываем
            chart1.DataSource = ds;//Данные в диаграмму из датасета
            chart1.Series["Series3"].XValueMember = (ds.Tables[0].Columns[1]).ToString();
            chart1.Series["Series3"].YValueMembers = (ds.Tables[0].Columns[0]).ToString();
        }
    }
}
