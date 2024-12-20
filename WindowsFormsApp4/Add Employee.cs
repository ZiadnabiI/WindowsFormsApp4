using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeId = txtEmployeeID.Text;
            string gymId = textBox1.Text.Trim();
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            decimal salary = decimal.Parse(salaryTextBox.Text.Trim());
            string role = txtRole.Text;
            DateTime hireDate = dateTimePicker1.Value;


            try
            {
                DatabaseHelper.InsertEmployee(employeeId,employeeName,gymId,phone,email,salary, role,hireDate);
                MessageBox.Show("Employee saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        

    }

        private void trainerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.gYMDataSet.Gym);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
