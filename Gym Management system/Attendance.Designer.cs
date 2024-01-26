namespace Gym_Management_system
{
    partial class Attendance
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
            label1 = new Label();
            AttendanceGridView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            AttSearch_TxtBox = new TextBox();
            CheckedInBtn = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            ((System.ComponentModel.ISupportInitialize)AttendanceGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Extrabold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(318, 65);
            label1.TabIndex = 0;
            label1.Text = "Attendance";
            // 
            // AttendanceGridView
            // 
            AttendanceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceGridView.Dock = DockStyle.Fill;
            AttendanceGridView.Location = new Point(0, 0);
            AttendanceGridView.Name = "AttendanceGridView";
            AttendanceGridView.RowHeadersWidth = 62;
            AttendanceGridView.Size = new Size(1453, 708);
            AttendanceGridView.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(AttendanceGridView);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(10, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1453, 708);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(AttSearch_TxtBox);
            panel2.Controls.Add(CheckedInBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 631);
            panel2.Name = "panel2";
            panel2.Size = new Size(1453, 77);
            panel2.TabIndex = 10;
            // 
            // AttSearch_TxtBox
            // 
            AttSearch_TxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AttSearch_TxtBox.Location = new Point(2, 23);
            AttSearch_TxtBox.Margin = new Padding(2);
            AttSearch_TxtBox.Name = "AttSearch_TxtBox";
            AttSearch_TxtBox.Size = new Size(344, 37);
            AttSearch_TxtBox.TabIndex = 8;
            AttSearch_TxtBox.TextChanged += AttSearch_TxtBox_TextChanged;
            // 
            // CheckedInBtn
            // 
            CheckedInBtn.Depth = 0;
            CheckedInBtn.Icon = Properties.Resources.pngegg__2_;
            CheckedInBtn.Location = new Point(366, 13);
            CheckedInBtn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            CheckedInBtn.Name = "CheckedInBtn";
            CheckedInBtn.Size = new Size(59, 58);
            CheckedInBtn.TabIndex = 9;
            CheckedInBtn.Text = "materialFloatingActionButton2";
            CheckedInBtn.UseVisualStyleBackColor = true;
            CheckedInBtn.Click += CheckedInBtn_Click;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 243, 244);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Attendance";
            Padding = new Padding(10);
            Size = new Size(1473, 801);
            ((System.ComponentModel.ISupportInitialize)AttendanceGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView AttendanceGridView;
        private Panel panel1;
        private Panel panel2;
        public TextBox AttSearch_TxtBox;
        public MaterialSkin2DotNet.Controls.MaterialFloatingActionButton CheckedInBtn;
    }
}
