using System.Windows.Forms;

namespace MyWinFormsApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonRegister;

        private void InitializeComponent()
        {
            this.labelUsername = new Label();
            this.labelPassword = new Label();
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.buttonRegister = new Button();

            // Label Username
            this.labelUsername.Text = "Username";
            this.labelUsername.Location = new System.Drawing.Point(20, 20);
            this.labelUsername.AutoSize = true;

            // Label Password
            this.labelPassword.Text = "Password";
            this.labelPassword.Location = new System.Drawing.Point(20, 60);
            this.labelPassword.AutoSize = true;

            // TextBox Username
            this.textBoxUsername.Location = new System.Drawing.Point(100, 20);
            this.textBoxUsername.Size = new System.Drawing.Size(150, 23);

            // TextBox Password
            this.textBoxPassword.Location = new System.Drawing.Point(100, 60);
            this.textBoxPassword.Size = new System.Drawing.Size(150, 23);
            this.textBoxPassword.PasswordChar = '*';

            // Register Button
            this.buttonRegister.Text = "Register";
            this.buttonRegister.Location = new System.Drawing.Point(100, 100);
            this.buttonRegister.Size = new System.Drawing.Size(150, 30);

            // RegisterForm Configuration
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRegister);
            this.Name = "RegisterForm";
            this.Text = "Sign Up";
        }
    }
}
