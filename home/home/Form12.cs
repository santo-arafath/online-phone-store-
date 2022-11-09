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
   
    public partial class Form12 : Form
    {

        private int indexof_phone;

        public Form12()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This phone is out of stock !!");


        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This phone is out of stock !!");
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            indexof_phone = 10;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            indexof_phone = 9;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

            indexof_phone = 8;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();




        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            indexof_phone = 7;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            indexof_phone = 6;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            indexof_phone = 5;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {


            indexof_phone = 4;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            indexof_phone = 3;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            indexof_phone = 2;
            Form14 f12 = new Form14(indexof_phone);
            this.Hide();

            f12.Show();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            indexof_phone = 1;

            Form14 f12 = new Form14(indexof_phone);
            this.Hide();
         
            f12.Show();



            

            
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sing out sucessfuly ");
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            this.Hide();
            f.Show();
        }
    }
}
