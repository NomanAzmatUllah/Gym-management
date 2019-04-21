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
    public partial class malegrid : Form
    {
        public malegrid()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detail d = new detail();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            malefemalescreen.male mal = new male();
            mal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginform.logincs log = new loginform.logincs();
            log.Show();
            this.Hide();
        }
    }
}
