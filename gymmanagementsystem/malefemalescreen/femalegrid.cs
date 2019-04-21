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
    public partial class femalegrid : Form
    {
        public femalegrid()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            detail d = new detail();
            d.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loginform.logincs log = new loginform.logincs();
            log.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            malefemalescreen.female fem = new female();
            fem.Show();
            this.Hide();
        }
    }
}
