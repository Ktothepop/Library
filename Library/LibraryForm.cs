using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {

        BookService bookService;
        AuthorService authorService;
        MemberService memberService;
        LoanService loanService;
        BookCopyService bookCopyService;
        /// <summary>
        /// Constructor
        /// </summary>
        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
            ShowAllMembers(memberService.All());
            ShowActiveLoans(loanService.GetActiveLoans());

            //Observers
            bookService.Updated += OnChanged;
            authorService.Updated += OnChanged;
            memberService.Updated += OnChanged;
            loanService.Updated += OnChanged;
            bookCopyService.Updated += OnChanged;
            loanService.Updated += new EventHandler(OnChangedLoanState);
            rbActive.CheckedChanged += new EventHandler(OnChangedLoanState);
            rbReturned.CheckedChanged += new EventHandler(OnChangedLoanState);
            rbOverdue.CheckedChanged += new EventHandler(OnChangedLoanState);

        }

        /// <summary>
        /// Observer event
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void OnChanged(object sender, EventArgs args)
        {
            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
            ShowAllMembers(memberService.All());
        }
        /// <summary>
        /// Changes displayed Loan data, with radio buttons
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void OnChangedLoanState(object sender, EventArgs args)
        {

            if (rbActive.Checked)
            {
                ShowActiveLoans(loanService.GetActiveLoans());
            }
            else if (rbOverdue.Checked)
            {
                ShowOverdueLoans(loanService.GetOverdueLoans());
            }
            else if (rbReturned.Checked)
            {
                ShowReturnedLoans(loanService.GetReturnedLoans());

            }
        }
        /// <summary>
        /// Displays all Loan object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Loan(s)
        /// </param>
        private void ShowActiveLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);

            }
        }
        /// <summary>
        /// Displays all Loan object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Loan(s)
        /// </param>
        private void ShowReturnedLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);

            }
        }
        /// <summary>
        /// Displays all Loan object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Loan(s)
        /// </param>
        private void ShowOverdueLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);

            }
        }
        /// <summary>
        /// Displays all Book object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Book(s)
        /// </param>
        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }
        /// <summary>
        /// Displays all Author object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Author(s)
        /// </param>
        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author);
            }
        }
        /// <summary>
        /// Displays all Member object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Member(s)
        /// </param>
        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }
        /// <summary>
        /// Displays all Loan object(s)
        /// </summary>
        /// <param name="loans">
        /// List of Loan(s)
        /// </param>
        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);


            }
        }



        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Creates a Book object
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Create_Book_Click(object sender, EventArgs e)
        {
            AddBookDialog abd = new AddBookDialog(authorService.All());


            if (abd.ShowDialog() == DialogResult.OK)
            {
                if (abd._Title == "")
                {
                    MessageBox.Show("No book created: You must enter a title for the book", "Error: Book Title Error", MessageBoxButtons.OK);
                }
                else if (abd._ISBN == "")
                {
                    MessageBox.Show("No book created: You must enter the ISBN for the book", "Error: Book ISBN Error", MessageBoxButtons.OK);
                }
                else if (abd._BookAuthor == null)
                {
                    MessageBox.Show("No book created: You must choose an author for the book", "Error: Book Author Error", MessageBoxButtons.OK);
                }
                else
                {

                    Book d = new Book()
                    {
                        Title = abd._Title,
                        ISBN = abd._ISBN,
                        Author = abd._BookAuthor,
                        Description = abd._Description
                    };
                    bookService.Add(d);
                }
            }




        }
        /// <summary>
        /// Creates a Author object
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Create_Author_Click(object sender, EventArgs e)
        {
            AddAuthorDialog aad = new AddAuthorDialog();
            if (aad.ShowDialog() == DialogResult.OK)
            {
                if (aad._Name == "")
                {
                    MessageBox.Show("No author created: You must choose a name for an author", "Error: Author Name", MessageBoxButtons.OK);
                }
                else
                {
                    Author a = new Author()
                    {
                        Name = aad._Name
                    };
                    authorService.Add(a);
                }
            }
        }
        /// <summary>
        /// Creates a Member object
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Create_Member_Click(object sender, EventArgs e)
        {
            AddMemberDialog amd = new AddMemberDialog();
            if (amd.ShowDialog() == DialogResult.OK)
            {
                if (amd._Name == "")
                {
                    MessageBox.Show("No member created: You must choose a name for the member", "Error: Member Name", MessageBoxButtons.OK);
                }
                else if (amd._SSN == 0)
                {
                    MessageBox.Show("No member created: You must enter a correct user SSN, between:" + Int32.MinValue + " and " + Int32.MaxValue + " make sure to only use numbers", "Error: Member SSN", MessageBoxButtons.OK);
                }
                else
                {
                    Member m = new Member()
                    {
                        Name = amd._Name,
                        SSN = amd._SSN
                    };
                    memberService.Add(m);
                }

            }
        }
        /// <summary>
        /// Creates a Loan object
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Create_Loan_Click(object sender, EventArgs e)
        {
            MakeLoanDialog mld = new MakeLoanDialog(memberService.All(), bookCopyService.GetAvailableBookCopies(loanService.All()));
            if (mld.ShowDialog() == DialogResult.OK)
            {
                if (mld._LoanBookCopy == null)
                {
                    MessageBox.Show("No loan created: You must choose a book from the drop-down-list to loan", "Error: Book Copy", MessageBoxButtons.OK);
                }
                else if (mld._LoanMember == null)
                {
                    MessageBox.Show("No loan created: You must choose a member from the drop-down-list for the loan", "Error: Member", MessageBoxButtons.OK);
                }
                else
                {
                    loanService.CreateNewLoan(mld._TimeOfLoan, mld._DueDate, mld._LoanBookCopy, mld._LoanMember);
                }
            }
        }
        /// <summary>
        /// Exits application.
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Adds BookCopy object to selected Book
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Add_Book_Copy_Click(object sender, EventArgs e)
        {
            Book book = (Book)lbBooks.SelectedItem;
            if (book != null)
            {
                bookCopyService.Add(new BookCopy() { Book = book });

            }
            else { MessageBox.Show("You must select a book from the list to add a book copy to selected item", "Error: No item selected", MessageBoxButtons.OK); }
        }
        /// <summary>
        /// Edits selected Loan object property 'TimeOfReturn'
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Return_Loan_Click(object sender, EventArgs e)
        {
            try
            {
                Loan returnLoan = (Loan)lbLoans.SelectedItem;
                if (returnLoan.TimeOfReturn == null)
                {
                    int userFine = loanService.ReturnLoanCurrentTime(returnLoan);
                    if (userFine > 0)
                    {
                        MessageBox.Show(Convert.ToString(userFine) + " SEK must be payed", "A fine must be payed", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot return already returned loan", "Error: returning already returned loan", MessageBoxButtons.OK);
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("You must select a loan from the list to return it", "Error: No item selected", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Reads selected Members Loan object(s)
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Check_Loan_Click(object sender, EventArgs e)
        {
            Member m = (Member)lbMembers.SelectedItem;
            if (m == null)
            {
                MessageBox.Show("You must select a member from the list to view it", "Error: No item selected", MessageBoxButtons.OK);
            }
            else
            {
                string contain = "";
                if (m.Loans == null)
                {
                    contain = "No loans on this member";
                }
                else
                {
                    foreach (Loan l in m.Loans)
                    {
                        contain += "Loan: " + l + "\n\n";
                    }
                }

                MessageBox.Show(contain);
            }

        }
        /// <summary>
        /// Displays selected Authors Book(s)
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void btn_Check_Books_By_Author_Click(object sender, EventArgs e)
        {
            Author a = (Author)lbAuthors.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("You must select an author from the list to view it", "Error: No item selected", MessageBoxButtons.OK);
            }
            else
            {
                string contain = "";
                if (a.Books.Count() == 0)
                {
                    contain = "No books by this author";
                }
                else
                {
                    foreach (Book l in a.Books)
                    {
                        contain += l + "\n";
                    }
                }
                MessageBox.Show(contain);

            }
        }
        /// <summary>
        /// Edits selected Loan object
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void Btn_Edit_TimeOfLoan_Click(object sender, EventArgs e)
        {
            Loan editLoan = (Loan)lbLoans.SelectedItem;
            if (editLoan == null)
            {
                MessageBox.Show("You must select a loan from the list to edit", "Error: No item selected", MessageBoxButtons.OK);
            }
            else
            {
                dateTimePickerEditLoan.Format = DateTimePickerFormat.Short;
                editLoan.TimeOfLoan = dateTimePickerEditLoan.Value;
                editLoan.DueDate = dateTimePickerEditLoan.Value.AddDays(15);
                loanService.EditLoan(editLoan);

            }
        }
    }
}
