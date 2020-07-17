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
    public partial class Detalizaciya : Form
    {
        SqlConnection sqlConnection;// Для подключения БД
        int id = 0;//ид звонка
        BindingSource bs = new BindingSource();
        public Detalizaciya()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //строка подключения
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ООП\OOP\курсач\Kursach\ATS.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(constring);
            //обновления таблицы
            string sql = "SELECT * FROM Stoimost";//выбор данных
            //Для работы с БД
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            //BindingSource bs = new BindingSource();
            sqlConnection.Open();//подключение к БД
            dataadapter.Fill(ds, "Stoimost");//Запись из бд
            sqlConnection.Close();//закрываем подключение
            bs.DataSource = ds.Tables["Stoimost"]; //для управления данными
            dataGridView1.DataSource = bs;//Данные для датагрида из датасета
            dataGridView1.Columns[0].HeaderText = "Id";//Название столбцов
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Номер абонента";
            dataGridView1.Columns[3].HeaderText = "Междугородний код";
            dataGridView1.Columns[4].HeaderText = "Набираемый номер";
            dataGridView1.Columns[5].HeaderText = "Состоялся";
            dataGridView1.Columns[6].HeaderText = "Длительность";
            dataGridView1.Columns[7].HeaderText = "Стоимость";
            id = dataGridView1.RowCount; // значение ид
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            //команды для добавления данных и выборки данных
            SqlCommand command = new SqlCommand("INSERT INTO [Zvonki] (Id,Data,Nomer_abonenta,Kod_mej,Nabir_nomer,Sostoyalsya,Dlitelnest) VALUES (@Id,@Data,@Nomer_abonenta,@Kod_mej,@Nabir_nomer,@Sostoyalsya,@Dlitelnest)", sqlConnection);
            SqlCommand command1 = new SqlCommand("SELECT * FROM Abonent", sqlConnection);
            SqlCommand command2 = new SqlCommand("SELECT * FROM Tarif", sqlConnection);
            sqlConnection.Open();//подключаемся к бд
            Random random = new Random();//переменная для рандома
            DateTime dateTime;//переменная для времени
            string[] nomer_abon = new string[30];//номер абонента
            string nabir_nomer;//набираемый номер
            string sostoyalsy;//состоялся ли звонок
            TimeSpan dlitelnost;//длительность звонка
            string[] kod_mej = new string[10];//межгород
            int temp, temp2, temp3;//временные переменные
            
            SqlDataReader reader = command1.ExecuteReader();//Чтение данных из таблицы абонентов
            int i = 0;
            while (reader.Read())
                {
                    nomer_abon[i] = (reader[0].ToString());//запись номеров в массив
                    i++;
                }
            reader.Close();//закрываем чтение

            SqlDataReader reader1 = command2.ExecuteReader();//чтение данных из табл Тариф
            i = 0;
            while (reader1.Read())
            {
                kod_mej[i] = (reader1[0].ToString());//запись междугородних кодов в массив
                i++;
            }
            reader1.Close();//закрываем

            dateTime = DateTime.Now;//используем время сейчас
            temp = random.Next(24);//час
            temp2 = random.Next(60);//минуты
            temp3 = random.Next(60);//секунды
            TimeSpan tempTS = new TimeSpan(temp, temp2, temp3);//для разного времени
            dateTime = dateTime - tempTS;//дата звонка
           
            Boolean Success = false; 
            temp = random.Next(100); 
            if (temp < 60) Success = true; //процент состоявшихся звонков
            if (Success)
            {
                temp = random.Next(40);//m
                temp2 = random.Next(60);//s
                dlitelnost = new TimeSpan(0, temp, temp2);// длительсность состоявшегося звонка
                sostoyalsy = "Да";
            }
            else
            {
                dlitelnost = new TimeSpan(0, 0, 10); //не состоялся
                sostoyalsy = "Нет";
            }
            
            temp = random.Next(10,100);//
            temp2 = random.Next(10,100);//
            temp3 = random.Next(10,100);//
            nabir_nomer = temp.ToString() + "-" + temp2.ToString() + "-" + temp3.ToString() ; //набираемый номер

            int tempn = random.Next(1, 7) * 5 - 1;// номера для междугородних звонков
            int tempk = random.Next(0,10); // междугородный код
            // добавляемые данные
            command.Parameters.AddWithValue("Id",id);
            command.Parameters.AddWithValue("Data",dateTime);
            command.Parameters.AddWithValue("Nomer_abonenta",nomer_abon[tempn]);
            command.Parameters.AddWithValue("Kod_mej",kod_mej[tempk]);
            command.Parameters.AddWithValue("Nabir_nomer",nabir_nomer);
            command.Parameters.AddWithValue("Sostoyalsya", sostoyalsy);
            command.Parameters.AddWithValue("Dlitelnest", dlitelnost);
            command.ExecuteNonQuery(); //выполнение команды
            sqlConnection.Close();// закрываем подключеие
            id += 1;//изменения ид звонка
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Stoimost"; //выбор данных
            //для работы с БД
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlConnection.Open();//подключение
            dataadapter.Fill(ds, "Stoimost");//добавл данных
            sqlConnection.Close();//закрываем подключение
            bs.DataSource = ds.Tables["Stoimost"];//для управления данными
            dataGridView1.DataSource = bs;//данные для таблицы
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otchet form5 = new Otchet();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Diagramma form6 = new Diagramma();
            form6.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {       
           switch (comboBox1.Text)
            {
                case "Дата":
                    bs.Filter = "Convert ([Data],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Номер абонента":
                    bs.Filter = "Convert ([Nomer_abonenta],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Междугородний код":
                    bs.Filter = "Convert ([Kod_mej],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Набираемый номер":
                    bs.Filter = "Convert ([Nabir_nomer],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Состоялся":
                    bs.Filter = "Convert ([Sostoyalsya],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Длительность":
                    bs.Filter = "Convert ([Dlitelnest],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
                case "Стоимость":
                    bs.Filter = "Convert ([Stoimost],'System.String')" + " LIKE" + " '" + textBox1.Text + "*'";
                    break;
            }
        }
    }
}
