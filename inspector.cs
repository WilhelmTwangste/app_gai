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
    public partial class inspector : Form
    {
        string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
        public inspector()
        {
            InitializeComponent();
        }

        private void inspector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.Инспектор". При необходимости она может быть перемещена или удалена.
            this.инспекторTableAdapter.Fill(this.gaiDataSet.Инспектор);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code = textBox1.Text;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить инспектора?", "Предупреждение", MessageBoxButtons.YesNo);
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
                        query = "update dbo.Заявка set ID_Заявки = @id, ID_Инспектора = @insp where ID_Заявки = @id";
                        command = new SqlCommand(query, connection);
                        SqlParameter param1 = new SqlParameter("@id", textBox1.Text);
                        SqlParameter param2 = new SqlParameter("@insp", textBox2.Text);
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
            adm1 home = new adm1();
            home.Show();
            this.Hide();
        }
    }
}
