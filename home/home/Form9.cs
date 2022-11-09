using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace home
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usnm.Text != "" && pss.Text != "")
            {

                if ((usnm.Text=="admin" || usnm.Text == "Admin") && (pss.Text == "admin" || pss.Text == "Admin" ))
                {
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.Show();
                 }
                else
                {
                    MessageBox.Show("Wrong password !!");
                }
            }
            else
            {
                MessageBox.Show("Fill up requred information !!!");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            this.Hide();
            f5.Show();
        }
    }
}
