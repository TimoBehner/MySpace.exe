namespace MySpace1._0
{
    partial class Loginpage
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
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            btnRegistrieren = new Label();
            btnlogin1 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(153, 176);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 1;
            label1.Text = "Benutzername";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(153, 282);
            label2.Name = "label2";
            label2.Size = new Size(151, 33);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(74, 79, 99);
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtuser.Location = new Point(153, 221);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(387, 31);
            txtuser.TabIndex = 3;
            txtuser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(74, 79, 99);
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtpass.Location = new Point(153, 330);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(387, 31);
            txtpass.TabIndex = 4;
            txtpass.TextAlign = HorizontalAlignment.Center;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnRegistrieren);
            panel1.Controls.Add(btnlogin1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(242, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 523);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(0, 126);
            label6.Name = "label6";
            label6.Size = new Size(701, 29);
            label6.TabIndex = 10;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(225, 480);
            label7.Name = "label7";
            label7.Size = new Size(237, 25);
            label7.TabIndex = 8;
            label7.Text = "Passwort vergessen?";
            label7.Click += btnlogin1_Click;
            // 
            // btnRegistrieren
            // 
            btnRegistrieren.AutoSize = true;
            btnRegistrieren.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrieren.ForeColor = Color.FromArgb(158, 161, 176);
            btnRegistrieren.Location = new Point(355, 413);
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
            btnlogin1.Location = new Point(153, 413);
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
            label4.Location = new Point(274, 27);
            label4.Name = "label4";
            label4.Size = new Size(147, 55);
            label4.TabIndex = 7;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 219);
            label3.Location = new Point(134, 37);
            label3.Name = "label3";
            label3.Size = new Size(515, 73);
            label3.TabIndex = 8;
            label3.Text = "Willkommen bei ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_04_05_172358;
            pictureBox1.Location = new Point(574, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1143, 800);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Loginpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loginpage";
            Load += Loginpage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label btnlogin1;
        private Label label6;
        private Label label7;
        private Label btnRegistrieren;
        private PictureBox pictureBox1;
    }
}