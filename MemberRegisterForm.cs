using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyWinFormsApp
{
    public partial class MemberRegisterForm : Form
    {
        private string connStr = "server=localhost;user=root;password=amr12345;database=library_management;";

        public MemberRegisterForm()
        {
            InitializeComponent();
            buttonRegisterMember.Click += ButtonRegisterMember_Click;
        }

        private void ButtonRegisterMember_Click(object? sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            DateTime registrationDate = dateTimePickerRegistrationDate.Value.Date;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("❗ Please fill in all member details.");
                return;
            }

            try
            {
                using var conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = @"INSERT INTO Member (name, address, email, registrationDate) 
                               VALUES (@name, @address, @email, @regDate)";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@regDate", registrationDate);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("✅ Member registered successfully!");
                else
                    MessageBox.Show("⚠️ Failed to register member.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }
    }
}
