using System;
using System.Collections.Generic;
using System.Data;//NB
using System.Data.Common;//NB
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using MySql.Data;//NB
using MySql.Data.MySqlClient;//NB
namespace DataLayer
{
    public class DataLayerClass
    {
        //public DataLayerClass() { }
        public static string connectionString = "server=localhost;uid=root;password='';database=labexercise3";//To connect the application to the databse 
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand command;
        void OpenCloseDatabase()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            else connection.Close();
        }

        public void InsertToTable(string idnumber,string name, string surname, string email,int age )
        {
            OpenCloseDatabase();
            //string sql = $"insert into staff(idnumber,name,email,cellphone,age) values('{idnumber}','{name}','{surname},{email}'.'{age}')";
            string sql = $"INSERT INTO staff (idnumber, name, surname, email, age) VALUES ('{idnumber}','{name}','{surname}','{email}','{age}')";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            OpenCloseDatabase();
        }
        public DataTable SelectTable()//Get all rows in the table and return in a datatable 
        {
            OpenCloseDatabase();
            DataTable table = new DataTable();

            string sql = "select * from staff";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);

            dataAdapter.Fill(table);
            return table;
        }

    }
}
