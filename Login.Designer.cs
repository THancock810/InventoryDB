namespace InventoryDB
{
    partial class Login
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
            Label lblUser;
            Label lblPass;
            Label lblWelcome;
            panel1 = new Panel();
            inputPass = new TextBox();
            btnSignUp = new Button();
            inputUser = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.None;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F);
            lblUser.Location = new Point(274, 367);
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
            lblPass.Location = new Point(279, 417);
            lblPass.Name = "lblPass";
            lblPass.RightToLeft = RightToLeft.No;
            lblPass.Size = new Size(76, 21);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 36F);
            lblWelcome.Location = new Point(219, 197);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(559, 65);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Sign in to your inventory:";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(inputPass);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(inputUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 761);
            panel1.TabIndex = 1;
            // 
            // inputPass
            // 
            inputPass.Anchor = AnchorStyles.None;
            inputPass.Location = new Point(420, 417);
            inputPass.Name = "inputPass";
            inputPass.RightToLeft = RightToLeft.No;
            inputPass.Size = new Size(291, 23);
            inputPass.TabIndex = 1;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.Location = new Point(423, 476);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(138, 23);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign In";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignIn_Click;
            // 
            // inputUser
            // 
            inputUser.Anchor = AnchorStyles.None;
            inputUser.Location = new Point(420, 367);
            inputUser.Name = "inputUser";
            inputUser.RightToLeft = RightToLeft.No;
            inputUser.Size = new Size(291, 23);
            inputUser.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox inputPass;
        private Button btnSignUp;
        private TextBox inputUser;
    }
}