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

    
    public partial class Form14 : Form
    {
        public int indexof_phone = 0;
        public Form14()
        {
            InitializeComponent();
        }
        public Form14(int a)
        {
            InitializeComponent();
            indexof_phone = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indexof_phone == 1)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone_13_Pro_Max'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(indexof_phone == 2)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone 13 Pro'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



            }
            else if (indexof_phone == 3)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone 13'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 4)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone 13 Mini'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 5)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone 12 Pro Max'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 6)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iPhone 12 Pro'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 7)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iphone 12'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 8)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'iphone 12 mini'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 9)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = '11 pro max'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (indexof_phone == 10)
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Select * from PhoneDetailsTAB where Model = 'se'", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" && textBox2.Text !="" && textBox3.Text !="")
            {
                MessageBox.Show("<< Thank you for your Order <<==>> WE will contact you within 24 hour >>");
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-SCKABHO;Initial Catalog=CustomerTAB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into OrderTAB values(@Mobile_serial_Number,@Phone_Number,@Address,@OrderNumber)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Mobile_serial_Number", textBox3.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", textBox1.Text);
                cmd.Parameters.AddWithValue("@Address", textBox2.Text);
                cmd.Parameters.AddWithValue("@OrderNumber",textBox4.Text);
                
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully saved ==");

            }
            else
            {
                MessageBox.Show("Fill Up the requred box First  !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
