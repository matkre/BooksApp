namespace BooksApp
{
    partial class AdminLogin
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.Label();
            this.menuText = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.loginMessageField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(282, 137);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(221, 20);
            this.loginField.TabIndex = 0;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(282, 194);
            this.passField.MaxLength = 20;
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(221, 20);
            this.passField.TabIndex = 1;
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Location = new System.Drawing.Point(211, 140);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(33, 13);
            this.loginText.TabIndex = 2;
            this.loginText.Text = "Login";
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.Location = new System.Drawing.Point(211, 197);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(36, 13);
            this.passText.TabIndex = 3;
            this.passText.Text = "Hasło";
            // 
            // menuText
            // 
            this.menuText.AutoSize = true;
            this.menuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuText.Location = new System.Drawing.Point(291, 64);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(257, 20);
            this.menuText.TabIndex = 4;
            this.menuText.Text = "Logowanie do konta administratora";
            this.menuText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(428, 264);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // loginMessageField
            // 
            this.loginMessageField.AutoSize = true;
            this.loginMessageField.Location = new System.Drawing.Point(279, 288);
            this.loginMessageField.Name = "loginMessageField";
            this.loginMessageField.Size = new System.Drawing.Size(0, 13);
            this.loginMessageField.TabIndex = 6;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginMessageField);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.menuText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Name = "AdminLogin";
            this.Text = "E-Books";
            this.Load += new System.EventHandler(this.OnLoadAdminLog);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label loginMessageField;
    }
}