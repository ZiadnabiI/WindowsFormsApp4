using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Employee : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=BORA3Y;Initial Catalog=GYM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;

        public Employee()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Employees",con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.gYMDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("passed Sucsseful!" , "sucsses" , MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
