namespace Library
{
    partial class AddBookDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxISBN = new System.Windows.Forms.TextBox();
      this.textBoxTitle = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.buttonAddBook = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxDescription = new System.Windows.Forms.TextBox();
      this.AuthorsBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 73);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ISBN:";
      // 
      // textBoxISBN
      // 
      this.textBoxISBN.Location = new System.Drawing.Point(31, 88);
      this.textBoxISBN.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxISBN.Name = "textBoxISBN";
      this.textBoxISBN.Size = new System.Drawing.Size(170, 20);
      this.textBoxISBN.TabIndex = 1;
      // 
      // textBoxTitle
      // 
      this.textBoxTitle.Location = new System.Drawing.Point(31, 45);
      this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxTitle.Name = "textBoxTitle";
      this.textBoxTitle.Size = new System.Drawing.Size(170, 20);
      this.textBoxTitle.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 26);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Title";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(28, 124);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Author";
      // 
      // buttonAddBook
      // 
      this.buttonAddBook.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAddBook.Location = new System.Drawing.Point(31, 229);
      this.buttonAddBook.Margin = new System.Windows.Forms.Padding(2);
      this.buttonAddBook.Name = "buttonAddBook";
      this.buttonAddBook.Size = new System.Drawing.Size(75, 19);
      this.buttonAddBook.TabIndex = 6;
      this.buttonAddBook.Text = "Add Book";
      this.buttonAddBook.UseVisualStyleBackColor = true;
      this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(28, 169);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Description";
      // 
      // textBoxDescription
      // 
      this.textBoxDescription.Location = new System.Drawing.Point(31, 184);
      this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.Size = new System.Drawing.Size(170, 20);
      this.textBoxDescription.TabIndex = 8;
      // 
      // AuthorsBox
      // 
      this.AuthorsBox.FormattingEnabled = true;
      this.AuthorsBox.Location = new System.Drawing.Point(31, 139);
      this.AuthorsBox.Margin = new System.Windows.Forms.Padding(2);
      this.AuthorsBox.Name = "AuthorsBox";
      this.AuthorsBox.Size = new System.Drawing.Size(170, 21);
      this.AuthorsBox.TabIndex = 9;
      // 
      // AddBookDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(262, 310);
      this.Controls.Add(this.AuthorsBox);
      this.Controls.Add(this.textBoxDescription);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonAddBook);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxTitle);
      this.Controls.Add(this.textBoxISBN);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddBookDialog";
      this.Text = "AddBookDialog";
      this.Load += new System.EventHandler(this.AddBookDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox AuthorsBox;
    }
}