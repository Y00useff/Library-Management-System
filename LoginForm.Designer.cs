using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSignup;

        private void InitializeComponent()
        {
            this.labelUsername = new Label();
            this.labelPassword = new Label();
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.buttonLogin = new Button();
            this.buttonSignup = new Button();

            // Label - Username
            this.labelUsername.Text = "Username";
            this.labelUsername.Location = new System.Drawing.Point(20, 20);
            this.labelUsername.Size = new System.Drawing.Size(70, 23);

            // TextBox - Username
            this.textBoxUsername.Location = new System.Drawing.Point(100, 20);
            this.textBoxUsername.Size = new System.Drawing.Size(150, 23);

            // Label - Password
            this.labelPassword.Text = "Password";
            this.labelPassword.Location = new System.Drawing.Point(20, 60);
            this.labelPassword.Size = new System.Drawing.Size(70, 23);

            // TextBox - Password
            this.textBoxPassword.Location = new System.Drawing.Point(100, 60);
            this.textBoxPassword.Size = new System.Drawing.Size(150, 23);
            this.textBoxPassword.PasswordChar = '*';

            // Button - Login
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Location = new System.Drawing.Point(40, 100);
            this.buttonLogin.Size = new System.Drawing.Size(80, 30);

            // Button - Sign Up
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.Location = new System.Drawing.Point(140, 100);
            this.buttonSignup.Size = new System.Drawing.Size(80, 30);

            // Form Configuration
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSignup);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
