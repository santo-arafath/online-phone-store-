using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace home
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username.Text !="" && password.Text !="")
            {




                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                string query = "Select * from  CustomerTAB Where Username= '" + username.Text.Trim() + "' and Password = '" + password.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    Form4 f4 = new Form4();
                    this.Hide();
                    f4.Show();

                }
                else {
                    MessageBox.Show("Cheak your Username and Password !!");
                }
            }
            else
            {
                MessageBox.Show("Fill Up all the Requred Input !!");

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void usnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
