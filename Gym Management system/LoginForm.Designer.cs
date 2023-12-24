namespace Gym_Management_system
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            PaswordTxtBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            UserNameTxtBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin2DotNet.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(3, 0);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(110, 29);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Username";
            materialLabel1.UseAccent = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin2DotNet.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(0, 0);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 29);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Password";
            materialLabel2.UseAccent = true;
            // 
            // PaswordTxtBox
            // 
            PaswordTxtBox.AnimateReadOnly = false;
            PaswordTxtBox.AutoCompleteMode = AutoCompleteMode.None;
            PaswordTxtBox.AutoCompleteSource = AutoCompleteSource.None;
            PaswordTxtBox.BackgroundImageLayout = ImageLayout.None;
            PaswordTxtBox.CharacterCasing = CharacterCasing.Normal;
            PaswordTxtBox.Depth = 0;
            PaswordTxtBox.Dock = DockStyle.Bottom;
            PaswordTxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PaswordTxtBox.HideSelection = true;
            PaswordTxtBox.LeadingIcon = null;
            PaswordTxtBox.Location = new Point(0, 37);
            PaswordTxtBox.MaxLength = 32767;
            PaswordTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            PaswordTxtBox.Name = "PaswordTxtBox";
            PaswordTxtBox.PasswordChar = '\0';
            PaswordTxtBox.PrefixSuffixText = null;
            PaswordTxtBox.ReadOnly = false;
            PaswordTxtBox.RightToLeft = RightToLeft.No;
            PaswordTxtBox.SelectedText = "";
            PaswordTxtBox.SelectionLength = 0;
            PaswordTxtBox.SelectionStart = 0;
            PaswordTxtBox.ShortcutsEnabled = true;
            PaswordTxtBox.Size = new Size(629, 48);
            PaswordTxtBox.TabIndex = 4;
            PaswordTxtBox.TabStop = false;
            PaswordTxtBox.TextAlign = HorizontalAlignment.Left;
            PaswordTxtBox.TrailingIcon = null;
            PaswordTxtBox.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(625, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 370);
            panel1.TabIndex = 5;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(330, 293);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 34);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(PaswordTxtBox);
            panel2.Location = new Point(81, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 85);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(UserNameTxtBox);
            panel3.Controls.Add(materialLabel1);
            panel3.Location = new Point(78, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(629, 85);
            panel3.TabIndex = 7;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.AnimateReadOnly = false;
            UserNameTxtBox.AutoCompleteMode = AutoCompleteMode.None;
            UserNameTxtBox.AutoCompleteSource = AutoCompleteSource.None;
            UserNameTxtBox.BackgroundImageLayout = ImageLayout.None;
            UserNameTxtBox.CharacterCasing = CharacterCasing.Normal;
            UserNameTxtBox.Depth = 0;
            UserNameTxtBox.Dock = DockStyle.Bottom;
            UserNameTxtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserNameTxtBox.HideSelection = true;
            UserNameTxtBox.LeadingIcon = null;
            UserNameTxtBox.Location = new Point(0, 37);
            UserNameTxtBox.MaxLength = 32767;
            UserNameTxtBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PasswordChar = '\0';
            UserNameTxtBox.PrefixSuffixText = null;
            UserNameTxtBox.ReadOnly = false;
            UserNameTxtBox.RightToLeft = RightToLeft.No;
            UserNameTxtBox.SelectedText = "";
            UserNameTxtBox.SelectionLength = 0;
            UserNameTxtBox.SelectionStart = 0;
            UserNameTxtBox.ShortcutsEnabled = true;
            UserNameTxtBox.Size = new Size(629, 48);
            UserNameTxtBox.TabIndex = 4;
            UserNameTxtBox.TabStop = false;
            UserNameTxtBox.TextAlign = HorizontalAlignment.Left;
            UserNameTxtBox.TrailingIcon = null;
            UserNameTxtBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("LEMON MILK", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(626, 280);
            label1.Name = "label1";
            label1.Size = new Size(143, 51);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1811, 911);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 PaswordTxtBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 UserNameTxtBox;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}