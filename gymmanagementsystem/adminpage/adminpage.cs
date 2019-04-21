using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymmanagementsystem.adminpage
{
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            malefemalescreen.male ma = new malefemalescreen.male();
            ma.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            malefemalescreen.female mal = new malefemalescreen.female();
            mal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detail de = new detail();
            de.Show();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            malefemalescreen.malegrid mle = new malefemalescreen.malegrid();
            mle.Show();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            malefemalescreen.femalegrid fle = new malefemalescreen.femalegrid();
            fle.Show();
            this.Show();
        }

        private DateTimePicker timePicker;

        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transctions t = new transctions();
            t.Show();
            this.Hide();
        }
    }
}
