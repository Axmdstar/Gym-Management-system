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
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            butto = new Button();
            UsernameErrorCheck = new Label();
            PasswordErrorCheck = new Label();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = SystemColors.Menu;
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Location = new Point(169, 359);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(315, 38);
            textBoxUserName.TabIndex = 0;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Menu;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(168, 502);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(315, 38);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // butto
            // 
            butto.BackColor = Color.FromArgb(192, 0, 0);
            butto.FlatAppearance.BorderSize = 0;
            butto.FlatStyle = FlatStyle.Flat;
            butto.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            butto.ForeColor = Color.White;
            butto.Location = new Point(133, 584);
            butto.Name = "butto";
            butto.Size = new Size(372, 48);
            butto.TabIndex = 1;
            butto.Text = "Sign in";
            butto.UseVisualStyleBackColor = false;
            butto.Click += butto_Click;
            // 
            // UsernameErrorCheck
            // 
            UsernameErrorCheck.BackColor = Color.Transparent;
            UsernameErrorCheck.ForeColor = Color.Red;
            UsernameErrorCheck.Location = new Point(164, 405);
            UsernameErrorCheck.Name = "UsernameErrorCheck";
            UsernameErrorCheck.Size = new Size(174, 25);
            UsernameErrorCheck.TabIndex = 2;
            UsernameErrorCheck.Visible = false;
            // 
            // PasswordErrorCheck
            // 
            PasswordErrorCheck.BackColor = Color.Transparent;
            PasswordErrorCheck.ForeColor = Color.Red;
            PasswordErrorCheck.Location = new Point(164, 543);
            PasswordErrorCheck.Name = "PasswordErrorCheck";
            PasswordErrorCheck.Size = new Size(174, 25);
            PasswordErrorCheck.TabIndex = 2;
            PasswordErrorCheck.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1279, 801);
            Controls.Add(PasswordErrorCheck);
            Controls.Add(UsernameErrorCheck);
            Controls.Add(butto);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            DoubleBuffered = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button butto;
        private Label UsernameErrorCheck;
        private Label PasswordErrorCheck;
    }
}