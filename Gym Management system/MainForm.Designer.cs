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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            PlansBtn = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            dashboard1 = new Dashboard();
            attendance1 = new Attendance();
            plansDashboard1 = new PlansDashboard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 26, 29);
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(PlansBtn);
            panel1.Controls.Add(iconButton6);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 911);
            panel1.TabIndex = 0;
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
            iconButton8.Location = new Point(0, 850);
            iconButton8.Margin = new Padding(2);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(9, 0, 0, 0);
            iconButton8.Size = new Size(300, 61);
            iconButton8.TabIndex = 7;
            iconButton8.Text = "LogOut";
            iconButton8.UseVisualStyleBackColor = false;
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
            PlansBtn.Location = new Point(0, 529);
            PlansBtn.Margin = new Padding(6);
            PlansBtn.Name = "PlansBtn";
            PlansBtn.Padding = new Padding(9, 0, 0, 0);
            PlansBtn.Size = new Size(300, 61);
            PlansBtn.TabIndex = 6;
            PlansBtn.Text = "Plans";
            PlansBtn.UseMnemonic = false;
            PlansBtn.UseVisualStyleBackColor = false;
            PlansBtn.Click += PlansBtn_Click;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.FromArgb(22, 26, 29);
            iconButton6.BackgroundImageLayout = ImageLayout.None;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 339);
            iconButton6.Margin = new Padding(6);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(9, 0, 0, 0);
            iconButton6.Size = new Size(300, 61);
            iconButton6.TabIndex = 5;
            iconButton6.Text = "MemberShip";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(22, 26, 29);
            iconButton4.BackgroundImageLayout = ImageLayout.None;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 624);
            iconButton4.Margin = new Padding(6, 2, 6, 6);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(9, 0, 0, 0);
            iconButton4.Size = new Size(300, 61);
            iconButton4.TabIndex = 5;
            iconButton4.Text = "iconButton4";
            iconButton4.UseVisualStyleBackColor = false;
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
            iconButton3.Location = new Point(0, 434);
            iconButton3.Margin = new Padding(6);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(9, 0, 0, 0);
            iconButton3.Size = new Size(300, 61);
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
            iconButton2.Location = new Point(0, 244);
            iconButton2.Margin = new Padding(6);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(9, 0, 0, 0);
            iconButton2.Size = new Size(300, 61);
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
            iconButton1.Location = new Point(0, 149);
            iconButton1.Margin = new Padding(6);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(9, 0, 0, 0);
            iconButton1.Size = new Size(300, 61);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "DashBoard";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(159, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
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
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Margin = new Padding(2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(90, 85);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(245, 243, 244);
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(300, 0);
            dashboard1.Margin = new Padding(2);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1511, 911);
            dashboard1.TabIndex = 1;
            // 
            // attendance1
            // 
            attendance1.Dock = DockStyle.Fill;
            attendance1.Location = new Point(300, 0);
            attendance1.Margin = new Padding(2);
            attendance1.Name = "attendance1";
            attendance1.Size = new Size(1511, 911);
            attendance1.TabIndex = 2;
            // 
            // plansDashboard1
            // 
            plansDashboard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            plansDashboard1.Dock = DockStyle.Fill;
            plansDashboard1.Location = new Point(300, 0);
            plansDashboard1.Name = "plansDashboard1";
            plansDashboard1.Size = new Size(1511, 911);
            plansDashboard1.TabIndex = 3;
            plansDashboard1.Load += plansDashboard1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1811, 911);
            Controls.Add(plansDashboard1);
            Controls.Add(attendance1);
            Controls.Add(dashboard1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MainForm";
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
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton PlansBtn;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Dashboard dashboard1;
        private Attendance attendance1;
        private Membership membership1;
        private PlansDashboard plansDashboard1;

    }
}