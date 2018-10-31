namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lb_Book_Catalogue = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookCopyQuantityLabel = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.lb_Authors = new System.Windows.Forms.Label();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.lb_Members = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.lb_Loans = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbOverdue = new System.Windows.Forms.RadioButton();
            this.btn_Create_Book = new System.Windows.Forms.Button();
            this.btn_Add_Book_Copy = new System.Windows.Forms.Button();
            this.btn_Create_Loan = new System.Windows.Forms.Button();
            this.btn_Create_Member = new System.Windows.Forms.Button();
            this.btn_Create_Author = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.btn_Return_Loan = new System.Windows.Forms.Button();
            this.btn_Check_Loan = new System.Windows.Forms.Button();
            this.btn_Check_Books_By_Author = new System.Windows.Forms.Button();
            this.Btn_Edit_TimeOfLoan = new System.Windows.Forms.Button();
            this.dateTimePickerEditLoan = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 16;
            this.lbBooks.Location = new System.Drawing.Point(21, 85);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(4);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(332, 340);
            this.lbBooks.TabIndex = 0;
            // 
            // lb_Book_Catalogue
            // 
            this.lb_Book_Catalogue.AutoSize = true;
            this.lb_Book_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Book_Catalogue.Location = new System.Drawing.Point(16, 21);
            this.lb_Book_Catalogue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Book_Catalogue.Name = "lb_Book_Catalogue";
            this.lb_Book_Catalogue.Size = new System.Drawing.Size(166, 25);
            this.lb_Book_Catalogue.TabIndex = 1;
            this.lb_Book_Catalogue.Text = "Book Catalogue";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(17, 65);
            this.bookNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(83, 17);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "Book name:";
            // 
            // bookCopyQuantityLabel
            // 
            this.bookCopyQuantityLabel.AutoSize = true;
            this.bookCopyQuantityLabel.Location = new System.Drawing.Point(259, 65);
            this.bookCopyQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookCopyQuantityLabel.Name = "bookCopyQuantityLabel";
            this.bookCopyQuantityLabel.Size = new System.Drawing.Size(95, 17);
            this.bookCopyQuantityLabel.TabIndex = 3;
            this.bookCopyQuantityLabel.Text = "Available Qty:";
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.ItemHeight = 16;
            this.lbAuthors.Location = new System.Drawing.Point(613, 85);
            this.lbAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(332, 340);
            this.lbAuthors.TabIndex = 4;
            // 
            // lb_Authors
            // 
            this.lb_Authors.AutoSize = true;
            this.lb_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Authors.Location = new System.Drawing.Point(608, 21);
            this.lb_Authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Authors.Name = "lb_Authors";
            this.lb_Authors.Size = new System.Drawing.Size(87, 25);
            this.lb_Authors.TabIndex = 5;
            this.lb_Authors.Text = "Authors";
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 16;
            this.lbMembers.Location = new System.Drawing.Point(20, 617);
            this.lbMembers.Margin = new System.Windows.Forms.Padding(4);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(332, 340);
            this.lbMembers.TabIndex = 6;
            // 
            // lb_Members
            // 
            this.lb_Members.AutoSize = true;
            this.lb_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Members.Location = new System.Drawing.Point(15, 561);
            this.lb_Members.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Members.Name = "lb_Members";
            this.lb_Members.Size = new System.Drawing.Size(101, 25);
            this.lb_Members.TabIndex = 7;
            this.lb_Members.Text = "Members";
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.ItemHeight = 16;
            this.lbLoans.Location = new System.Drawing.Point(517, 617);
            this.lbLoans.Margin = new System.Windows.Forms.Padding(4);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(554, 340);
            this.lbLoans.TabIndex = 8;
            // 
            // lb_Loans
            // 
            this.lb_Loans.AutoSize = true;
            this.lb_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loans.Location = new System.Drawing.Point(607, 561);
            this.lb_Loans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Loans.Name = "lb_Loans";
            this.lb_Loans.Size = new System.Drawing.Size(71, 25);
            this.lb_Loans.TabIndex = 9;
            this.lb_Loans.Text = "Loans";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(612, 588);
            this.rbActive.Margin = new System.Windows.Forms.Padding(4);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(67, 21);
            this.rbActive.TabIndex = 12;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Location = new System.Drawing.Point(728, 588);
            this.rbReturned.Margin = new System.Windows.Forms.Padding(4);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(88, 21);
            this.rbReturned.TabIndex = 13;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            // 
            // rbOverdue
            // 
            this.rbOverdue.AutoSize = true;
            this.rbOverdue.Location = new System.Drawing.Point(858, 588);
            this.rbOverdue.Margin = new System.Windows.Forms.Padding(4);
            this.rbOverdue.Name = "rbOverdue";
            this.rbOverdue.Size = new System.Drawing.Size(84, 21);
            this.rbOverdue.TabIndex = 14;
            this.rbOverdue.Text = "Overdue";
            this.rbOverdue.UseVisualStyleBackColor = true;
            // 
            // btn_Create_Book
            // 
            this.btn_Create_Book.Location = new System.Drawing.Point(21, 433);
            this.btn_Create_Book.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create_Book.Name = "btn_Create_Book";
            this.btn_Create_Book.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Book.TabIndex = 15;
            this.btn_Create_Book.Text = "Create Book";
            this.btn_Create_Book.UseVisualStyleBackColor = true;
            this.btn_Create_Book.Click += new System.EventHandler(this.btn_Create_Book_Click);
            // 
            // btn_Add_Book_Copy
            // 
            this.btn_Add_Book_Copy.Location = new System.Drawing.Point(163, 433);
            this.btn_Add_Book_Copy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_Book_Copy.Name = "btn_Add_Book_Copy";
            this.btn_Add_Book_Copy.Size = new System.Drawing.Size(133, 37);
            this.btn_Add_Book_Copy.TabIndex = 16;
            this.btn_Add_Book_Copy.Text = "Add Book Copy";
            this.btn_Add_Book_Copy.UseVisualStyleBackColor = true;
            this.btn_Add_Book_Copy.Click += new System.EventHandler(this.btn_Add_Book_Copy_Click);
            // 
            // btn_Create_Loan
            // 
            this.btn_Create_Loan.Location = new System.Drawing.Point(517, 965);
            this.btn_Create_Loan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create_Loan.Name = "btn_Create_Loan";
            this.btn_Create_Loan.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Loan.TabIndex = 17;
            this.btn_Create_Loan.Text = "Create Loan";
            this.btn_Create_Loan.UseVisualStyleBackColor = true;
            this.btn_Create_Loan.Click += new System.EventHandler(this.btn_Create_Loan_Click);
            // 
            // btn_Create_Member
            // 
            this.btn_Create_Member.Location = new System.Drawing.Point(20, 965);
            this.btn_Create_Member.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create_Member.Name = "btn_Create_Member";
            this.btn_Create_Member.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Member.TabIndex = 18;
            this.btn_Create_Member.Text = "Create Member";
            this.btn_Create_Member.UseVisualStyleBackColor = true;
            this.btn_Create_Member.Click += new System.EventHandler(this.btn_Create_Member_Click);
            // 
            // btn_Create_Author
            // 
            this.btn_Create_Author.Location = new System.Drawing.Point(613, 433);
            this.btn_Create_Author.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create_Author.Name = "btn_Create_Author";
            this.btn_Create_Author.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Author.TabIndex = 19;
            this.btn_Create_Author.Text = "Create Author";
            this.btn_Create_Author.UseVisualStyleBackColor = true;
            this.btn_Create_Author.Click += new System.EventHandler(this.btn_Create_Author_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(983, 1040);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(133, 37);
            this.Btn_Exit.TabIndex = 20;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_Return_Loan
            // 
            this.btn_Return_Loan.Location = new System.Drawing.Point(658, 965);
            this.btn_Return_Loan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Return_Loan.Name = "btn_Return_Loan";
            this.btn_Return_Loan.Size = new System.Drawing.Size(133, 37);
            this.btn_Return_Loan.TabIndex = 21;
            this.btn_Return_Loan.Text = "Return Loan";
            this.btn_Return_Loan.UseVisualStyleBackColor = true;
            this.btn_Return_Loan.Click += new System.EventHandler(this.btn_Return_Loan_Click);
            // 
            // btn_Check_Loan
            // 
            this.btn_Check_Loan.Location = new System.Drawing.Point(162, 965);
            this.btn_Check_Loan.Name = "btn_Check_Loan";
            this.btn_Check_Loan.Size = new System.Drawing.Size(106, 37);
            this.btn_Check_Loan.TabIndex = 32;
            this.btn_Check_Loan.Text = "Check Loans";
            this.btn_Check_Loan.UseVisualStyleBackColor = true;
            this.btn_Check_Loan.Click += new System.EventHandler(this.btn_Check_Loan_Click);
            // 
            // btn_Check_Books_By_Author
            // 
            this.btn_Check_Books_By_Author.Location = new System.Drawing.Point(754, 433);
            this.btn_Check_Books_By_Author.Name = "btn_Check_Books_By_Author";
            this.btn_Check_Books_By_Author.Size = new System.Drawing.Size(107, 37);
            this.btn_Check_Books_By_Author.TabIndex = 33;
            this.btn_Check_Books_By_Author.Text = "Check Books";
            this.btn_Check_Books_By_Author.UseVisualStyleBackColor = true;
            this.btn_Check_Books_By_Author.Click += new System.EventHandler(this.btn_Check_Books_By_Author_Click);
            // 
            // Btn_Edit_TimeOfLoan
            // 
            this.Btn_Edit_TimeOfLoan.Location = new System.Drawing.Point(798, 965);
            this.Btn_Edit_TimeOfLoan.Name = "Btn_Edit_TimeOfLoan";
            this.Btn_Edit_TimeOfLoan.Size = new System.Drawing.Size(98, 37);
            this.Btn_Edit_TimeOfLoan.TabIndex = 34;
            this.Btn_Edit_TimeOfLoan.Text = "Edit Loan";
            this.Btn_Edit_TimeOfLoan.UseVisualStyleBackColor = true;
            this.Btn_Edit_TimeOfLoan.Click += new System.EventHandler(this.Btn_Edit_TimeOfLoan_Click);
            // 
            // dateTimePickerEditLoan
            // 
            this.dateTimePickerEditLoan.Location = new System.Drawing.Point(902, 970);
            this.dateTimePickerEditLoan.Name = "dateTimePickerEditLoan";
            this.dateTimePickerEditLoan.Size = new System.Drawing.Size(184, 22);
            this.dateTimePickerEditLoan.TabIndex = 35;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1163, 1055);
            this.Controls.Add(this.dateTimePickerEditLoan);
            this.Controls.Add(this.Btn_Edit_TimeOfLoan);
            this.Controls.Add(this.btn_Check_Books_By_Author);
            this.Controls.Add(this.btn_Check_Loan);
            this.Controls.Add(this.btn_Return_Loan);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.btn_Create_Author);
            this.Controls.Add(this.btn_Create_Member);
            this.Controls.Add(this.btn_Create_Loan);
            this.Controls.Add(this.btn_Add_Book_Copy);
            this.Controls.Add(this.btn_Create_Book);
            this.Controls.Add(this.rbOverdue);
            this.Controls.Add(this.rbReturned);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.lb_Loans);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.lb_Members);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.lb_Authors);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.bookCopyQuantityLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.lb_Book_Catalogue);
            this.Controls.Add(this.lbBooks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
    private System.Windows.Forms.Label lb_Book_Catalogue;
    private System.Windows.Forms.Label bookNameLabel;
    private System.Windows.Forms.Label bookCopyQuantityLabel;
    private System.Windows.Forms.ListBox lbAuthors;
    private System.Windows.Forms.Label lb_Authors;
    private System.Windows.Forms.ListBox lbMembers;
    private System.Windows.Forms.Label lb_Members;
    private System.Windows.Forms.ListBox lbLoans;
    private System.Windows.Forms.Label lb_Loans;
    private System.Windows.Forms.RadioButton rbActive;
    private System.Windows.Forms.RadioButton rbReturned;
    private System.Windows.Forms.RadioButton rbOverdue;
    private System.Windows.Forms.Button btn_Create_Book;
    private System.Windows.Forms.Button btn_Add_Book_Copy;
    private System.Windows.Forms.Button btn_Create_Loan;
    private System.Windows.Forms.Button btn_Create_Member;
    private System.Windows.Forms.Button btn_Create_Author;
    private System.Windows.Forms.Button Btn_Exit;
    private System.Windows.Forms.Button btn_Return_Loan;
        private System.Windows.Forms.Button btn_Check_Loan;
        private System.Windows.Forms.Button btn_Check_Books_By_Author;
        private System.Windows.Forms.Button Btn_Edit_TimeOfLoan;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditLoan;
    }
}

