using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class control : Form
    {
        public control()
        {
            InitializeComponent();
        }

        private void control_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gaiDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.gaiDataSet.Заявка);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adm1 home = new adm1();
            home.Show();
            this.Hide();
        }
    }
}
