using System.Windows.Forms;

namespace MyWinFormsApp
{
    partial class MemberRegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelName;
        private Label labelAddress;
        private Label labelEmail;
        private Label labelRegDate;

        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerRegistrationDate;

        private Button buttonRegisterMember;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize the form components and layout.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelEmail = new Label();
            this.labelRegDate = new Label();

            this.textBoxName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxEmail = new TextBox();
            this.dateTimePickerRegistrationDate = new DateTimePicker();

            this.buttonRegisterMember = new Button();

            // Label Name
            this.labelName.Text = "Name";
            this.labelName.Location = new System.Drawing.Point(20, 20);
            this.labelName.AutoSize = true;

            // TextBox Name
            this.textBoxName.Location = new System.Drawing.Point(150, 20);
            this.textBoxName.Size = new System.Drawing.Size(200, 23);

            // Label Address
            this.labelAddress.Text = "Address";
            this.labelAddress.Location = new System.Drawing.Point(20, 60);
            this.labelAddress.AutoSize = true;

            // TextBox Address
            this.textBoxAddress.Location = new System.Drawing.Point(150, 60);
            this.textBoxAddress.Size = new System.Drawing.Size(200, 23);

            // Label Email
            this.labelEmail.Text = "Email";
            this.labelEmail.Location = new System.Drawing.Point(20, 100);
            this.labelEmail.AutoSize = true;

            // TextBox Email
            this.textBoxEmail.Location = new System.Drawing.Point(150, 100);
            this.textBoxEmail.Size = new System.Drawing.Size(200, 23);

            // Label Registration Date
            this.labelRegDate.Text = "Registration Date";
            this.labelRegDate.Location = new System.Drawing.Point(20, 140);
            this.labelRegDate.AutoSize = true;

            // DateTimePicker Registration Date
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(150, 140);
            this.dateTimePickerRegistrationDate.Format = DateTimePickerFormat.Short;

            // Button Register Member
            this.buttonRegisterMember.Text = "Register Member";
            this.buttonRegisterMember.Location = new System.Drawing.Point(150, 190);
            this.buttonRegisterMember.Size = new System.Drawing.Size(150, 30);

            // MemberRegisterForm
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelRegDate);
            this.Controls.Add(this.dateTimePickerRegistrationDate);
            this.Controls.Add(this.buttonRegisterMember);
            this.Name = "MemberRegisterForm";
            this.Text = "Register New Member";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
