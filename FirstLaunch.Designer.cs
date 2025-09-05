namespace InventoryDB
{
    partial class FirstLaunch
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
            Label lblWelcome;
            Label lblUser;
            Label lblPass;
            Label lblConfirmPass;
            Label lblSignUp;
            inputUser = new TextBox();
            inputPass = new TextBox();
            btnSignUp = new Button();
            inputConfirmPass = new TextBox();
            panel1 = new Panel();
            lblWelcome = new Label();
            lblUser = new Label();
            lblPass = new Label();
            lblConfirmPass = new Label();
            lblSignUp = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 36F);
            lblWelcome.Location = new Point(185, 158);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(615, 65);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to your Inventory!\r\n";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.None;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F);
            lblUser.Location = new Point(287, 407);
            lblUser.Name = "lblUser";
            lblUser.RightToLeft = RightToLeft.No;
            lblUser.Size = new Size(81, 21);
            lblUser.TabIndex = 5;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.Anchor = AnchorStyles.None;
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F);
            lblPass.Location = new Point(292, 457);
            lblPass.Name = "lblPass";
            lblPass.RightToLeft = RightToLeft.No;
            lblPass.Size = new Size(76, 21);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.Anchor = AnchorStyles.None;
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Segoe UI", 12F);
            lblConfirmPass.Location = new Point(260, 509);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.RightToLeft = RightToLeft.No;
            lblConfirmPass.Size = new Size(137, 21);
            lblConfirmPass.TabIndex = 7;
            lblConfirmPass.Text = "Confirm Password";
            // 
            // lblSignUp
            // 
            lblSignUp.Anchor = AnchorStyles.None;
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 24F);
            lblSignUp.Location = new Point(209, 223);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.RightToLeft = RightToLeft.No;
            lblSignUp.Size = new Size(566, 45);
            lblSignUp.TabIndex = 8;
            lblSignUp.Text = "To get started, let's get you signed up!\r\n";
            lblSignUp.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputUser
            // 
            inputUser.Anchor = AnchorStyles.None;
            inputUser.Location = new Point(433, 407);
            inputUser.Name = "inputUser";
            inputUser.RightToLeft = RightToLeft.No;
            inputUser.Size = new Size(291, 23);
            inputUser.TabIndex = 0;
            // 
            // inputPass
            // 
            inputPass.Anchor = AnchorStyles.None;
            inputPass.Location = new Point(433, 457);
            inputPass.Name = "inputPass";
            inputPass.RightToLeft = RightToLeft.No;
            inputPass.Size = new Size(291, 23);
            inputPass.TabIndex = 1;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.Location = new Point(509, 580);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(138, 23);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // inputConfirmPass
            // 
            inputConfirmPass.Anchor = AnchorStyles.None;
            inputConfirmPass.Location = new Point(433, 509);
            inputConfirmPass.Name = "inputConfirmPass";
            inputConfirmPass.RightToLeft = RightToLeft.No;
            inputConfirmPass.Size = new Size(291, 23);
            inputConfirmPass.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblSignUp);
            panel1.Controls.Add(inputPass);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(inputConfirmPass);
            panel1.Controls.Add(lblConfirmPass);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(inputUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 761);
            panel1.TabIndex = 0;
            // 
            // FirstLaunch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(panel1);
            Name = "FirstLaunch";
            Text = "Inventory";
            Load += FirstLaunch_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox inputUser;
        private TextBox inputPass;
        private Button btnSignUp;
        private TextBox inputConfirmPass;
        private Label lblWelcome;
        private Label lblUser;
        private Label lblPass;
        private Label lblConfirmPass;
        private Panel panel1;
    }
}
