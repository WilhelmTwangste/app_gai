using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = log1.Text;
            string password = passw.Text;

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
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (role == "Пользователь")
                    {
                       user userForm = new user();
                        userForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        label4.Text = "Неизвестная роль!";
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из системы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
