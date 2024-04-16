namespace MySpace1._0
{
    partial class Registerpage
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
            panel1 = new Panel();
            label6 = new Label();
            btnRegistrieren = new Label();
            btnlogin1 = new Label();
            label4 = new Label();
            txtuser = new TextBox();
            txtpass01 = new TextBox();
            txtpass02 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnRegistrieren);
            panel1.Controls.Add(btnlogin1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(txtpass01);
            panel1.Controls.Add(txtpass02);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(221, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 585);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Microsoft Sans Serif", 18F);
            label6.ForeColor = Color.Red;
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(3, 121);
            label6.Name = "label6";
            label6.Size = new Size(695, 29);
            label6.TabIndex = 11;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // btnRegistrieren
            // 
            btnRegistrieren.AutoSize = true;
            btnRegistrieren.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrieren.ForeColor = Color.FromArgb(158, 161, 176);
            btnRegistrieren.Location = new Point(355, 501);
            btnRegistrieren.Name = "btnRegistrieren";
            btnRegistrieren.Size = new Size(185, 33);
            btnRegistrieren.TabIndex = 8;
            btnRegistrieren.Text = "Registrieren";
            btnRegistrieren.Click += btnRegistrieren_Click;
            // 
            // btnlogin1
            // 
            btnlogin1.AutoSize = true;
            btnlogin1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin1.ForeColor = Color.FromArgb(158, 161, 176);
            btnlogin1.Location = new Point(153, 501);
            btnlogin1.Name = "btnlogin1";
            btnlogin1.Size = new Size(154, 33);
            btnlogin1.TabIndex = 8;
            btnlogin1.Text = "Anmelden";
            btnlogin1.Click += btnlogin1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(196, 22);
            label4.Name = "label4";
            label4.Size = new Size(295, 55);
            label4.TabIndex = 7;
            label4.Text = "Registrieren";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(74, 79, 99);
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtuser.Location = new Point(153, 240);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(387, 31);
            txtuser.TabIndex = 3;
            txtuser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpass01
            // 
            txtpass01.BackColor = Color.FromArgb(74, 79, 99);
            txtpass01.BorderStyle = BorderStyle.FixedSingle;
            txtpass01.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtpass01.Location = new Point(153, 334);
            txtpass01.Name = "txtpass01";
            txtpass01.PasswordChar = '*';
            txtpass01.Size = new Size(387, 31);
            txtpass01.TabIndex = 4;
            txtpass01.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpass02
            // 
            txtpass02.BackColor = Color.FromArgb(74, 79, 99);
            txtpass02.BorderStyle = BorderStyle.FixedSingle;
            txtpass02.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtpass02.Location = new Point(153, 433);
            txtpass02.Name = "txtpass02";
            txtpass02.PasswordChar = '*';
            txtpass02.Size = new Size(387, 31);
            txtpass02.TabIndex = 4;
            txtpass02.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(153, 195);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 1;
            label1.Text = "Benutzername";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(158, 161, 176);
            label5.Location = new Point(153, 286);
            label5.Name = "label5";
            label5.Size = new Size(143, 33);
            label5.TabIndex = 2;
            label5.Text = "Passwort";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(153, 385);
            label2.Name = "label2";
            label2.Size = new Size(395, 33);
            label2.TabIndex = 2;
            label2.Text = "Passwort bitte Wiederholen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 126, 219);
            label7.Location = new Point(113, 25);
            label7.Name = "label7";
            label7.Size = new Size(515, 73);
            label7.TabIndex = 11;
            label7.Text = "Willkommen bei ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_04_05_1723581;
            pictureBox1.Location = new Point(553, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Registerpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1143, 752);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Registerpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registerpage";
            Load += Registerpage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label btnRegistrieren;
        private Label btnlogin1;
        private Label label4;
        private TextBox txtuser;
        private TextBox txtpass01;
        private TextBox txtpass02;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}