namespace MySpace1._0
{
    partial class EventForm
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
            txtdate = new TextBox();
            txtevent = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            txtuhrzeit_anfangswert = new TextBox();
            txtnotizen = new TextBox();
            btnSpeichern = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            radioButton4 = new RadioButton();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtuhrzeit_endwert = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtdate
            // 
            txtdate.BackColor = Color.FromArgb(74, 79, 99);
            txtdate.BorderStyle = BorderStyle.FixedSingle;
            txtdate.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtdate.Location = new Point(73, 139);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(494, 31);
            txtdate.TabIndex = 0;
            // 
            // txtevent
            // 
            txtevent.BackColor = Color.FromArgb(74, 79, 99);
            txtevent.BorderStyle = BorderStyle.FixedSingle;
            txtevent.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtevent.Location = new Point(72, 225);
            txtevent.Name = "txtevent";
            txtevent.Size = new Size(494, 31);
            txtevent.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.Gold;
            radioButton1.Location = new Point(83, 584);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 28);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Schule";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            radioButton2.ForeColor = Color.Cyan;
            radioButton2.Location = new Point(83, 634);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(109, 28);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Haushalt";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            radioButton3.ForeColor = Color.YellowGreen;
            radioButton3.Location = new Point(83, 609);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(106, 28);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Soziales";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtuhrzeit_endwert);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtuhrzeit_anfangswert);
            panel1.Controls.Add(txtnotizen);
            panel1.Controls.Add(btnSpeichern);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtdate);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(txtevent);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(53, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 754);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(158, 161, 176);
            label6.Location = new Point(72, 269);
            label6.Name = "label6";
            label6.Size = new Size(124, 33);
            label6.TabIndex = 13;
            label6.Text = "Uhrzeit:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(68, 466);
            label7.Name = "label7";
            label7.Size = new Size(121, 33);
            label7.TabIndex = 14;
            label7.Text = "Notizen";
            // 
            // txtuhrzeit_anfangswert
            // 
            txtuhrzeit_anfangswert.BackColor = Color.FromArgb(74, 79, 99);
            txtuhrzeit_anfangswert.BorderStyle = BorderStyle.FixedSingle;
            txtuhrzeit_anfangswert.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtuhrzeit_anfangswert.Location = new Point(84, 347);
            txtuhrzeit_anfangswert.Name = "txtuhrzeit_anfangswert";
            txtuhrzeit_anfangswert.Size = new Size(482, 31);
            txtuhrzeit_anfangswert.TabIndex = 11;
            // 
            // txtnotizen
            // 
            txtnotizen.BackColor = Color.FromArgb(74, 79, 99);
            txtnotizen.BorderStyle = BorderStyle.FixedSingle;
            txtnotizen.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnotizen.Location = new Point(68, 502);
            txtnotizen.Name = "txtnotizen";
            txtnotizen.Size = new Size(494, 31);
            txtnotizen.TabIndex = 12;
            // 
            // btnSpeichern
            // 
            btnSpeichern.AutoSize = true;
            btnSpeichern.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpeichern.ForeColor = Color.FromArgb(158, 161, 176);
            btnSpeichern.Location = new Point(222, 700);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(155, 33);
            btnSpeichern.TabIndex = 10;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(71, 545);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 9;
            label2.Text = "Kategorie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(158, 161, 176);
            label5.Location = new Point(54, 22);
            label5.Name = "label5";
            label5.Size = new Size(529, 55);
            label5.TabIndex = 8;
            label5.Text = "Neues Event erstellen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(72, 103);
            label1.Name = "label1";
            label1.Size = new Size(106, 33);
            label1.TabIndex = 7;
            label1.Text = "Datum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(158, 161, 176);
            label4.Location = new Point(72, 189);
            label4.Name = "label4";
            label4.Size = new Size(129, 33);
            label4.TabIndex = 7;
            label4.Text = "Ereignis";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            radioButton4.ForeColor = Color.BlueViolet;
            radioButton4.Location = new Point(83, 659);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(119, 28);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "Sonstiges";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 219);
            label3.Location = new Point(198, 21);
            label3.Name = "label3";
            label3.Size = new Size(298, 73);
            label3.TabIndex = 10;
            label3.Text = "Kalender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(158, 161, 176);
            label8.Location = new Point(83, 311);
            label8.Name = "label8";
            label8.Size = new Size(78, 33);
            label8.TabIndex = 15;
            label8.Text = "Von:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(158, 161, 176);
            label9.Location = new Point(82, 385);
            label9.Name = "label9";
            label9.Size = new Size(68, 33);
            label9.TabIndex = 17;
            label9.Text = "Bis:";
            // 
            // txtuhrzeit_endwert
            // 
            txtuhrzeit_endwert.BackColor = Color.FromArgb(74, 79, 99);
            txtuhrzeit_endwert.BorderStyle = BorderStyle.FixedSingle;
            txtuhrzeit_endwert.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtuhrzeit_endwert.Location = new Point(83, 421);
            txtuhrzeit_endwert.Name = "txtuhrzeit_endwert";
            txtuhrzeit_endwert.Size = new Size(482, 31);
            txtuhrzeit_endwert.TabIndex = 16;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(745, 904);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdate;
        private TextBox txtevent;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label btnSpeichern;
        private RadioButton radioButton4;
        private Label label6;
        private Label label7;
        private TextBox txtuhrzeit_anfangswert;
        private TextBox txtnotizen;
        private Label label9;
        private TextBox txtuhrzeit_endwert;
        private Label label8;
    }
}