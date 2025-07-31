using System.Windows.Forms;
using System.Drawing;

namespace MyWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelAuthor;
        private Label labelGenre;
        private Label labelISBN;
        private Label labelAvailability;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxGenre;
        private TextBox textBoxISBN;
        private ComboBox comboBoxAvailability;
        private Button buttonTestConnection;
        private Button buttonAddBook;
        private Button buttonUpdateBook;
        private Button buttonDeleteBook;
        private Button buttonSelectBooks;
        private Button buttonViewUsers;
        private Button buttonClearBooks;
        private Button buttonClearUsers;
        private DataGridView dataGridViewBooks;

        private Label labelBorrowMemberId;
        private TextBox textBoxBorrowMemberId;
        private Label labelBorrowBookId;
        private TextBox textBoxBorrowBookId;
        private Button buttonBorrowBook;

        private Label labelReturnTransactionId;
        private TextBox textBoxReturnTransactionId;
        private Button buttonReturnBook;

        private Button buttonRegisterMemberForm;

        // === New buttons for queries ===
        private Button buttonFinesByMember;
        private Button buttonBooksBorrowed;
        private Button buttonOverdueBooks;
        private Button buttonMostBorrowedBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.labelAuthor = new Label();
            this.labelGenre = new Label();
            this.labelISBN = new Label();
            this.labelAvailability = new Label();
            this.textBoxTitle = new TextBox();
            this.textBoxAuthor = new TextBox();
            this.textBoxGenre = new TextBox();
            this.textBoxISBN = new TextBox();
            this.comboBoxAvailability = new ComboBox();
            this.buttonTestConnection = new Button();
            this.buttonAddBook = new Button();
            this.buttonUpdateBook = new Button();
            this.buttonDeleteBook = new Button();
            this.buttonSelectBooks = new Button();
            this.buttonViewUsers = new Button();
            this.buttonClearBooks = new Button();
            this.buttonClearUsers = new Button();
            this.dataGridViewBooks = new DataGridView();

            this.labelBorrowMemberId = new Label();
            this.textBoxBorrowMemberId = new TextBox();
            this.labelBorrowBookId = new Label();
            this.textBoxBorrowBookId = new TextBox();
            this.buttonBorrowBook = new Button();

            this.labelReturnTransactionId = new Label();
            this.textBoxReturnTransactionId = new TextBox();
            this.buttonReturnBook = new Button();

            this.buttonRegisterMemberForm = new Button();

            // === Initialize new buttons ===
            this.buttonFinesByMember = new Button();
            this.buttonBooksBorrowed = new Button();
            this.buttonOverdueBooks = new Button();
            this.buttonMostBorrowedBooks = new Button();

            // Labels
            this.labelTitle.Text = "Title";
            this.labelTitle.Location = new Point(20, 20);

            this.labelAuthor.Text = "Author";
            this.labelAuthor.Location = new Point(20, 60);

            this.labelGenre.Text = "Genre";
            this.labelGenre.Location = new Point(20, 100);

            this.labelISBN.Text = "ISBN";
            this.labelISBN.Location = new Point(20, 140);

            this.labelAvailability.Text = "Availability";
            this.labelAvailability.Location = new Point(20, 180);

            // Textboxes
            this.textBoxTitle.Location = new Point(120, 20);
            this.textBoxAuthor.Location = new Point(120, 60);
            this.textBoxGenre.Location = new Point(120, 100);
            this.textBoxISBN.Location = new Point(120, 140);

            // ComboBox Availability
            this.comboBoxAvailability.Location = new Point(120, 180);
            this.comboBoxAvailability.Items.AddRange(new object[] { "available", "unavailable" });
            this.comboBoxAvailability.DropDownStyle = ComboBoxStyle.DropDownList;

            // Buttons
            this.buttonAddBook.Location = new Point(20, 230);
            this.buttonAddBook.Size = new Size(150, 35);
            this.buttonAddBook.Text = "Add Book";

            this.buttonUpdateBook.Location = new Point(180, 230);
            this.buttonUpdateBook.Size = new Size(150, 35);
            this.buttonUpdateBook.Text = "Update Book";

            this.buttonDeleteBook.Location = new Point(340, 230);
            this.buttonDeleteBook.Size = new Size(150, 35);
            this.buttonDeleteBook.Text = "Delete Book";

            this.buttonSelectBooks.Location = new Point(20, 280);
            this.buttonSelectBooks.Size = new Size(150, 35);
            this.buttonSelectBooks.Text = "Select Books";

            this.buttonViewUsers.Location = new Point(180, 280);
            this.buttonViewUsers.Size = new Size(150, 35);
            this.buttonViewUsers.Text = "View Users";

            this.buttonClearBooks.Location = new Point(340, 280);
            this.buttonClearBooks.Size = new Size(150, 35);
            this.buttonClearBooks.Text = "Clear All Books";

            this.buttonClearUsers.Location = new Point(20, 330);
            this.buttonClearUsers.Size = new Size(150, 35);
            this.buttonClearUsers.Text = "Clear All Users";

            // New button: Register New Member
            this.buttonRegisterMemberForm.Location = new Point(200, 330);
            this.buttonRegisterMemberForm.Size = new Size(200, 35);
            this.buttonRegisterMemberForm.Text = "Register New Member";

            // New query buttons setup
            this.buttonFinesByMember.Location = new Point(20, 380);
            this.buttonFinesByMember.Size = new Size(140, 30);
            this.buttonFinesByMember.Text = "Fines By Member";

            this.buttonBooksBorrowed.Location = new Point(180, 380);
            this.buttonBooksBorrowed.Size = new Size(140, 30);
            this.buttonBooksBorrowed.Text = "Books Borrowed";

            this.buttonOverdueBooks.Location = new Point(340, 380);
            this.buttonOverdueBooks.Size = new Size(140, 30);
            this.buttonOverdueBooks.Text = "Overdue Books";

            this.buttonMostBorrowedBooks.Location = new Point(500, 380);
            this.buttonMostBorrowedBooks.Size = new Size(140, 30);
            this.buttonMostBorrowedBooks.Text = "Most Borrowed";

            // DataGridView
            this.dataGridViewBooks.Location = new Point(20, 420);
            this.dataGridViewBooks.Size = new Size(620, 250);
            this.dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Borrow controls
            this.labelBorrowMemberId.Text = "Member ID (Borrow)";
            this.labelBorrowMemberId.Location = new Point(20, 690);

            this.textBoxBorrowMemberId.Location = new Point(150, 690);
            this.textBoxBorrowMemberId.Size = new Size(100, 23);

            this.labelBorrowBookId.Text = "Book ID (Borrow)";
            this.labelBorrowBookId.Location = new Point(270, 690);

            this.textBoxBorrowBookId.Location = new Point(370, 690);
            this.textBoxBorrowBookId.Size = new Size(100, 23);

            this.buttonBorrowBook.Text = "Borrow Book";
            this.buttonBorrowBook.Location = new Point(480, 685);
            this.buttonBorrowBook.Size = new Size(100, 30);

            // Return controls
            this.labelReturnTransactionId.Text = "Transaction ID (Return)";
            this.labelReturnTransactionId.Location = new Point(20, 730);

            this.textBoxReturnTransactionId.Location = new Point(150, 730);
            this.textBoxReturnTransactionId.Size = new Size(100, 23);

            this.buttonReturnBook.Text = "Return Book";
            this.buttonReturnBook.Location = new Point(270, 725);
            this.buttonReturnBook.Size = new Size(100, 30);

            // Add controls to the form
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAvailability);

            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.comboBoxAvailability);

            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonSelectBooks);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.buttonClearBooks);
            this.Controls.Add(this.buttonClearUsers);

            this.Controls.Add(this.buttonRegisterMemberForm);

            this.Controls.Add(this.buttonFinesByMember);
            this.Controls.Add(this.buttonBooksBorrowed);
            this.Controls.Add(this.buttonOverdueBooks);
            this.Controls.Add(this.buttonMostBorrowedBooks);

            this.Controls.Add(this.dataGridViewBooks);

            this.Controls.Add(this.labelBorrowMemberId);
            this.Controls.Add(this.textBoxBorrowMemberId);
            this.Controls.Add(this.labelBorrowBookId);
            this.Controls.Add(this.textBoxBorrowBookId);
            this.Controls.Add(this.buttonBorrowBook);

            this.Controls.Add(this.labelReturnTransactionId);
            this.Controls.Add(this.textBoxReturnTransactionId);
            this.Controls.Add(this.buttonReturnBook);

            this.ClientSize = new Size(670, 770);
            this.Name = "Form1";
            this.Text = "Library Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
