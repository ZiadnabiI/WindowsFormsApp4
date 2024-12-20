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
    public partial class Add_Member : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=BORA3Y;Initial Catalog=GYM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Add_Member()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.gYMDataSet.Gym);
            // TODO: This line of code loads data into the 'gYMDataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.gYMDataSet.Membership);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string memberName = memberNameTextBox.Text.Trim();
            string memberId = memberIdTextBox.Text.Trim();
            string gymId = textBox1.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string paymentId = paymentIdTextBox.Text.Trim();
            decimal amount = decimal.Parse(amountTextBox.Text.Trim());
            string membershipType = membershipTypeComboBox.SelectedItem.ToString();
            DateTime startDate = DateTime.Today;
            DateTime dob = dobPicker.Value;
            DateTime paymentDate = DateTime.Now;

            // Calculate end date
            DateTime endDate = startDate;
            switch (membershipType)
            {
                case "Yearly": endDate = startDate.AddYears(1); break;
                case "Half-Year": endDate = startDate.AddMonths(6); break;
                case "Quarter-Year": endDate = startDate.AddMonths(3); break;
                case "Month": endDate = startDate.AddMonths(1); break;
            }

            // Call the helper method
            DatabaseHelper.InsertMember( memberId, gymId, memberName, dob, phone, email);

            MessageBox.Show("Data successfully saved!");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

