using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Add_Gym : Form
    {
        public Add_Gym()
        {
            InitializeComponent();
        }

        private void Add_Gym_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.gYMDataSet.Gym);
            // Initialize form if needed
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string gymIDText = this.gymIDText.Text.Trim();
            string gymName = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(gymIDText) || string.IsNullOrEmpty(gymName))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(gymIDText, out int gymID))
            {
                MessageBox.Show("Gym ID must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Call the DatabaseHelper method to insert the gym
                DatabaseHelper.InsertGym(gymID, gymName);
                MessageBox.Show("Gym saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the fields after successful insertion
                this.gymIDText.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text change logic if needed
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click if needed
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gymTableAdapter.FillBy(this.gYMDataSet.Gym);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
