using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace home
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f6 = new Form5();
            this.Hide();
            f6.Show();
        }

        private void cretae_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update CustomerTAB set Name=@Name,Username= @Username,Password=@Password Where Email=@Email", con);



            cmd.Parameters.AddWithValue("@Name", lastname.Text);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Parameters.AddWithValue("@Username", username.Text);
            cmd.Parameters.AddWithValue("@Password", password.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("User Information Updated Succesfully");
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

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
