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
        private IEnumerable<Author> authorList = new List<Author>();
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
            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
        }


        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();

            foreach (Book book in books)
            {
                lbBooks.Items.Add(book.Title + " [ " + book.BookCopies.Count() + " ]");

            }
        }
        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author.Name);
            }
            this.authorList = authors;
        }




        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Create_Book_Click(object sender, EventArgs e)
        {
            //Detta fungerar nu måste vi bara fundera på hur vi gerdom här värdena till en service.
            //Även hur vi konverterar en string till en Author (_BookAuthor)
            AddBookDialog abd = new AddBookDialog(authorList);
            if (abd.ShowDialog() == DialogResult.OK)
            {
                Testbox.Items.Add(abd._ISBN);
                Testbox.Items.Add(abd._Title);
                Testbox.Items.Add(abd._BookAuthor);
                Testbox.Items.Add(abd._Description);
                Testbox.Items.Add(abd._BookAuthor.Name);
                // something like his?
                Book b = new Book();
                b.ISBN = abd._ISBN;
                b.Title = abd._Title;
                //b.Author = abd._BookAuthor;
                b.Description = abd._Description;
                //nånting.Add(b);
            }
        }

        private void btn_Create_Author_Click(object sender, EventArgs e)
        {
            AddAuthorDialog aad = new AddAuthorDialog();
            if (aad.ShowDialog() == DialogResult.OK)
            {
                //fixa sp att den faktiskt lägger till en Author 
                Testbox.Items.Add(aad._Name);
            }
        }

        private void btn_Create_Member_Click(object sender, EventArgs e)
        {
            AddMemberDialog amd = new AddMemberDialog();
            if (amd.ShowDialog() == DialogResult.OK)
            {
                //Fixa så att den faktiskt lägger till en Memeber.
                Testbox.Items.Add(amd._Name);
                Testbox.Items.Add(amd._SSN);
            }
        }

        private void btn_Create_Loan_Click(object sender, EventArgs e)
        {
            MakeLoanDialog mld = new MakeLoanDialog();
            if (mld.ShowDialog() == DialogResult.OK)
            {
                Testbox.Items.Add(mld._TimeOfLoan.ToLongDateString() +" "+ mld._DueDate.ToLongDateString()); 

            }
        }
    }
}
