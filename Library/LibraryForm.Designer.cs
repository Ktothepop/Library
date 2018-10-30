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
      this.SuspendLayout();
      // 
      // lbBooks
      // 
      this.lbBooks.FormattingEnabled = true;
      this.lbBooks.Location = new System.Drawing.Point(16, 69);
      this.lbBooks.Name = "lbBooks";
      this.lbBooks.Size = new System.Drawing.Size(250, 277);
      this.lbBooks.TabIndex = 0;
      // 
      // lb_Book_Catalogue
      // 
      this.lb_Book_Catalogue.AutoSize = true;
      this.lb_Book_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_Book_Catalogue.Location = new System.Drawing.Point(12, 17);
      this.lb_Book_Catalogue.Name = "lb_Book_Catalogue";
      this.lb_Book_Catalogue.Size = new System.Drawing.Size(137, 20);
      this.lb_Book_Catalogue.TabIndex = 1;
      this.lb_Book_Catalogue.Text = "Book Catalogue";
      // 
      // bookNameLabel
      // 
      this.bookNameLabel.AutoSize = true;
      this.bookNameLabel.Location = new System.Drawing.Point(13, 53);
      this.bookNameLabel.Name = "bookNameLabel";
      this.bookNameLabel.Size = new System.Drawing.Size(64, 13);
      this.bookNameLabel.TabIndex = 2;
      this.bookNameLabel.Text = "Book name:";
      // 
      // bookCopyQuantityLabel
      // 
      this.bookCopyQuantityLabel.AutoSize = true;
      this.bookCopyQuantityLabel.Location = new System.Drawing.Point(194, 53);
      this.bookCopyQuantityLabel.Name = "bookCopyQuantityLabel";
      this.bookCopyQuantityLabel.Size = new System.Drawing.Size(72, 13);
      this.bookCopyQuantityLabel.TabIndex = 3;
      this.bookCopyQuantityLabel.Text = "Available Qty:";
      // 
      // lbAuthors
      // 
      this.lbAuthors.FormattingEnabled = true;
      this.lbAuthors.Location = new System.Drawing.Point(460, 69);
      this.lbAuthors.Name = "lbAuthors";
      this.lbAuthors.Size = new System.Drawing.Size(250, 277);
      this.lbAuthors.TabIndex = 4;
      // 
      // lb_Authors
      // 
      this.lb_Authors.AutoSize = true;
      this.lb_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_Authors.Location = new System.Drawing.Point(456, 17);
      this.lb_Authors.Name = "lb_Authors";
      this.lb_Authors.Size = new System.Drawing.Size(72, 20);
      this.lb_Authors.TabIndex = 5;
      this.lb_Authors.Text = "Authors";
      // 
      // lbMembers
      // 
      this.lbMembers.FormattingEnabled = true;
      this.lbMembers.Location = new System.Drawing.Point(16, 532);
      this.lbMembers.Name = "lbMembers";
      this.lbMembers.Size = new System.Drawing.Size(250, 277);
      this.lbMembers.TabIndex = 6;
      // 
      // lb_Members
      // 
      this.lb_Members.AutoSize = true;
      this.lb_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_Members.Location = new System.Drawing.Point(12, 487);
      this.lb_Members.Name = "lb_Members";
      this.lb_Members.Size = new System.Drawing.Size(82, 20);
      this.lb_Members.TabIndex = 7;
      this.lb_Members.Text = "Members";
      // 
      // lbLoans
      // 
      this.lbLoans.FormattingEnabled = true;
      this.lbLoans.Location = new System.Drawing.Point(460, 532);
      this.lbLoans.Name = "lbLoans";
      this.lbLoans.Size = new System.Drawing.Size(250, 277);
      this.lbLoans.TabIndex = 8;
      // 
      // lb_Loans
      // 
      this.lb_Loans.AutoSize = true;
      this.lb_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lb_Loans.Location = new System.Drawing.Point(456, 487);
      this.lb_Loans.Name = "lb_Loans";
      this.lb_Loans.Size = new System.Drawing.Size(58, 20);
      this.lb_Loans.TabIndex = 9;
      this.lb_Loans.Text = "Loans";
      // 
      // rbActive
      // 
      this.rbActive.AutoSize = true;
      this.rbActive.Location = new System.Drawing.Point(460, 509);
      this.rbActive.Name = "rbActive";
      this.rbActive.Size = new System.Drawing.Size(55, 17);
      this.rbActive.TabIndex = 12;
      this.rbActive.TabStop = true;
      this.rbActive.Text = "Active";
      this.rbActive.UseVisualStyleBackColor = true;
      // 
      // rbReturned
      // 
      this.rbReturned.AutoSize = true;
      this.rbReturned.Location = new System.Drawing.Point(547, 509);
      this.rbReturned.Name = "rbReturned";
      this.rbReturned.Size = new System.Drawing.Size(69, 17);
      this.rbReturned.TabIndex = 13;
      this.rbReturned.TabStop = true;
      this.rbReturned.Text = "Returned";
      this.rbReturned.UseVisualStyleBackColor = true;
      // 
      // rbOverdue
      // 
      this.rbOverdue.AutoSize = true;
      this.rbOverdue.Location = new System.Drawing.Point(644, 509);
      this.rbOverdue.Name = "rbOverdue";
      this.rbOverdue.Size = new System.Drawing.Size(66, 17);
      this.rbOverdue.TabIndex = 14;
      this.rbOverdue.TabStop = true;
      this.rbOverdue.Text = "Overdue";
      this.rbOverdue.UseVisualStyleBackColor = true;
      // 
      // btn_Create_Book
      // 
      this.btn_Create_Book.Location = new System.Drawing.Point(16, 352);
      this.btn_Create_Book.Name = "btn_Create_Book";
      this.btn_Create_Book.Size = new System.Drawing.Size(100, 30);
      this.btn_Create_Book.TabIndex = 15;
      this.btn_Create_Book.Text = "Create Book";
      this.btn_Create_Book.UseVisualStyleBackColor = true;
      // 
      // btn_Add_Book_Copy
      // 
      this.btn_Add_Book_Copy.Location = new System.Drawing.Point(122, 352);
      this.btn_Add_Book_Copy.Name = "btn_Add_Book_Copy";
      this.btn_Add_Book_Copy.Size = new System.Drawing.Size(100, 30);
      this.btn_Add_Book_Copy.TabIndex = 16;
      this.btn_Add_Book_Copy.Text = "Add Book Copy";
      this.btn_Add_Book_Copy.UseVisualStyleBackColor = true;
      // 
      // btn_Create_Loan
      // 
      this.btn_Create_Loan.Location = new System.Drawing.Point(460, 815);
      this.btn_Create_Loan.Name = "btn_Create_Loan";
      this.btn_Create_Loan.Size = new System.Drawing.Size(100, 30);
      this.btn_Create_Loan.TabIndex = 17;
      this.btn_Create_Loan.Text = "Create Loan";
      this.btn_Create_Loan.UseVisualStyleBackColor = true;
      // 
      // btn_Create_Member
      // 
      this.btn_Create_Member.Location = new System.Drawing.Point(16, 815);
      this.btn_Create_Member.Name = "btn_Create_Member";
      this.btn_Create_Member.Size = new System.Drawing.Size(100, 30);
      this.btn_Create_Member.TabIndex = 18;
      this.btn_Create_Member.Text = "Create Member";
      this.btn_Create_Member.UseVisualStyleBackColor = true;
      // 
      // btn_Create_Author
      // 
      this.btn_Create_Author.Location = new System.Drawing.Point(460, 352);
      this.btn_Create_Author.Name = "btn_Create_Author";
      this.btn_Create_Author.Size = new System.Drawing.Size(100, 30);
      this.btn_Create_Author.TabIndex = 19;
      this.btn_Create_Author.Text = "Create Author";
      this.btn_Create_Author.UseVisualStyleBackColor = true;
      // 
      // Btn_Exit
      // 
      this.Btn_Exit.Location = new System.Drawing.Point(760, 896);
      this.Btn_Exit.Name = "Btn_Exit";
      this.Btn_Exit.Size = new System.Drawing.Size(100, 30);
      this.Btn_Exit.TabIndex = 20;
      this.Btn_Exit.Text = "Exit";
      this.Btn_Exit.UseVisualStyleBackColor = true;
      // 
      // btn_Return_Loan
      // 
      this.btn_Return_Loan.Location = new System.Drawing.Point(566, 815);
      this.btn_Return_Loan.Name = "btn_Return_Loan";
      this.btn_Return_Loan.Size = new System.Drawing.Size(100, 30);
      this.btn_Return_Loan.TabIndex = 21;
      this.btn_Return_Loan.Text = "Return Loan";
      this.btn_Return_Loan.UseVisualStyleBackColor = true;
      // 
      // Tb_Book_Name
      // 
      this.Tb_Book_Name.Location = new System.Drawing.Point(272, 85);
      this.Tb_Book_Name.Name = "Tb_Book_Name";
      this.Tb_Book_Name.Size = new System.Drawing.Size(117, 20);
      this.Tb_Book_Name.TabIndex = 22;
      // 
      // lb_Book_Id
      // 
      this.lb_Book_Id.AutoSize = true;
      this.lb_Book_Id.Location = new System.Drawing.Point(272, 69);
      this.lb_Book_Id.Name = "lb_Book_Id";
      this.lb_Book_Id.Size = new System.Drawing.Size(21, 13);
      this.lb_Book_Id.TabIndex = 23;
      this.lb_Book_Id.Text = "ID:";
      // 
      // lb_Book_Title
      // 
      this.lb_Book_Title.AutoSize = true;
      this.lb_Book_Title.Location = new System.Drawing.Point(272, 117);
      this.lb_Book_Title.Name = "lb_Book_Title";
      this.lb_Book_Title.Size = new System.Drawing.Size(30, 13);
      this.lb_Book_Title.TabIndex = 24;
      this.lb_Book_Title.Text = "Title:";
      // 
      // tb_Book_Title
      // 
      this.tb_Book_Title.Location = new System.Drawing.Point(272, 133);
      this.tb_Book_Title.Name = "tb_Book_Title";
      this.tb_Book_Title.Size = new System.Drawing.Size(117, 20);
      this.tb_Book_Title.TabIndex = 25;
      // 
      // lb_Book_ISBN
      // 
      this.lb_Book_ISBN.AutoSize = true;
      this.lb_Book_ISBN.Location = new System.Drawing.Point(272, 167);
      this.lb_Book_ISBN.Name = "lb_Book_ISBN";
      this.lb_Book_ISBN.Size = new System.Drawing.Size(35, 13);
      this.lb_Book_ISBN.TabIndex = 26;
      this.lb_Book_ISBN.Text = "ISBN:";
      // 
      // tb_Book_ISBN
      // 
      this.tb_Book_ISBN.Location = new System.Drawing.Point(272, 183);
      this.tb_Book_ISBN.Name = "tb_Book_ISBN";
      this.tb_Book_ISBN.Size = new System.Drawing.Size(117, 20);
      this.tb_Book_ISBN.TabIndex = 27;
      // 
      // lb_Book_Description
      // 
      this.lb_Book_Description.AutoSize = true;
      this.lb_Book_Description.Location = new System.Drawing.Point(272, 215);
      this.lb_Book_Description.Name = "lb_Book_Description";
      this.lb_Book_Description.Size = new System.Drawing.Size(63, 13);
      this.lb_Book_Description.TabIndex = 28;
      this.lb_Book_Description.Text = "Description:";
      // 
      // tb_Book_Description
      // 
      this.tb_Book_Description.Location = new System.Drawing.Point(272, 231);
      this.tb_Book_Description.Name = "tb_Book_Description";
      this.tb_Book_Description.Size = new System.Drawing.Size(117, 20);
      this.tb_Book_Description.TabIndex = 29;
      // 
      // btn_Save_Changes
      // 
      this.btn_Save_Changes.Location = new System.Drawing.Point(279, 259);
      this.btn_Save_Changes.Name = "btn_Save_Changes";
      this.btn_Save_Changes.Size = new System.Drawing.Size(100, 30);
      this.btn_Save_Changes.TabIndex = 31;
      this.btn_Save_Changes.Text = "Save Changes";
      this.btn_Save_Changes.UseVisualStyleBackColor = true;
      // 
      // LibraryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(872, 938);
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
  }
}

