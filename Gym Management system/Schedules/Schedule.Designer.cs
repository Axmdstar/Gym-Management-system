namespace Gym_Management_system.Schedules
{
    partial class Schedule
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
            ScheduleGrid = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            Timerlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ScheduleGrid).BeginInit();
            SuspendLayout();
            // 
            // ScheduleGrid
            // 
            ScheduleGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScheduleGrid.BackgroundColor = Color.White;
            ScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScheduleGrid.Location = new Point(12, 161);
            ScheduleGrid.Name = "ScheduleGrid";
            ScheduleGrid.RowHeadersWidth = 62;
            ScheduleGrid.RowTemplate.Height = 33;
            ScheduleGrid.Size = new Size(1335, 597);
            ScheduleGrid.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Timerlabel
            // 
            Timerlabel.Font = new Font("LEMON MILK Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlabel.ForeColor = SystemColors.MenuText;
            Timerlabel.Location = new Point(12, 24);
            Timerlabel.Name = "Timerlabel";
            Timerlabel.Size = new Size(492, 104);
            Timerlabel.TabIndex = 9;
            Timerlabel.Text = "label7";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 768);
            Controls.Add(Timerlabel);
            Controls.Add(ScheduleGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schedule";
            Padding = new Padding(10);
            Text = "Schedule";
            Load += Schedule_Load;
            ((System.ComponentModel.ISupportInitialize)ScheduleGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ScheduleGrid;
        private System.Windows.Forms.Timer timer1;
        public Label Timerlabel;
    }
}