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

    //Observer event
    private void OnChanged(object sender, EventArgs args)
    {
      ShowAllBooks(bookService.All());
      ShowAllAuthors(authorService.All());
      ShowAllMembers(memberService.All());
    }
    private void OnChangedLoanState(object sender, EventArgs args)
    {

      if (rbActive.Checked) {
        ShowActiveLoans(loanService.GetActiveLoans());
      } else if (rbOverdue.Checked) {
        ShowOverdueLoans(loanService.GetOverdueLoans());
      } else if (rbReturned.Checked) {
        ShowReturnedLoans(loanService.GetReturnedLoans());

      }
    }
    private void ShowActiveLoans(IEnumerable<Loan> loans)
    {
      lbLoans.Items.Clear();
      foreach (Loan loan in loans) {
        lbLoans.Items.Add(loan);

      }
    }
    private void ShowReturnedLoans(IEnumerable<Loan> loans)
    {
      lbLoans.Items.Clear();
      foreach (Loan loan in loans) {
        lbLoans.Items.Add(loan);

      }
    }
    private void ShowOverdueLoans(IEnumerable<Loan> loans)
    {
      lbLoans.Items.Clear();
      foreach (Loan loan in loans) {
        lbLoans.Items.Add(loan);

      }
    }

    private void ShowAllBooks(IEnumerable<Book> books)
    {
      lbBooks.Items.Clear();
      foreach (Book book in books) {
        lbBooks.Items.Add(book);
      }
    }
    private void ShowAllAuthors(IEnumerable<Author> authors)
    {
      lbAuthors.Items.Clear();
      foreach (Author author in authors) {
        lbAuthors.Items.Add(author);
      }
    }
    private void ShowAllMembers(IEnumerable<Member> members)
    {
      lbMembers.Items.Clear();
      foreach (Member member in members) {
        lbMembers.Items.Add(member);
      }
    }
    private void ShowAllLoans(IEnumerable<Loan> loans)
    {
      lbLoans.Items.Clear();
      foreach (Loan loan in loans) {
        lbLoans.Items.Add(loan);


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
      if (abd.ShowDialog() == DialogResult.OK) {
        Book d = new Book() {
          Title = abd._Title,
          ISBN = abd._ISBN,
          Author = abd._BookAuthor,
          Description = abd._Description
        };
        bookService.Add(d);

      }
    }

    private void btn_Create_Author_Click(object sender, EventArgs e)
    {
      AddAuthorDialog aad = new AddAuthorDialog();
      if (aad.ShowDialog() == DialogResult.OK) {
        Author a = new Author() {
          Name = aad._Name
        };
        authorService.Add(a);
      }
    }

    private void btn_Create_Member_Click(object sender, EventArgs e)
    {
      AddMemberDialog amd = new AddMemberDialog();
      if (amd.ShowDialog() == DialogResult.OK) {
        Member m = new Member() {
          Name = amd._Name,
          SSN = amd._SSN
        };
        memberService.Add(m);
      }
    }

    private void btn_Create_Loan_Click(object sender, EventArgs e)
    {
      MakeLoanDialog mld = new MakeLoanDialog(memberService.All(), bookCopyService.GetAvailableBookCopies(loanService.All()));
      if (mld.ShowDialog() == DialogResult.OK) {

        loanService.CreateNewLoan(mld._TimeOfLoan, mld._DueDate, mld._LoanBookCopy, mld._LoanMember);
      }
    }

    private void Btn_Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btn_Add_Book_Copy_Click(object sender, EventArgs e)
    {
      Book book = (Book)lbBooks.SelectedItem;
      if(book != null) {
        bookCopyService.Add(new BookCopy() { Book = book });

      }else { MessageBox.Show("Select a book from the list to add a book copy to selected item", "Error: No item selected", MessageBoxButtons.OK); }
    }

    private void btn_Return_Loan_Click(object sender, EventArgs e)
    {
      Loan returnLoan = (Loan)lbLoans.SelectedItem;
      int userFine = loanService.ReturnLoanCurrentTime(returnLoan);
      if(userFine > 0) {
        MessageBox.Show(Convert.ToString(userFine) + " SEK must be payed", "A fine must be payed", MessageBoxButtons.OK);  

      }
    }

        private void btn_Check_Loan_Click(object sender, EventArgs e)
        {
            Member m = (Member)lbMembers.SelectedItem;
            string contain = "";
            foreach (Loan l in m.Loans)
            {
                contain += l + "\n";
            }
            MessageBox.Show(contain);
        }

        private void btn_Check_Books_By_Author_Click(object sender, EventArgs e)
        {
            Author a = (Author)lbAuthors.SelectedItem;
            string contain = "";
            foreach (Book l in a.Books)
            {
                contain += l + "\n";
            }
            MessageBox.Show(contain);
        }

        private void Btn_Edit_TimeOfLoan_Click(object sender, EventArgs e)
        {
            Loan editLoan = (Loan)lbLoans.SelectedItem;
            dateTimePickerEditLoan.Format = DateTimePickerFormat.Short;
            editLoan.TimeOfLoan = dateTimePickerEditLoan.Value;
            editLoan.DueDate = dateTimePickerEditLoan.Value.AddDays(15);
            loanService.EditLoan(editLoan);
            
        }
    }
}
