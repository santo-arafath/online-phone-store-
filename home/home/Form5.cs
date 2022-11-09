using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace home
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form8 f6 = new Form8();
            this.Hide();
            f6.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form7 f6 = new Form7();
            this.Hide();
            f6.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" successfully Done");
            Form1 f5 = new Form1();
            this.Hide();
            f5.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form10 f5 = new Form10();
            this.Hide();
            f5.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            this.Hide();
            f.Show();
        }
    }
}
