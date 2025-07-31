using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyWinFormsApp
{
    public partial class LoginForm : Form
    {
        private string connStr = "server=localhost;user=root;password=amr12345;database=library_management;";

        public LoginForm()
        {
            InitializeComponent();

            buttonLogin.Click += ButtonLogin_Click;
            buttonSignup.Click += ButtonSignup_Click;
        }

        private void ButtonLogin_Click(object? sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("❗ Please enter both username and password.");
                return;
            }

            using var conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE username = @user AND password = @pass";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("✅ Login successful!");
                    this.Hide();
                    new Form1().Show();  // open main system
                }
                else
                {
                    MessageBox.Show("❌ Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Database error: " + ex.Message);
            }
        }

        private void ButtonSignup_Click(object? sender, EventArgs e)
        {
            // ✅ Real form implementation
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // blocks login until closed
        }
    }
}
