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
    public partial class add : Form
    {
        string connectionString = @"Data Source=UBIVATOR;Initial Catalog=gai;Integrated Security=True";
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {
            this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.ТипТранспортногоСредства". При необходимости она может быть перемещена или удалена.
            this.типТранспортногоСредстваTableAdapter.Fill(this.gaiDataSet.ТипТранспортногоСредства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.Инспектор". При необходимости она может быть перемещена или удалена.
            this.инспекторTableAdapter.Fill(this.gaiDataSet.Инспектор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.СтатусЗаявки". При необходимости она может быть перемещена или удалена.
            this.статусЗаявкиTableAdapter.Fill(this.gaiDataSet.СтатусЗаявки);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adm1 home = new adm1();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string zapr = "insert into dbo.Заявка values(@id, @data, @tip, @marka, @model, @vin, @fio, @telef, @stat, @insp, @prim)";
                SqlCommand com1 = new SqlCommand(zapr, connection);
                SqlParameter param1 = new SqlParameter("@id", textBox1.Text);
                SqlParameter param2 = new SqlParameter("@data", textBox2.Text);
                SqlParameter param3 = new SqlParameter("@tip", textBox3.Text);
                SqlParameter param4 = new SqlParameter("@marka", textBox4.Text);
                SqlParameter param5 = new SqlParameter("@model", textBox7.Text);
                SqlParameter param6 = new SqlParameter("@vin", textBox11.Text);
                SqlParameter param7 = new SqlParameter("@fio", textBox6.Text);
                SqlParameter param8 = new SqlParameter("@telef", textBox5.Text);
                SqlParameter param9 = new SqlParameter("@stat", textBox8.Text);
                SqlParameter param10 = new SqlParameter("@insp", textBox9.Text);
                SqlParameter param11 = new SqlParameter("@prim", textBox10.Text);
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

                this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
                MessageBox.Show("Заявка успешно добавлена");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
