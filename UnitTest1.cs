using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Reflection.Emit;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            string username = "admin";
            string password = "adminpass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Роль FROM Пользователи WHERE Логин = @username AND Пароль = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    if (role == "Администратор")
                    {
                        adm1 adminForm = new adm1();
                    }
                    else if (role == "Пользователь")
                    {
                        user userForm = new user();
                    }
                    else
                    {
                        //label4.Text = "Неизвестная роль!";
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                connection.Close();
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            string username = "admin";
            string password = "adminpass1111";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Роль FROM Пользователи WHERE Логин = @username AND Пароль = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    if (role == "Администратор")
                    {
                        adm1 adminForm = new adm1();
                    }
                    else if (role == "Пользователь")
                    {
                        user userForm = new user();
                    }
                    else
                    {
                        //label4.Text = "Неизвестная роль!";
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                connection.Close();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            string username = "user1";
            string password = "userpass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Роль FROM Пользователи WHERE Логин = @username AND Пароль = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    if (role == "Администратор")
                    {
                        adm1 adminForm = new adm1();
                    }
                    else if (role == "Пользователь")
                    {
                        user userForm = new user();
                    }
                    else
                    {
                        //label4.Text = "Неизвестная роль!";
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                connection.Close();
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            string Code = "2";
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить статус заявления?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 ID_Заявки FROM dbo.Заявка WHERE ID_Заявки = @Id";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Code);
                    object result1 = command.ExecuteScalar();
                    if (result1 != null)
                    {
                        query = "update dbo.Заявка set ID_Заявки = @id, Статус_заявку = @stat where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", 2);
                        SqlParameter param2 = new SqlParameter("@stat", 3);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            string Code = "2";
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить статус заявления?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 ID_Заявки FROM dbo.Заявка WHERE ID_Заявки = @Id";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Code);
                    object result1 = command.ExecuteScalar();
                    if (result1 != null)
                    {
                        query = "update dbo.Заявка set ID_Заявки = @id, Статус_заявки = @stat where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", 2);
                        SqlParameter param2 = new SqlParameter("@stat", 3);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string zapr = "insert into dbo.Заявка values(@id, @data, @tip, @marka, @model, @vin, @fio, @telef, @stat, @insp, @prim)";
                SqlCommand com1 = new SqlCommand(zapr, connection);
                SqlParameter param1 = new SqlParameter("@id", 1111);
                SqlParameter param2 = new SqlParameter("@data","2222");
                SqlParameter param3 = new SqlParameter("@tip", 2);
                SqlParameter param4 = new SqlParameter("@marka", "цувуа");
                SqlParameter param5 = new SqlParameter("@model", "уцвау");
                SqlParameter param6 = new SqlParameter("@vin", "111");
                SqlParameter param7 = new SqlParameter("@fio", "вувувв");
                SqlParameter param8 = new SqlParameter("@telef", "22222");
                SqlParameter param9 = new SqlParameter("@stat", 2);
                SqlParameter param10 = new SqlParameter("@insp", 2);
                SqlParameter param11 = new SqlParameter("@prim", "ыцчвыцву");
                com1.Parameters.Add(param1);
                com1.Parameters.Add(param2);
                com1.Parameters.Add(param3);
                com1.Parameters.Add(param4);
                com1.Parameters.Add(param5);
                com1.Parameters.Add(param6);
                com1.Parameters.Add(param7);
                com1.Parameters.Add(param8);
                com1.Parameters.Add(param9);
                com1.Parameters.Add(param10);
                com1.Parameters.Add(param11);
                connection.Open();
                com1.ExecuteNonQuery();
                connection.Close();

            
                MessageBox.Show("Заявка успешно добавлена");
            }
        }
    }
}
