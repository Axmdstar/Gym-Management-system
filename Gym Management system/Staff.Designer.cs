namespace Gym_Management_system
{
    partial class Staff
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
            StaffGridTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            Tell = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Village = new DataGridViewTextBoxColumn();
            Em_Contact = new DataGridViewTextBoxColumn();
            Emm_Name = new DataGridViewTextBoxColumn();
            Emm_R = new DataGridViewTextBoxColumn();
            Shift = new DataGridViewTextBoxColumn();
            StaffType = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)StaffGridTable).BeginInit();
            SuspendLayout();
            // 
            // StaffGridTable
            // 
            StaffGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffGridTable.Columns.AddRange(new DataGridViewColumn[] { id, FirstName, LastName, DoB, Tell, Email, Sex, City, Village, Em_Contact, Emm_Name, Emm_R, Shift, StaffType, Salary });
            StaffGridTable.Dock = DockStyle.Bottom;
            StaffGridTable.Location = new Point(0, 346);
            StaffGridTable.Name = "StaffGridTable";
            StaffGridTable.RowHeadersWidth = 62;
            StaffGridTable.RowTemplate.Height = 33;
            StaffGridTable.Size = new Size(1783, 461);
            StaffGridTable.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // DoB
            // 
            DoB.HeaderText = "DoB";
            DoB.MinimumWidth = 8;
            DoB.Name = "DoB";
            DoB.Width = 150;
            // 
            // Tell
            // 
            Tell.HeaderText = "Tell";
            Tell.MinimumWidth = 8;
            Tell.Name = "Tell";
            Tell.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Sex
            // 
            Sex.HeaderText = "Sex";
            Sex.MinimumWidth = 8;
            Sex.Name = "Sex";
            Sex.Width = 150;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 8;
            City.Name = "City";
            City.Width = 150;
            // 
            // Village
            // 
            Village.HeaderText = "Village";
            Village.MinimumWidth = 8;
            Village.Name = "Village";
            Village.Width = 150;
            // 
            // Em_Contact
            // 
            Em_Contact.HeaderText = "Em_Contact";
            Em_Contact.MinimumWidth = 8;
            Em_Contact.Name = "Em_Contact";
            Em_Contact.Width = 150;
            // 
            // Emm_Name
            // 
            Emm_Name.HeaderText = "Emm_Name";
            Emm_Name.MinimumWidth = 8;
            Emm_Name.Name = "Emm_Name";
            Emm_Name.Width = 150;
            // 
            // Emm_R
            // 
            Emm_R.HeaderText = "Emm_R";
            Emm_R.MinimumWidth = 8;
            Emm_R.Name = "Emm_R";
            Emm_R.Width = 150;
            // 
            // Shift
            // 
            Shift.HeaderText = "Shift";
            Shift.MinimumWidth = 8;
            Shift.Name = "Shift";
            Shift.Width = 150;
            // 
            // StaffType
            // 
            StaffType.HeaderText = "StaffType";
            StaffType.MinimumWidth = 8;
            StaffType.Name = "StaffType";
            StaffType.Width = 150;
            // 
            // Salary
            // 
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 8;
            Salary.Name = "Salary";
            Salary.Width = 150;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StaffGridTable);
            Name = "Staff";
            Size = new Size(1783, 807);
            ((System.ComponentModel.ISupportInitialize)StaffGridTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView StaffGridTable;
        public DataGridViewTextBoxColumn id;
        public DataGridViewTextBoxColumn FirstName;
        public DataGridViewTextBoxColumn LastName;
        public DataGridViewTextBoxColumn DoB;
        public DataGridViewTextBoxColumn Tell;
        public DataGridViewTextBoxColumn Email;
        public DataGridViewTextBoxColumn Sex;
        public DataGridViewTextBoxColumn City;
        public DataGridViewTextBoxColumn Village;
        public DataGridViewTextBoxColumn Em_Contact;
        public DataGridViewTextBoxColumn Emm_Name;
        public DataGridViewTextBoxColumn Emm_R;
        public DataGridViewTextBoxColumn Shift;
        public DataGridViewTextBoxColumn StaffType;
        public DataGridViewTextBoxColumn Salary;
    }
}
