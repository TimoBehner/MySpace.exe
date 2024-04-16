namespace MySpace1._0
{
    partial class frmKalender
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
            daycontainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbDate = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(15, 148);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1048, 647);
            daycontainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(40, 110);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 3;
            label1.Text = "Sonntag";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(195, 110);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Montag";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(340, 110);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Dienstag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(486, 110);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "Mittwoch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(158, 161, 176);
            label5.Location = new Point(625, 110);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 3;
            label5.Text = "Donnerstag";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(158, 161, 176);
            label6.Location = new Point(792, 110);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 3;
            label6.Text = "Freitag";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(938, 110);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 3;
            label7.Text = "Samstag";
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.FromArgb(158, 161, 176);
            lbDate.Location = new Point(12, 22);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(1048, 42);
            lbDate.TabIndex = 18;
            lbDate.Text = "Month Year";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            lbDate.Click += lbDate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 126, 219);
            label8.Location = new Point(884, 31);
            label8.Name = "label8";
            label8.Size = new Size(103, 33);
            label8.TabIndex = 20;
            label8.Text = "+ New";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pfeil_icon_links;
            pictureBox1.Location = new Point(333, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Pfeil_icon_rechts;
            pictureBox2.Location = new Point(649, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmKalender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1072, 847);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lbDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKalender";
            Text = "frmKalender";
            Load += frmKalender_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbDate;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}