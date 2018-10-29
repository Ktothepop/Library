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
      this.bookCatalogueLabel = new System.Windows.Forms.Label();
      this.bookNameLabel = new System.Windows.Forms.Label();
      this.bookCopyQuantityLabel = new System.Windows.Forms.Label();
      this.lbAuthors = new System.Windows.Forms.ListBox();
      this.authorLabel = new System.Windows.Forms.Label();
      this.lbMembers = new System.Windows.Forms.ListBox();
      this.membersLabel = new System.Windows.Forms.Label();
      this.lbLoans = new System.Windows.Forms.ListBox();
      this.loanLabel = new System.Windows.Forms.Label();
      this.testBtn = new System.Windows.Forms.Button();
      this.testTextBox = new System.Windows.Forms.TextBox();
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
      // bookCatalogueLabel
      // 
      this.bookCatalogueLabel.AutoSize = true;
      this.bookCatalogueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bookCatalogueLabel.Location = new System.Drawing.Point(12, 17);
      this.bookCatalogueLabel.Name = "bookCatalogueLabel";
      this.bookCatalogueLabel.Size = new System.Drawing.Size(137, 20);
      this.bookCatalogueLabel.TabIndex = 1;
      this.bookCatalogueLabel.Text = "Book Catalogue";
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
      // authorLabel
      // 
      this.authorLabel.AutoSize = true;
      this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.authorLabel.Location = new System.Drawing.Point(456, 17);
      this.authorLabel.Name = "authorLabel";
      this.authorLabel.Size = new System.Drawing.Size(72, 20);
      this.authorLabel.TabIndex = 5;
      this.authorLabel.Text = "Authors";
      // 
      // lbMembers
      // 
      this.lbMembers.FormattingEnabled = true;
      this.lbMembers.Location = new System.Drawing.Point(16, 532);
      this.lbMembers.Name = "lbMembers";
      this.lbMembers.Size = new System.Drawing.Size(250, 277);
      this.lbMembers.TabIndex = 6;
      // 
      // membersLabel
      // 
      this.membersLabel.AutoSize = true;
      this.membersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.membersLabel.Location = new System.Drawing.Point(12, 487);
      this.membersLabel.Name = "membersLabel";
      this.membersLabel.Size = new System.Drawing.Size(82, 20);
      this.membersLabel.TabIndex = 7;
      this.membersLabel.Text = "Members";
      // 
      // lbLoans
      // 
      this.lbLoans.FormattingEnabled = true;
      this.lbLoans.Location = new System.Drawing.Point(460, 532);
      this.lbLoans.Name = "lbLoans";
      this.lbLoans.Size = new System.Drawing.Size(250, 277);
      this.lbLoans.TabIndex = 8;
      // 
      // loanLabel
      // 
      this.loanLabel.AutoSize = true;
      this.loanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loanLabel.Location = new System.Drawing.Point(460, 493);
      this.loanLabel.Name = "loanLabel";
      this.loanLabel.Size = new System.Drawing.Size(58, 20);
      this.loanLabel.TabIndex = 9;
      this.loanLabel.Text = "Loans";
      // 
      // testBtn
      // 
      this.testBtn.Location = new System.Drawing.Point(16, 353);
      this.testBtn.Name = "testBtn";
      this.testBtn.Size = new System.Drawing.Size(86, 23);
      this.testBtn.TabIndex = 10;
      this.testBtn.Text = "Test btn";
      this.testBtn.UseVisualStyleBackColor = true;
      this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
      // 
      // testTextBox
      // 
      this.testTextBox.Location = new System.Drawing.Point(13, 383);
      this.testTextBox.Name = "testTextBox";
      this.testTextBox.Size = new System.Drawing.Size(100, 20);
      this.testTextBox.TabIndex = 11;
      // 
      // LibraryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(872, 938);
      this.Controls.Add(this.testTextBox);
      this.Controls.Add(this.testBtn);
      this.Controls.Add(this.loanLabel);
      this.Controls.Add(this.lbLoans);
      this.Controls.Add(this.membersLabel);
      this.Controls.Add(this.lbMembers);
      this.Controls.Add(this.authorLabel);
      this.Controls.Add(this.lbAuthors);
      this.Controls.Add(this.bookCopyQuantityLabel);
      this.Controls.Add(this.bookNameLabel);
      this.Controls.Add(this.bookCatalogueLabel);
      this.Controls.Add(this.lbBooks);
      this.Name = "LibraryForm";
      this.Text = "Library";
      this.Load += new System.EventHandler(this.LibraryForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
    private System.Windows.Forms.Label bookCatalogueLabel;
    private System.Windows.Forms.Label bookNameLabel;
    private System.Windows.Forms.Label bookCopyQuantityLabel;
    private System.Windows.Forms.ListBox lbAuthors;
    private System.Windows.Forms.Label authorLabel;
    private System.Windows.Forms.ListBox lbMembers;
    private System.Windows.Forms.Label membersLabel;
    private System.Windows.Forms.ListBox lbLoans;
    private System.Windows.Forms.Label loanLabel;
    private System.Windows.Forms.Button testBtn;
    private System.Windows.Forms.TextBox testTextBox;
  }
}

