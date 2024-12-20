using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Add_trainer : Form
    {
        public Add_trainer()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string trainerName = trainerNameTextBox.Text.Trim();
                string trainerId = trainerIdTextBox.Text.Trim();
                string gymId = gymIdTextBox.Text.Trim();
                string phone = phoneTextBox.Text.Trim();
                string email = emailTextBox.Text.Trim();
                decimal salary = decimal.Parse(salaryTextBox.Text.Trim());

                DatabaseHelper.InsertTrainer(trainerId, trainerName, gymId, phone, email, salary);

                MessageBox.Show("Trainer data successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Add_trainer_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
