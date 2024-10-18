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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class izmen : Form
    {
        string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
        public izmen()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void izmen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            adm1 home = new adm1();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить примечание?", "Предупреждение", MessageBoxButtons.YesNo);
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
                        query = "update dbo.Заявка set ID_Заявки = @id, Примечание = @prim where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", textBox1.Text);
                        SqlParameter param2 = new SqlParameter("@prim", textBox2.Text);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                    this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Code = textBox4.Text;
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
                        SqlParameter param1 = new SqlParameter("@id", textBox4.Text);
                        SqlParameter param2 = new SqlParameter("@stat", textBox3.Text);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                    this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Code = textBox8.Text;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить номер телефона заявителя", "Предупреждение", MessageBoxButtons.YesNo);
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
                        query = "update dbo.Заявка set ID_Заявки = @id, Номер_телефона = @telef where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", textBox8.Text);
                        SqlParameter param2 = new SqlParameter("@telef", textBox7.Text);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                    this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Code = textBox10.Text;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить ФИО заявителя", "Предупреждение", MessageBoxButtons.YesNo);
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
                        query = "update dbo.Заявка set ID_Заявки = @id, ФИО_заявителя = @fio where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", textBox10.Text);
                        SqlParameter param2 = new SqlParameter("@fio", textBox9.Text);
                        command.Parameters.Add(param1);
                        command.Parameters.Add(param2);
                        command.ExecuteNonQuery();
                    }
                    this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Code = textBox6.Text;
            DialogResult result1 = MessageBox.Show("Вы уверены, что хотите удалить это заявление?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 ID_Заявки FROM dbo.Заявка WHERE ID_Заявки = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Code);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        query = "delete from dbo.Заявка where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", Code);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Заявление под кодом " + Code + " не существует.");
                    }
                    connection.Close();
                    this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string questCode = textBox5.Text;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    //string query = "SELECT Название, Описание, Локация, Стоимость, Организатор FROM Квесты WHERE Код = @code";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@code", questCode);
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        //textBox19.Text = reader["Название"].ToString();
            //        //textBox18.Text = reader["Описание"].ToString();
            //        //textBox17.Text = reader["Локация"].ToString();
            //        //textBox16.Text = reader["Стоимость"].ToString();
            //        //textBox15.Text = reader["Организатор"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Заявка под кодом " + questCode + " не существует.");
            //    }
            //    reader.Close();
            //}

        }
    }
}
