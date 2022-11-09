using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class Form1 : Form
    {
        public int bordersize = 2;

        public Form1()
        {
            InitializeComponent();
            //CollapsMenu();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }
        [DllImport("user32.Dill", EntryPoint = "ReleaseCature")]
        private extern static void ReleasCapture();

        [DllImport("user32.Dill", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wParam,int lParam);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to sign in first");

             Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to sign in first");

            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //CollapsMenu();
        }
        private void CollapsMenu()
        {

            if (this.panel6.Width > 200)
            {
               // pictureBox.Visible = false;
                Menu3dot.Dock = DockStyle.Top;

                foreach(Button menuButton in panel6.Controls.OfType<Button>())
                {
                    menuButton.Text="";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);

                }
            }
            else 
            {
                this.panel6.Width = 230;
                // pictureBox.Visible = false;
                Menu3dot.Dock = DockStyle.None;

                foreach (Button menuButton in panel6.Controls.OfType<Button>())
                {
                    menuButton.Text = "    "+menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10,0,0,0);

                }
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleasCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            AdjustForm();

              void AdjustForm()
            {
               switch(this.WindowState)
                {
                    case FormWindowState.Maximized:
                        this.Padding = new Padding(0, 8, 8, 0);
                        break;

                    case FormWindowState.Normal:
                        if (this.Padding.Top != bordersize)
                            this.Padding = new Padding(bordersize);
                        break;


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 a=new Form2();
            this.Hide();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

        }
         /*protected override void WndProc(ref Message n)
           {
                const int WM_NCCALCSIZE = 0x0083;
              if (n.Msg == WM_NCCALCSIZE && n.WParam.ToInt32()==1)
                {
                 return; 
                 }
               base.WndProc(ref n);

               }*/

        private void iconButton8_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleasCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to sign in first");
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to sign in first");
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f2 = new Form12();
                this.Hide();
                f2.Show();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }
    }
}
