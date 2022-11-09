using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace home
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void cretae_Click(object sender, EventArgs e)
        {
            if (firstname.Text != "" && lastname.Text != "" && email.Text != "" && username.Text != "" && password.Text != "" && confirmpassword.Text != "")
            {

                if (password.Text != confirmpassword.Text)
                {
                    this.Focus();
                    errorProvider2.SetError(this.confirmpassword, "password are not same !!");

                }
                else
                {
                    errorProvider2.Clear();


                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTAB values(@Name,@Email,@Username,@Password)", con);

                    cmd.Parameters.AddWithValue("@Name", lastname.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("User Added Succesfully saved ==");
                }
            }
            else
            {
                MessageBox.Show("Fill up all the requren info");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }
        private string pettern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void email_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, pettern) == false)
            {

                this.Focus();
                errorProvider1.SetError(this.email, "invalid email !!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void EmailiconBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f6 = new Form5();
            this.Hide();
            f6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
