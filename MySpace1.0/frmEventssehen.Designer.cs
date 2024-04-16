namespace MySpace1._0
{
    partial class frmEventssehen
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
            txtüberschrift = new Label();
            panel1 = new Panel();
            termincontainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtüberschrift
            // 
            txtüberschrift.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            txtüberschrift.ForeColor = Color.FromArgb(0, 126, 219);
            txtüberschrift.Location = new Point(12, 10);
            txtüberschrift.Name = "txtüberschrift";
            txtüberschrift.Size = new Size(997, 73);
            txtüberschrift.TabIndex = 12;
            txtüberschrift.Text = "Events für den";
            txtüberschrift.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(termincontainer);
            panel1.Location = new Point(82, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 507);
            panel1.TabIndex = 11;
            // 
            // termincontainer
            // 
            termincontainer.AutoScroll = true;
            termincontainer.Dock = DockStyle.Fill;
            termincontainer.Location = new Point(0, 0);
            termincontainer.Name = "termincontainer";
            termincontainer.Size = new Size(855, 507);
            termincontainer.TabIndex = 3;
            // 
            // frmEventssehen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1021, 649);
            Controls.Add(txtüberschrift);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmEventssehen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEventssehen";
            Load += frmEventssehen_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label txtüberschrift;
        private Panel panel1;
        private FlowLayoutPanel termincontainer;
    }
}