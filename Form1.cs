using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        private string connStr = "server=localhost;user=root;password=amr12345;database=library_management;";

        public Form1()
        {
            InitializeComponent();

            // Register event handlers
            buttonTestConnection.Click += ButtonTestConnection_Click;
            buttonAddBook.Click += ButtonAddBook_Click;
            buttonUpdateBook.Click += ButtonUpdateBook_Click;
            buttonDeleteBook.Click += ButtonDeleteBook_Click;
            buttonSelectBooks.Click += ButtonSelectBooks_Click;
            buttonViewUsers.Click += ButtonViewUsers_Click;
            buttonClearBooks.Click += ButtonClearBooks_Click;
            buttonClearUsers.Click += ButtonClearUsers_Click;

            buttonBorrowBook.Click += ButtonBorrowBook_Click;
            buttonReturnBook.Click += ButtonReturnBook_Click;

            // Register new query buttons event handlers
            buttonFinesByMember.Click += ButtonFinesByMember_Click;
            buttonBooksBorrowed.Click += ButtonBooksBorrowed_Click;
            buttonOverdueBooks.Click += ButtonOverdueBooks_Click;
            buttonMostBorrowedBooks.Click += ButtonMostBorrowedBooks_Click;

            // New Register Member button event
            buttonRegisterMemberForm.Click += buttonRegisterMemberForm_Click;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        private void ButtonTestConnection_Click(object? sender, EventArgs e)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                MessageBox.Show("✅ Connected to MySQL successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed: " + ex.Message);
            }
        }

        private void ButtonAddBook_Click(object? sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string author = textBoxAuthor.Text.Trim();
            string genre = textBoxGenre.Text.Trim();
            string isbn = textBoxISBN.Text.Trim();
            string? availability = comboBoxAvailability.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(isbn) ||
                (availability != "available" && availability != "unavailable"))
            {
                MessageBox.Show("⚠️ Please fill all fields correctly. Availability must be 'available' or 'unavailable'.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = @"INSERT INTO Book (title, author, genre, isbn, availabilityStatus)
                               VALUES (@title, @auth, @genre, @isbn, @avail)";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@auth", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@avail", availability);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "✅ Book added!" : "⚠️ Failed to add book.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void ButtonUpdateBook_Click(object? sender, EventArgs e)
        {
            string bookId = textBoxISBN.Text.Trim();
            string title = textBoxTitle.Text.Trim();
            string author = textBoxAuthor.Text.Trim();
            string genre = textBoxGenre.Text.Trim();
            string? availability = comboBoxAvailability.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre) ||
                (availability != "available" && availability != "unavailable"))
            {
                MessageBox.Show("⚠️ Please fill all fields correctly.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = @"UPDATE Book SET title = @title, author = @auth, genre = @genre, 
                               availabilityStatus = @avail WHERE isbn = @isbn";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@auth", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@avail", availability);
                cmd.Parameters.AddWithValue("@isbn", bookId);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "✅ Book updated!" : "⚠️ Failed to update book.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void ButtonDeleteBook_Click(object? sender, EventArgs e)
        {
            string bookId = textBoxISBN.Text.Trim();

            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("⚠️ Please provide the ISBN of the book to delete.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = @"DELETE FROM Book WHERE isbn = @isbn";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@isbn", bookId);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "✅ Book deleted!" : "⚠️ Failed to delete book.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }

        private void ButtonSelectBooks_Click(object? sender, EventArgs e)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = "SELECT * FROM Book";
                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                var dt = new System.Data.DataTable();
                dt.Load(reader);
                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading books: " + ex.Message);
            }
        }

        private void ButtonViewUsers_Click(object? sender, EventArgs e)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = "SELECT id, username FROM Users";
                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                var dt = new System.Data.DataTable();
                dt.Load(reader);
                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading users: " + ex.Message);
            }
        }

        private void ButtonClearUsers_Click(object? sender, EventArgs e)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = "DELETE FROM Users";
                using var cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"🧹 {rows} user(s) deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error clearing users: " + ex.Message);
            }
        }

        private void ButtonClearBooks_Click(object? sender, EventArgs e)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();
                string sql = "DELETE FROM Book";
                using var cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"🧹 {rows} book(s) deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error clearing books: " + ex.Message);
            }
        }

        private void ButtonBorrowBook_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxBorrowMemberId.Text, out int memberId) ||
                !int.TryParse(textBoxBorrowBookId.Text, out int bookId))
            {
                MessageBox.Show("⚠️ Please enter valid Member ID and Book ID.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();

                // Validate member exists
                string checkMemberSql = "SELECT COUNT(*) FROM Member WHERE member_id = @memberId";
                using var checkMemberCmd = new MySqlCommand(checkMemberSql, conn);
                checkMemberCmd.Parameters.AddWithValue("@memberId", memberId);
                int memberExists = Convert.ToInt32(checkMemberCmd.ExecuteScalar());
                if (memberExists == 0)
                {
                    MessageBox.Show("❌ Member ID does not exist.");
                    return;
                }

                // Validate book exists and available
                string checkBookSql = "SELECT availabilityStatus FROM Book WHERE book_id = @bookId";
                using var checkBookCmd = new MySqlCommand(checkBookSql, conn);
                checkBookCmd.Parameters.AddWithValue("@bookId", bookId);
                var availability = checkBookCmd.ExecuteScalar()?.ToString();
                if (availability != "available")
                {
                    MessageBox.Show("❌ Book is not available for borrowing.");
                    return;
                }

                // Insert transaction record
                string insertTransactionSql = @"
                    INSERT INTO TransactionRecord (member_id, book_id, librarian_id, transactionDate, transaction_type, status)
                    VALUES (@memberId, @bookId, @librarianId, NOW(), 'borrow', 'active')";
                using var insertTransactionCmd = new MySqlCommand(insertTransactionSql, conn);
                insertTransactionCmd.Parameters.AddWithValue("@memberId", memberId);
                insertTransactionCmd.Parameters.AddWithValue("@bookId", bookId);
                insertTransactionCmd.Parameters.AddWithValue("@librarianId", 1);
                insertTransactionCmd.ExecuteNonQuery();

                long transactionId = insertTransactionCmd.LastInsertedId;

                // Insert borrow record
                string insertBorrowSql = @"
                    INSERT INTO Borrow (transaction_id, borrow_date, borrow_due_date)
                    VALUES (@transactionId, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 5 DAY))";
                using var insertBorrowCmd = new MySqlCommand(insertBorrowSql, conn);
                insertBorrowCmd.Parameters.AddWithValue("@transactionId", transactionId);
                insertBorrowCmd.ExecuteNonQuery();

                // Update book availability
                string updateBookSql = "UPDATE Book SET availabilityStatus = 'unavailable' WHERE book_id = @bookId";
                using var updateBookCmd = new MySqlCommand(updateBookSql, conn);
                updateBookCmd.Parameters.AddWithValue("@bookId", bookId);
                updateBookCmd.ExecuteNonQuery();

                MessageBox.Show("✅ Book borrowed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error during borrow: " + ex.Message);
            }
        }

        private void ButtonReturnBook_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textBoxReturnTransactionId.Text, out int transactionId))
            {
                MessageBox.Show("⚠️ Please enter valid Transaction ID.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();

                string insertReturnSql = @"INSERT INTO ReturnBook (transaction_id, return_date) VALUES (@transactionId, CURDATE())";
                using var insertReturnCmd = new MySqlCommand(insertReturnSql, conn);
                insertReturnCmd.Parameters.AddWithValue("@transactionId", transactionId);
                insertReturnCmd.ExecuteNonQuery();

                string getBookSql = "SELECT book_id FROM TransactionRecord WHERE transaction_id = @transactionId";
                using var getBookCmd = new MySqlCommand(getBookSql, conn);
                getBookCmd.Parameters.AddWithValue("@transactionId", transactionId);
                var bookIdObj = getBookCmd.ExecuteScalar();
                if (bookIdObj == null)
                {
                    MessageBox.Show("❌ Invalid Transaction ID.");
                    return;
                }

                int bookId = Convert.ToInt32(bookIdObj);

                string updateBookSql = "UPDATE Book SET availabilityStatus = 'available' WHERE book_id = @bookId";
                using var updateBookCmd = new MySqlCommand(updateBookSql, conn);
                updateBookCmd.Parameters.AddWithValue("@bookId", bookId);
                updateBookCmd.ExecuteNonQuery();

                MessageBox.Show("✅ Book returned successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error during return: " + ex.Message);
            }
        }

        // === New button event handlers for the four queries ===

        private void ButtonFinesByMember_Click(object? sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    m.member_id AS 'Member ID', 
                    m.name AS 'Member Name', 
                    SUM(f.amount) AS 'Total Fines' 
                FROM Fine f 
                JOIN TransactionRecord t ON f.transaction_id = t.transaction_id 
                JOIN Member m ON t.member_id = m.member_id 
                GROUP BY m.member_id, m.name";

            ExecuteAndBind(sql);
        }

        private void ButtonBooksBorrowed_Click(object? sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    b.book_id AS 'Book ID', 
                    b.title AS 'Title', 
                    m.name AS 'Member Name', 
                    t.transactionDate AS 'Borrowed Date', 
                    br.borrow_due_date AS 'Borrow Due Date' 
                FROM TransactionRecord t 
                JOIN Borrow br ON t.transaction_id = br.transaction_id 
                JOIN Book b ON t.book_id = b.book_id 
                JOIN Member m ON t.member_id = m.member_id 
                WHERE t.transaction_type = 'borrow' AND t.status = 'active'";

            ExecuteAndBind(sql);
        }

        private void ButtonOverdueBooks_Click(object? sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    b.book_id AS 'Book ID', 
                    b.title AS 'Title', 
                    m.name AS 'Member Name', 
                    t.transactionDate AS 'Borrowed Date', 
                    br.borrow_due_date AS 'Borrow Due Date' 
                FROM TransactionRecord t 
                JOIN Borrow br ON t.transaction_id = br.transaction_id 
                JOIN Book b ON t.book_id = b.book_id 
                JOIN Member m ON t.member_id = m.member_id 
                WHERE t.transaction_type = 'borrow' AND t.status = 'active' AND br.borrow_due_date < CURDATE()";

            ExecuteAndBind(sql);
        }

        private void ButtonMostBorrowedBooks_Click(object? sender, EventArgs e)
        {
            string sql = @"
                SELECT 
                    b.book_id AS 'Book ID', 
                    b.title AS 'Title', 
                    COUNT(t.transaction_id) AS 'Times Borrowed' 
                FROM TransactionRecord t 
                JOIN Book b ON t.book_id = b.book_id 
                WHERE t.transaction_type = 'borrow' 
                GROUP BY b.book_id, b.title 
                ORDER BY `Times Borrowed` DESC";  // Fixed quotes here

            ExecuteAndBind(sql);
        }

        private void ExecuteAndBind(string sql)
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                var dt = new System.Data.DataTable();
                dt.Load(reader);

                dataGridViewBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error executing query: " + ex.Message);
            }
        }

        private void buttonRegisterMemberForm_Click(object? sender, EventArgs e)
        {
            MemberRegisterForm form = new MemberRegisterForm();
            form.ShowDialog();
        }
    }
}
