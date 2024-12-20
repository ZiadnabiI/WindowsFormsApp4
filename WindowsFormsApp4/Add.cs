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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Member addm = new Add_Member();
            addm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_trainer addt = new Add_trainer();
            addt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Employee addE = new Add_Employee();
            addE.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
