using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyWinFormsApp
{
    public partial class RegisterForm : Form
    {
        private string connStr = "server=localhost;user=root;password=amr12345;database=library_management;";

        public RegisterForm()
        {
            InitializeComponent();
            buttonRegister.Click += ButtonRegister_Click;
        }

        private void ButtonRegister_Click(object? sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("❗ Please fill in both username and password.");
                return;
            }

            using var conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "INSERT INTO Users (username, password) VALUES (@user, @pass)";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.ExecuteNonQuery();

                MessageBox.Show("✅ Registration successful!");
                this.Close(); // Close register form
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry
            {
                MessageBox.Show("❌ Username already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }
    }
}
