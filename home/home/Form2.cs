using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace home
{
    public partial class Form2 : Form
    {


        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstname.Text != "" && lastname.Text != "" && email.Text != "" && username.Text != "" && password.Text != "" && confirmpassword.Text != "")
            {
                //MessageBox.Show("  Account created  ");

                if (password.Text != confirmpassword.Text)
                {
                    this.Focus();
                    errorProvider6.SetError(this.confirmpassword, "password are not same !!");

                }
                else
                {
                    errorProvider6.Clear();

                

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into CustomerTAB values(@Name,@Email,@Username,@Password)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Name", lastname.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully saved ==");


                /* string cs = Configuration.ConnectionString();
                 SqlConnection con = new SqlConnection(cs);
                 string query = "insert into info_table values(@usnm,@pss)";
                 SqlCommmand cmd=ew SqlCommand(query, con);
                 cmd.Parameter.AddWithValue("@usnm", usnm.Text);
                 cmd.Parameter.AddWithValue("@pss", pss.Text);*/
            }
            }
            else
            {

                MessageBox.Show("Fill up all the Requred information");


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) == true)
            {
                username.Focus();
                errorProvider4.SetError(this.username, "Please fill Up the username  Box");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
                if (password.Text != confirmpassword.Text)
                {
                    this.Focus();
                    errorProvider6.SetError(this.confirmpassword, "password are not same !!");

                }
                else
                {
                    errorProvider6.Clear();
                    
                }
                
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text) == true)
            {
                password.Focus();
                errorProvider5.SetError(this.password, "Please fill Up the Password Box");
            }
            else
            {
                errorProvider5.Clear();
            }
        }
        private string pettern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(email.Text) == true)
            {
                email.Focus();
                errorProvider3.SetError(this.email, "Please fill Up the Email Box");
            }
            else
            {
                errorProvider3.Clear();
            }*/




            
       
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(firstname.Text)==true)
            {
                firstname.Focus();
                errorProvider7.SetError(this.firstname, "Please fill Up the First name Box");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            this.Hide();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastname.Text) == true)
            {
                lastname.Focus();
                errorProvider2.SetError(this.lastname, "Please fill Up the Last name Box");
            }
            else
            {
                errorProvider2.Clear();
            }


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                confirmpassword.UseSystemPasswordChar = true;
            }
            else
            {
                confirmpassword.UseSystemPasswordChar = false;
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
