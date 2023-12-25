namespace Gym_Management_system
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            TtlMemberlbl = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(TtlMemberlbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 347);
            panel1.TabIndex = 0;
            // 
            // TtlMemberlbl
            // 
            TtlMemberlbl.AutoSize = true;
            TtlMemberlbl.Location = new Point(116, 101);
            TtlMemberlbl.Name = "TtlMemberlbl";
            TtlMemberlbl.Size = new Size(59, 25);
            TtlMemberlbl.TabIndex = 4;
            TtlMemberlbl.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Total Members";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(459, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 347);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 101);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 1;
            label2.Text = "Attendance";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(931, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 347);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 104);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Schedule";
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(19, 454);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(212, 51);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Checked In";
            iconButton1.UseMnemonic = false;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 474);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 244);
            Controls.Add(textBox1);
            Controls.Add(iconButton1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1385, 743);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private Label TtlMemberlbl;
        private Label label5;
        private Label label6;
    }
}
