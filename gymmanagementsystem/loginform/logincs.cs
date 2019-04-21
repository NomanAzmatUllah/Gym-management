using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymmanagementsystem.loginform
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

        private void logincs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "male" && password.Text == "male")
            {

                detail dt = new detail();
                dt.Show();
                this.Hide();


            }
            if (name.Text == "female" && password.Text == "female")
            {

                femaledetailsfom dt = new femaledetailsfom();
                dt.Show();
                this.Hide();


            }
            else if(name.Text == "admin" && password.Text == "admin")
            {
                adminpage.adminpage ad = new adminpage.adminpage();
                ad.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Value");

            }
            
        }
    }
}
