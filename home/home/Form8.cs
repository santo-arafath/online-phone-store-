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
    public partial class Form8 : Form
    {
        public Form8()
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

            SqlCommand cmd = new SqlCommand("Delete CustomerTAB where Email=@Email", con);



            
            cmd.Parameters.AddWithValue("@Email", email.Text);
            
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("User Deleted Successfully");
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
