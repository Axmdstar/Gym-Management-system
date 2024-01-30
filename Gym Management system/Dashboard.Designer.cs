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
            DshSearch_TxtBox = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            AttGridView = new DataGridView();
            panel4 = new Panel();
            DshCheckedInBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            label2 = new Label();
            NewMemberBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            label1 = new Label();
            TotalMember = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            StaffTotal = new Label();
            panel6 = new Panel();
            label9 = new Label();
            AttToday = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttGridView).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // DshSearch_TxtBox
            // 
            DshSearch_TxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DshSearch_TxtBox.Location = new Point(13, 13);
            DshSearch_TxtBox.Margin = new Padding(2);
            DshSearch_TxtBox.Name = "DshSearch_TxtBox";
            DshSearch_TxtBox.Size = new Size(486, 37);
            DshSearch_TxtBox.TabIndex = 3;
            DshSearch_TxtBox.TextChanged += dshSearch_TxtBox_TextChanged;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Open Sans Extrabold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 17);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(302, 64);
            label4.TabIndex = 5;
            label4.Text = "DashBoard";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(691, 387);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 397);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 11);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 2;
            label3.Text = "Schedule";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 958);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(AttGridView);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 387);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 397);
            panel2.TabIndex = 1;
            // 
            // AttGridView
            // 
            AttGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttGridView.BackgroundColor = Color.White;
            AttGridView.BorderStyle = BorderStyle.None;
            AttGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            AttGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttGridView.Dock = DockStyle.Bottom;
            AttGridView.Location = new Point(0, 50);
            AttGridView.Name = "AttGridView";
            AttGridView.RowHeadersWidth = 62;
            AttGridView.RowTemplate.Height = 33;
            AttGridView.Size = new Size(659, 282);
            AttGridView.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(DshSearch_TxtBox);
            panel4.Controls.Add(DshCheckedInBtn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 332);
            panel4.Name = "panel4";
            panel4.Size = new Size(659, 65);
            panel4.TabIndex = 0;
            // 
            // DshCheckedInBtn
            // 
            DshCheckedInBtn.Depth = 0;
            DshCheckedInBtn.Dock = DockStyle.Right;
            DshCheckedInBtn.Icon = Properties.Resources.pngegg__2_;
            DshCheckedInBtn.Location = new Point(600, 0);
            DshCheckedInBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            DshCheckedInBtn.Name = "DshCheckedInBtn";
            DshCheckedInBtn.Size = new Size(59, 65);
            DshCheckedInBtn.TabIndex = 7;
            DshCheckedInBtn.Text = "materialFloatingActionButton2";
            DshCheckedInBtn.UseVisualStyleBackColor = true;
            DshCheckedInBtn.Click += dshCheckedInBtn_Click;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 1;
            label2.Text = "Attendance";
            // 
            // NewMemberBtn
            // 
            NewMemberBtn.Depth = 0;
            NewMemberBtn.Icon = Properties.Resources.add;
            NewMemberBtn.Location = new Point(223, 19);
            NewMemberBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            NewMemberBtn.Name = "NewMemberBtn";
            NewMemberBtn.Size = new Size(62, 59);
            NewMemberBtn.TabIndex = 6;
            NewMemberBtn.Text = "materialFloatingActionButton1";
            NewMemberBtn.UseVisualStyleBackColor = true;
            NewMemberBtn.Click += NewMemberBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 0;
            label1.Text = "Summary";
            // 
            // TotalMember
            // 
            TotalMember.BackColor = Color.Transparent;
            TotalMember.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TotalMember.ForeColor = SystemColors.ControlLightLight;
            TotalMember.Location = new Point(3, 2);
            TotalMember.Margin = new Padding(3, 15, 3, 8);
            TotalMember.Name = "TotalMember";
            TotalMember.Size = new Size(117, 85);
            TotalMember.TabIndex = 8;
            TotalMember.Text = "00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 64, 129);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TotalMember);
            panel1.Controls.Add(NewMemberBtn);
            panel1.Location = new Point(27, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 93);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(99, 46);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 9;
            label5.Text = "Members";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 64, 129);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(StaffTotal);
            panel5.Location = new Point(685, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(194, 93);
            panel5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(109, 44);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 9;
            label7.Text = "Staffs";
            // 
            // StaffTotal
            // 
            StaffTotal.AutoSize = true;
            StaffTotal.BackColor = Color.Transparent;
            StaffTotal.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            StaffTotal.ForeColor = SystemColors.ControlLightLight;
            StaffTotal.Location = new Point(0, 3);
            StaffTotal.Margin = new Padding(3, 15, 3, 8);
            StaffTotal.Name = "StaffTotal";
            StaffTotal.Size = new Size(117, 85);
            StaffTotal.TabIndex = 10;
            StaffTotal.Text = "00";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 64, 129);
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(AttToday);
            panel6.Location = new Point(346, 186);
            panel6.Name = "panel6";
            panel6.Size = new Size(317, 93);
            panel6.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(106, 44);
            label9.Name = "label9";
            label9.Size = new Size(195, 32);
            label9.TabIndex = 9;
            label9.Text = "Attended Today";
            // 
            // AttToday
            // 
            AttToday.AutoSize = true;
            AttToday.BackColor = Color.Transparent;
            AttToday.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            AttToday.ForeColor = SystemColors.ControlLightLight;
            AttToday.Location = new Point(3, 2);
            AttToday.Margin = new Padding(3, 15, 3, 8);
            AttToday.Name = "AttToday";
            AttToday.Size = new Size(117, 85);
            AttToday.TabIndex = 8;
            AttToday.Text = "00";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 243, 244);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Dashboard";
            Size = new Size(1411, 1050);
            Load += Dashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttGridView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox DshSearch_TxtBox;
        public Label label4;
        public Panel panel3;
        public Label label6;
        public Label label3;
        public Panel panel2;
        public Label label2;
        public Label label1;
        public FlowLayoutPanel flowLayoutPanel1;
        public MaterialSkin2DotNet.Controls.MaterialFloatingActionButton NewMemberBtn;
        public MaterialSkin2DotNet.Controls.MaterialFloatingActionButton DshCheckedInBtn;
        public Panel panel4;
        public Label TotalMember;
        public Panel panel1;
        public Label label5;
        public Panel panel5;
        public Label label7;
        public Label label8;
        public Panel panel6;
        public Label label9;
        public Label AttToday;
        public Label StaffTotal;
        public DataGridView AttGridView;
    }
}
