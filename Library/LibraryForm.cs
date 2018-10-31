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
            ShowAllLoans(loanService.All());
        }


        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();

            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);

            }
            

        }
        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author.Name);
            }
        }
        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member.Name + "  |  " + member.SSN);
            }
        }
        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan.BookCopy.Book.Title + " | " + loan.Member.Name + " | " + loan.TimeOfLoan + " | " + loan.DueDate);

                
            }
        }
        


        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Create_Book_Click(object sender, EventArgs e)
        {
            //Detta fungerar nu måste vi bara fundera på hur vi gerdom här värdena till en service.
            //Även hur vi konverterar en string till en Author (_BookAuthor)
            AddBookDialog abd = new AddBookDialog(authorService.All());
            if (abd.ShowDialog() == DialogResult.OK)
            {
                Book d = new Book()
                {
                    Title = abd._Title,
                    ISBN = abd._ISBN,
                    Author = abd._BookAuthor,
                    Description = abd._Description
                }; 
                bookService.Add(d);
                ShowAllBooks(bookService.All());

            }
        }

        private void btn_Create_Author_Click(object sender, EventArgs e)
        {
            AddAuthorDialog aad = new AddAuthorDialog();
            if (aad.ShowDialog() == DialogResult.OK)
            {
                Author a = new Author()
                {
                    Name = aad._Name
                };
                authorService.Add(a);
                ShowAllAuthors(authorService.All());
            }
        }

        private void btn_Create_Member_Click(object sender, EventArgs e)
        {
            AddMemberDialog amd = new AddMemberDialog();
            if (amd.ShowDialog() == DialogResult.OK)
            {
                Member m = new Member()
                {
                    Name = amd._Name,
                    SSN = amd._SSN
                };
                memberService.Add(m);
                ShowAllMembers(memberService.All());
            }
        }

        private void btn_Create_Loan_Click(object sender, EventArgs e)
        {
            MakeLoanDialog mld = new MakeLoanDialog(memberService.All(), bookCopyService.All());
            if (mld.ShowDialog() == DialogResult.OK)
            {

                loanService.CreateNewLoan(mld._TimeOfLoan, mld._DueDate, mld._LoanBookCopy, mld._LoanMember);
                ShowAllLoans(loanService.All());
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Add_Book_Copy_Click(object sender, EventArgs e)
        {
            Book book = (Book)lbBooks.SelectedItem;
            bookCopyService.Add(new BookCopy() { Book = book});
            ShowAllBooks(bookService.All());
        }
    }
}
