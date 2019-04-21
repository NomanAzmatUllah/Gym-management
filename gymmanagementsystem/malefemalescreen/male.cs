using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymmanagementsystem.malefemalescreen
{
    public partial class male : Form
    { 
        public male()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detail  log = new detail();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Date.Text = DateTime.Now.ToString("dd MMMM,yyyy");
        }
    }
}
