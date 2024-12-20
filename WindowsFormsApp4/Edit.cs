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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Trainer trainer = new Trainer();
            trainer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Membership member = new Membership();
            member.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Member mem = new Member();
            mem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trainer tr = new Trainer();
            tr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Membership mesh = new Membership();
            mesh.Show(); 
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
        }
    }
}
