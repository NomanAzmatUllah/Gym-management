using gymmanagementsystem.loginform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymmanagementsystem
{
    public partial class detail : Form 
    {
        public detail()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            malefemalescreen.malegrid grid = new malefemalescreen.malegrid();
            grid.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            malefemalescreen.male mle = new malefemalescreen.male();
            mle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transctions t = new transctions();
            t.Show();
            this.Hide();
        }
    }
}
