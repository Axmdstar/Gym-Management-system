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
            AttSearch_TxtBox = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            CheckedInBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            label2 = new Label();
            panel1 = new Panel();
            NewMemberBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            TtlMemberlbl = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AttSearch_TxtBox
            // 
            AttSearch_TxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AttSearch_TxtBox.Location = new Point(13, 13);
            AttSearch_TxtBox.Margin = new Padding(2);
            AttSearch_TxtBox.Name = "AttSearch_TxtBox";
            AttSearch_TxtBox.Size = new Size(344, 37);
            AttSearch_TxtBox.TabIndex = 3;
            AttSearch_TxtBox.TextChanged += AttSearch_TxtBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Open Sans Extrabold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 9);
            label4.Name = "label4";
            label4.Size = new Size(298, 65);
            label4.TabIndex = 5;
            label4.Text = "DashBoard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(883, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 348);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 104);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(902, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 2;
            label3.Text = "Schedule";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(429, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 348);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(AttSearch_TxtBox);
            panel4.Controls.Add(CheckedInBtn);
            panel4.Location = new Point(3, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 65);
            panel4.TabIndex = 0;
            // 
            // CheckedInBtn
            // 
            CheckedInBtn.Depth = 0;
            CheckedInBtn.Dock = DockStyle.Right;
            CheckedInBtn.Icon = Properties.Resources.pngegg__2_;
            CheckedInBtn.Location = new Point(372, 0);
            CheckedInBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            CheckedInBtn.Name = "CheckedInBtn";
            CheckedInBtn.Size = new Size(72, 65);
            CheckedInBtn.TabIndex = 7;
            CheckedInBtn.Text = "materialFloatingActionButton2";
            CheckedInBtn.UseVisualStyleBackColor = true;
            CheckedInBtn.Click += CheckedInBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 1;
            label2.Text = "Attendance";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NewMemberBtn);
            panel1.Controls.Add(TtlMemberlbl);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 346);
            panel1.TabIndex = 0;
            // 
            // NewMemberBtn
            // 
            NewMemberBtn.Depth = 0;
            NewMemberBtn.Icon = Properties.Resources.add;
            NewMemberBtn.Location = new Point(354, 280);
            NewMemberBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            NewMemberBtn.Name = "NewMemberBtn";
            NewMemberBtn.Size = new Size(62, 59);
            NewMemberBtn.TabIndex = 6;
            NewMemberBtn.Text = "materialFloatingActionButton1";
            NewMemberBtn.UseVisualStyleBackColor = true;
            NewMemberBtn.Click += NewMemberBtn_Click;
            // 
            // TtlMemberlbl
            // 
            TtlMemberlbl.AutoSize = true;
            TtlMemberlbl.Location = new Point(116, 101);
            TtlMemberlbl.Margin = new Padding(2, 0, 2, 0);
            TtlMemberlbl.Name = "TtlMemberlbl";
            TtlMemberlbl.Size = new Size(59, 25);
            TtlMemberlbl.TabIndex = 4;
            TtlMemberlbl.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 99);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 0;
            label1.Text = "Total Members";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(19, 128);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1346, 385);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 244);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Dashboard";
            Size = new Size(1411, 746);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AttSearch_TxtBox;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label TtlMemberlbl;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton NewMemberBtn;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton CheckedInBtn;
        private Panel panel4;
    }
}
