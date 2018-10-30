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
            this.Tb_Book_Name = new System.Windows.Forms.TextBox();
            this.lb_Book_Id = new System.Windows.Forms.Label();
            this.lb_Book_Title = new System.Windows.Forms.Label();
            this.tb_Book_Title = new System.Windows.Forms.TextBox();
            this.lb_Book_ISBN = new System.Windows.Forms.Label();
            this.tb_Book_ISBN = new System.Windows.Forms.TextBox();
            this.lb_Book_Description = new System.Windows.Forms.Label();
            this.tb_Book_Description = new System.Windows.Forms.TextBox();
            this.btn_Save_Changes = new System.Windows.Forms.Button();
            this.Testbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 16;
            this.lbBooks.Location = new System.Drawing.Point(21, 85);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lbAuthors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lbMembers.Location = new System.Drawing.Point(21, 655);
            this.lbMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(332, 340);
            this.lbMembers.TabIndex = 6;
            // 
            // lb_Members
            // 
            this.lb_Members.AutoSize = true;
            this.lb_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Members.Location = new System.Drawing.Point(16, 599);
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
            this.lbLoans.Location = new System.Drawing.Point(613, 655);
            this.lbLoans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(332, 340);
            this.lbLoans.TabIndex = 8;
            // 
            // lb_Loans
            // 
            this.lb_Loans.AutoSize = true;
            this.lb_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loans.Location = new System.Drawing.Point(608, 599);
            this.lb_Loans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Loans.Name = "lb_Loans";
            this.lb_Loans.Size = new System.Drawing.Size(71, 25);
            this.lb_Loans.TabIndex = 9;
            this.lb_Loans.Text = "Loans";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(613, 626);
            this.rbActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rbReturned.Location = new System.Drawing.Point(729, 626);
            this.rbReturned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(88, 21);
            this.rbReturned.TabIndex = 13;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            // 
            // rbOverdue
            // 
            this.rbOverdue.AutoSize = true;
            this.rbOverdue.Location = new System.Drawing.Point(859, 626);
            this.rbOverdue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOverdue.Name = "rbOverdue";
            this.rbOverdue.Size = new System.Drawing.Size(84, 21);
            this.rbOverdue.TabIndex = 14;
            this.rbOverdue.TabStop = true;
            this.rbOverdue.Text = "Overdue";
            this.rbOverdue.UseVisualStyleBackColor = true;
            // 
            // btn_Create_Book
            // 
            this.btn_Create_Book.Location = new System.Drawing.Point(21, 433);
            this.btn_Create_Book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Add_Book_Copy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add_Book_Copy.Name = "btn_Add_Book_Copy";
            this.btn_Add_Book_Copy.Size = new System.Drawing.Size(133, 37);
            this.btn_Add_Book_Copy.TabIndex = 16;
            this.btn_Add_Book_Copy.Text = "Add Book Copy";
            this.btn_Add_Book_Copy.UseVisualStyleBackColor = true;
            // 
            // btn_Create_Loan
            // 
            this.btn_Create_Loan.Location = new System.Drawing.Point(613, 1003);
            this.btn_Create_Loan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Create_Loan.Name = "btn_Create_Loan";
            this.btn_Create_Loan.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Loan.TabIndex = 17;
            this.btn_Create_Loan.Text = "Create Loan";
            this.btn_Create_Loan.UseVisualStyleBackColor = true;
            // 
            // btn_Create_Member
            // 
            this.btn_Create_Member.Location = new System.Drawing.Point(21, 1003);
            this.btn_Create_Member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Create_Member.Name = "btn_Create_Member";
            this.btn_Create_Member.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Member.TabIndex = 18;
            this.btn_Create_Member.Text = "Create Member";
            this.btn_Create_Member.UseVisualStyleBackColor = true;
            // 
            // btn_Create_Author
            // 
            this.btn_Create_Author.Location = new System.Drawing.Point(613, 433);
            this.btn_Create_Author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Create_Author.Name = "btn_Create_Author";
            this.btn_Create_Author.Size = new System.Drawing.Size(133, 37);
            this.btn_Create_Author.TabIndex = 19;
            this.btn_Create_Author.Text = "Create Author";
            this.btn_Create_Author.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(1013, 1103);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(133, 37);
            this.Btn_Exit.TabIndex = 20;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Return_Loan
            // 
            this.btn_Return_Loan.Location = new System.Drawing.Point(755, 1003);
            this.btn_Return_Loan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Return_Loan.Name = "btn_Return_Loan";
            this.btn_Return_Loan.Size = new System.Drawing.Size(133, 37);
            this.btn_Return_Loan.TabIndex = 21;
            this.btn_Return_Loan.Text = "Return Loan";
            this.btn_Return_Loan.UseVisualStyleBackColor = true;
            // 
            // Tb_Book_Name
            // 
            this.Tb_Book_Name.Location = new System.Drawing.Point(363, 105);
            this.Tb_Book_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Book_Name.Name = "Tb_Book_Name";
            this.Tb_Book_Name.Size = new System.Drawing.Size(155, 22);
            this.Tb_Book_Name.TabIndex = 22;
            // 
            // lb_Book_Id
            // 
            this.lb_Book_Id.AutoSize = true;
            this.lb_Book_Id.Location = new System.Drawing.Point(363, 85);
            this.lb_Book_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Book_Id.Name = "lb_Book_Id";
            this.lb_Book_Id.Size = new System.Drawing.Size(25, 17);
            this.lb_Book_Id.TabIndex = 23;
            this.lb_Book_Id.Text = "ID:";
            // 
            // lb_Book_Title
            // 
            this.lb_Book_Title.AutoSize = true;
            this.lb_Book_Title.Location = new System.Drawing.Point(363, 144);
            this.lb_Book_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Book_Title.Name = "lb_Book_Title";
            this.lb_Book_Title.Size = new System.Drawing.Size(39, 17);
            this.lb_Book_Title.TabIndex = 24;
            this.lb_Book_Title.Text = "Title:";
            // 
            // tb_Book_Title
            // 
            this.tb_Book_Title.Location = new System.Drawing.Point(363, 164);
            this.tb_Book_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Book_Title.Name = "tb_Book_Title";
            this.tb_Book_Title.Size = new System.Drawing.Size(155, 22);
            this.tb_Book_Title.TabIndex = 25;
            // 
            // lb_Book_ISBN
            // 
            this.lb_Book_ISBN.AutoSize = true;
            this.lb_Book_ISBN.Location = new System.Drawing.Point(363, 206);
            this.lb_Book_ISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Book_ISBN.Name = "lb_Book_ISBN";
            this.lb_Book_ISBN.Size = new System.Drawing.Size(43, 17);
            this.lb_Book_ISBN.TabIndex = 26;
            this.lb_Book_ISBN.Text = "ISBN:";
            // 
            // tb_Book_ISBN
            // 
            this.tb_Book_ISBN.Location = new System.Drawing.Point(363, 225);
            this.tb_Book_ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Book_ISBN.Name = "tb_Book_ISBN";
            this.tb_Book_ISBN.Size = new System.Drawing.Size(155, 22);
            this.tb_Book_ISBN.TabIndex = 27;
            // 
            // lb_Book_Description
            // 
            this.lb_Book_Description.AutoSize = true;
            this.lb_Book_Description.Location = new System.Drawing.Point(363, 265);
            this.lb_Book_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Book_Description.Name = "lb_Book_Description";
            this.lb_Book_Description.Size = new System.Drawing.Size(83, 17);
            this.lb_Book_Description.TabIndex = 28;
            this.lb_Book_Description.Text = "Description:";
            // 
            // tb_Book_Description
            // 
            this.tb_Book_Description.Location = new System.Drawing.Point(363, 284);
            this.tb_Book_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Book_Description.Name = "tb_Book_Description";
            this.tb_Book_Description.Size = new System.Drawing.Size(155, 22);
            this.tb_Book_Description.TabIndex = 29;
            // 
            // btn_Save_Changes
            // 
            this.btn_Save_Changes.Location = new System.Drawing.Point(372, 319);
            this.btn_Save_Changes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save_Changes.Name = "btn_Save_Changes";
            this.btn_Save_Changes.Size = new System.Drawing.Size(133, 37);
            this.btn_Save_Changes.TabIndex = 31;
            this.btn_Save_Changes.Text = "Save Changes";
            this.btn_Save_Changes.UseVisualStyleBackColor = true;
            // 
            // Testbox
            // 
            this.Testbox.FormattingEnabled = true;
            this.Testbox.ItemHeight = 16;
            this.Testbox.Location = new System.Drawing.Point(372, 386);
            this.Testbox.Name = "Testbox";
            this.Testbox.Size = new System.Drawing.Size(213, 228);
            this.Testbox.TabIndex = 32;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 1055);
            this.Controls.Add(this.Testbox);
            this.Controls.Add(this.btn_Save_Changes);
            this.Controls.Add(this.tb_Book_Description);
            this.Controls.Add(this.lb_Book_Description);
            this.Controls.Add(this.tb_Book_ISBN);
            this.Controls.Add(this.lb_Book_ISBN);
            this.Controls.Add(this.tb_Book_Title);
            this.Controls.Add(this.lb_Book_Title);
            this.Controls.Add(this.lb_Book_Id);
            this.Controls.Add(this.Tb_Book_Name);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    private System.Windows.Forms.TextBox Tb_Book_Name;
    private System.Windows.Forms.Label lb_Book_Id;
    private System.Windows.Forms.Label lb_Book_Title;
    private System.Windows.Forms.TextBox tb_Book_Title;
    private System.Windows.Forms.Label lb_Book_ISBN;
    private System.Windows.Forms.TextBox tb_Book_ISBN;
    private System.Windows.Forms.Label lb_Book_Description;
    private System.Windows.Forms.TextBox tb_Book_Description;
    private System.Windows.Forms.Button btn_Save_Changes;
        private System.Windows.Forms.ListBox Testbox;
    }
}

