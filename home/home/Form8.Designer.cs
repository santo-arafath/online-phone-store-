
namespace home
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.EmailiconBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cretae = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailiconBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::home.Properties.Resources.add_remove_user_icons_20638746;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 733);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 254);
            this.panel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Customer";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(184, 316);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 23);
            this.email.TabIndex = 25;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // EmailiconBox1
            // 
            this.EmailiconBox1.BackColor = System.Drawing.Color.Transparent;
            this.EmailiconBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EmailiconBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EmailiconBox1.ForeColor = System.Drawing.Color.Black;
            this.EmailiconBox1.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.EmailiconBox1.IconColor = System.Drawing.Color.Black;
            this.EmailiconBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmailiconBox1.IconSize = 60;
            this.EmailiconBox1.Location = new System.Drawing.Point(88, 307);
            this.EmailiconBox1.Name = "EmailiconBox1";
            this.EmailiconBox1.Size = new System.Drawing.Size(32, 32);
            this.EmailiconBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmailiconBox1.TabIndex = 36;
            this.EmailiconBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(126, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.button2.Location = new System.Drawing.Point(304, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cretae
            // 
            this.cretae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.cretae.Location = new System.Drawing.Point(88, 447);
            this.cretae.Name = "cretae";
            this.cretae.Size = new System.Drawing.Size(165, 34);
            this.cretae.TabIndex = 32;
            this.cretae.Text = "Delete";
            this.cretae.UseVisualStyleBackColor = false;
            this.cretae.Click += new System.EventHandler(this.cretae_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.EmailiconBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cretae);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(658, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 733);
            this.panel1.TabIndex = 2;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailiconBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private FontAwesome.Sharp.IconPictureBox EmailiconBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cretae;
        private System.Windows.Forms.Panel panel1;
    }
}