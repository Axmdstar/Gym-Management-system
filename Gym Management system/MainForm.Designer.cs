using System.Runtime.CompilerServices;


namespace Gym_Management_system
{

    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            Timerlabel = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            PlansBtn = new FontAwesome.Sharp.IconButton();
            MemberShips = new FontAwesome.Sharp.IconButton();
            StaffBtn = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            UserNameLbl = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dashboard1 = new Dashboard();
            attendance1 = new Attendance();
            plansDashboard1 = new PlansDashboard();
            staff1 = new Staff();
            timer1 = new System.Windows.Forms.Timer(components);
            memberships1 = new Memberships();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 26, 29);
            panel1.Controls.Add(Timerlabel);
            panel1.Controls.Add(iconButton5);
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(PlansBtn);
            panel1.Controls.Add(MemberShips);
            panel1.Controls.Add(StaffBtn);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(UserNameLbl);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 891);
            panel1.TabIndex = 0;
            // 
            // Timerlabel
            // 
            Timerlabel.AutoSize = true;
            Timerlabel.Font = new Font("LEMON MILK Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlabel.ForeColor = SystemColors.Window;
            Timerlabel.Location = new Point(12, 802);
            Timerlabel.Name = "Timerlabel";
            Timerlabel.Size = new Size(140, 46);
            Timerlabel.TabIndex = 8;
            Timerlabel.Text = "label7";
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(22, 26, 29);
            iconButton5.BackgroundImageLayout = ImageLayout.None;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(4, 689);
            iconButton5.Margin = new Padding(6, 2, 6, 6);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(9, 0, 0, 0);
            iconButton5.Size = new Size(325, 61);
            iconButton5.TabIndex = 8;
            iconButton5.Text = "xxx";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(22, 26, 29);
            iconButton8.BackgroundImageLayout = ImageLayout.None;
            iconButton8.Dock = DockStyle.Bottom;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(0, 830);
            iconButton8.Margin = new Padding(2);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(9, 0, 0, 0);
            iconButton8.Size = new Size(347, 61);
            iconButton8.TabIndex = 7;
            iconButton8.Text = "LogOut";
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // PlansBtn
            // 
            PlansBtn.BackColor = Color.FromArgb(22, 26, 29);
            PlansBtn.BackgroundImageLayout = ImageLayout.None;
            PlansBtn.FlatAppearance.BorderSize = 0;
            PlansBtn.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            PlansBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            PlansBtn.FlatStyle = FlatStyle.Flat;
            PlansBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlansBtn.ForeColor = Color.White;
            PlansBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            PlansBtn.IconColor = Color.White;
            PlansBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlansBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PlansBtn.Location = new Point(4, 509);
            PlansBtn.Margin = new Padding(6);
            PlansBtn.Name = "PlansBtn";
            PlansBtn.Padding = new Padding(9, 0, 0, 0);
            PlansBtn.Size = new Size(325, 61);
            PlansBtn.TabIndex = 6;
            PlansBtn.Text = "Plans";
            PlansBtn.UseMnemonic = false;
            PlansBtn.UseVisualStyleBackColor = false;
            PlansBtn.Click += PlansBtn_Click;
            // 
            // MemberShips
            // 
            MemberShips.BackColor = Color.FromArgb(22, 26, 29);
            MemberShips.BackgroundImageLayout = ImageLayout.None;
            MemberShips.FlatAppearance.BorderSize = 0;
            MemberShips.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            MemberShips.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MemberShips.FlatStyle = FlatStyle.Flat;
            MemberShips.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MemberShips.ForeColor = Color.White;
            MemberShips.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MemberShips.IconColor = Color.White;
            MemberShips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MemberShips.ImageAlign = ContentAlignment.MiddleLeft;
            MemberShips.Location = new Point(4, 329);
            MemberShips.Margin = new Padding(6);
            MemberShips.Name = "MemberShips";
            MemberShips.Padding = new Padding(9, 0, 0, 0);
            MemberShips.Size = new Size(325, 61);
            MemberShips.TabIndex = 5;
            MemberShips.Text = "MemberShip";
            MemberShips.UseVisualStyleBackColor = false;
            MemberShips.Click += MemberShips_Click;
            // 
            // StaffBtn
            // 
            StaffBtn.BackColor = Color.FromArgb(22, 26, 29);
            StaffBtn.BackgroundImageLayout = ImageLayout.None;
            StaffBtn.FlatAppearance.BorderSize = 0;
            StaffBtn.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            StaffBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            StaffBtn.FlatStyle = FlatStyle.Flat;
            StaffBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StaffBtn.ForeColor = Color.White;
            StaffBtn.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            StaffBtn.IconColor = Color.White;
            StaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StaffBtn.ImageAlign = ContentAlignment.MiddleLeft;
            StaffBtn.Location = new Point(4, 599);
            StaffBtn.Margin = new Padding(6, 2, 6, 6);
            StaffBtn.Name = "StaffBtn";
            StaffBtn.Padding = new Padding(9, 0, 0, 0);
            StaffBtn.Size = new Size(325, 61);
            StaffBtn.TabIndex = 5;
            StaffBtn.Text = "Staff";
            StaffBtn.UseVisualStyleBackColor = false;
            StaffBtn.Click += StaffBtn_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(22, 26, 29);
            iconButton3.BackgroundImageLayout = ImageLayout.None;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(4, 419);
            iconButton3.Margin = new Padding(6);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(9, 0, 0, 0);
            iconButton3.Size = new Size(325, 61);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "Schedules";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(22, 26, 29);
            iconButton2.BackgroundImageLayout = ImageLayout.None;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.List;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(4, 239);
            iconButton2.Margin = new Padding(6);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(9, 0, 0, 0);
            iconButton2.Size = new Size(325, 61);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Attendance";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(22, 26, 29);
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(4, 149);
            iconButton1.Margin = new Padding(6);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(9, 0, 0, 0);
            iconButton1.Size = new Size(325, 61);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "DashBoard";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = Color.Transparent;
            UserNameLbl.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLbl.ForeColor = Color.White;
            UserNameLbl.Location = new Point(139, 50);
            UserNameLbl.Margin = new Padding(2, 0, 2, 0);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(126, 30);
            UserNameLbl.TabIndex = 2;
            UserNameLbl.Text = "Username";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 0, 64);
            iconPictureBox1.BackgroundImage = (Image)resources.GetObject("iconPictureBox1.BackgroundImage");
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 85;
            iconPictureBox1.Location = new Point(24, 23);
            iconPictureBox1.Margin = new Padding(2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(90, 85);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(245, 243, 244);
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(357, 10);
            dashboard1.Margin = new Padding(2);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1446, 891);
            dashboard1.TabIndex = 1;
            // 
            // attendance1
            // 
            attendance1.BackColor = Color.FromArgb(245, 243, 244);
            attendance1.Dock = DockStyle.Fill;
            attendance1.Location = new Point(357, 10);
            attendance1.Margin = new Padding(2);
            attendance1.Name = "attendance1";
            attendance1.Padding = new Padding(10);
            attendance1.Size = new Size(1446, 891);
            attendance1.TabIndex = 2;
            attendance1.Load += attendance1_Load;
            // 
            // plansDashboard1
            // 
            plansDashboard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            plansDashboard1.BackColor = Color.FromArgb(245, 243, 244);
            plansDashboard1.Dock = DockStyle.Fill;
            plansDashboard1.Location = new Point(357, 10);
            plansDashboard1.Name = "plansDashboard1";
            plansDashboard1.Size = new Size(1446, 891);
            plansDashboard1.TabIndex = 3;
            plansDashboard1.Load += plansDashboard1_Load;
            // 
            // staff1
            // 
            staff1.BackColor = Color.FromArgb(245, 243, 244);
            staff1.Dock = DockStyle.Fill;
            staff1.Location = new Point(357, 10);
            staff1.Name = "staff1";
            staff1.Padding = new Padding(10);
            staff1.Size = new Size(1446, 891);
            staff1.TabIndex = 4;
            staff1.Load += staff1_Load;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // memberships1
            // 
            memberships1.BackColor = Color.FromArgb(245, 243, 244);
            memberships1.Dock = DockStyle.Fill;
            memberships1.Location = new Point(357, 10);
            memberships1.Name = "memberships1";
            memberships1.Padding = new Padding(10);
            memberships1.Size = new Size(1446, 891);
            memberships1.TabIndex = 5;
            memberships1.Load += memberships1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 29);
            ClientSize = new Size(1813, 911);
            Controls.Add(memberships1);
            Controls.Add(staff1);
            Controls.Add(plansDashboard1);
            Controls.Add(attendance1);
            Controls.Add(dashboard1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MainForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label UserNameLbl;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton PlansBtn;
        private FontAwesome.Sharp.IconButton MemberShips;
        private FontAwesome.Sharp.IconButton StaffBtn;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        //private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Dashboard dashboard1;
        private Attendance attendance1;
        //private Membership membership1;
        private PlansDashboard plansDashboard1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Staff staff1;
        private System.Windows.Forms.Timer timer1;
        public Label Timerlabel;
        private Memberships memberships1;
    }
}