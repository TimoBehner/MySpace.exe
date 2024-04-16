namespace MySpace1._0
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbdays = new Label();
            lbevent = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbevent01 = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdays.ForeColor = Color.FromArgb(158, 161, 176);
            lbdays.Location = new Point(3, 10);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(19, 13);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // lbevent
            // 
            lbevent.Dock = DockStyle.Bottom;
            lbevent.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbevent.Location = new Point(0, 69);
            lbevent.Name = "lbevent";
            lbevent.Size = new Size(143, 35);
            lbevent.TabIndex = 1;
            lbevent.TextAlign = ContentAlignment.MiddleCenter;
            lbevent.Click += lbevent_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbevent01
            // 
            lbevent01.Dock = DockStyle.Bottom;
            lbevent01.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbevent01.Location = new Point(0, 34);
            lbevent01.Name = "lbevent01";
            lbevent01.Size = new Size(143, 35);
            lbevent01.TabIndex = 2;
            lbevent01.TextAlign = ContentAlignment.MiddleCenter;
            lbevent01.Click += lbevent01_Click;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            Controls.Add(lbevent01);
            Controls.Add(lbevent);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(143, 104);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbevent;
        private System.Windows.Forms.Timer timer1;
        private Label lbevent01;
    }
}
