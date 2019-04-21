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
    public partial class femaledetailsfom : Form
    {
        public femaledetailsfom()
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

        private void button3_Click(object sender, EventArgs e)
        {
            malefemalescreen.female fmale = new malefemalescreen.female();
            fmale.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            malefemalescreen.femalegrid f = new malefemalescreen.femalegrid();
            f.Show();
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
