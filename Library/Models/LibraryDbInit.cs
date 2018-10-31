using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
  /// <summary>
  /// Database strategy is chosen as the base class to LibraryDbInit.
  /// Creating dummy data in seed 
  /// Deriving from DropCreateDatabaseAlways<LibraryContext> to create new DB on setup
  /// </summary>
  class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
  {
    protected override void Seed(LibraryContext context)
    {
      base.Seed(context);

      //AUTHORS:

      Author auth1 = new Author() {
        Name = "Ernest Hernyways"
      };
      context.Authors.Add(auth1);
      Author auth2 = new Author() {
        Name = "Marc Tween"
      };
      context.Authors.Add(auth2);
      Author auth3 = new Author() {
        Name = "Stephen Queen"
      };
      context.Authors.Add(auth3);
      Author auth4 = new Author() {
        Name = "Virginia Cat"
      };
      context.Authors.Add(auth4);
      Author auth5 = new Author() {
        Name = "Jennifer Austen"
      };
      context.Authors.Add(auth5);

      //BOOKS:

      Book monteCristo = new Book() {
        Title = "The Count of Monte Cristo",
        ISBN = "0132-6153-2312-9559",
        Author = auth1
      };
      Book BarryPotter = new Book() {
        Title = "The Goblet of Robots",
        ISBN = "3222-6153-2312-9589",
        Author = auth1
      };
      Book book1 = new Book() {
        Title = "The Adventures of Hucklecherry Sinn",
        ISBN = "6432-6153-2312-9559",
        Author = auth4,
        Description = "This is the long description of the book"
      };
      Book book2 = new Book() {
        Title = "Scary Book About Scary Skeletons",
        ISBN = "6431-6153-2312-9559",
        Author = auth4
      };
      context.Books.Add(BarryPotter);
      context.Books.Add(monteCristo);
      context.Books.Add(book1);
      context.Books.Add(book2);

      //BOOK COPIES:
      BookCopy bc1 = new BookCopy() {
        Book = book1
      };
      context.BookCopies.Add(bc1);

      BookCopy bc2 = new BookCopy() {
        Book = book1
      };
      context.BookCopies.Add(bc2);

      BookCopy bc3 = new BookCopy() {
        Book = BarryPotter,
      };
      context.BookCopies.Add(bc3);



      //MEMBERS:
      Member Harry = new Member() {
        Name = "Harry Botter",
        SSN = 1337121955
      };
      context.Members.Add(Harry);
      Member Bulba = new Member() {
        Name = "Bulba Trulba",
        SSN = 123123132
      };
      context.Members.Add(Bulba);

      //LOANS:
      Loan lo = new Loan() {
        Member = Harry,
        BookCopy = bc3,
        TimeOfLoan = new DateTime(2017, 10, 10),
        DueDate = new DateTime(2017, 10, 25),
        TimeOfReturn = DateTime.Now
      };

      context.Loans.Add(lo);
      Loan l1 = new Loan() {
        Member = Bulba,
        BookCopy = bc1,
        TimeOfLoan = new DateTime(2018, 01, 01),
        DueDate = new DateTime(2018, 01, 20)
      };

      bc3.IsLoaned = true;
      bc1.IsLoaned = true;
      context.Loans.Add(l1);

      context.SaveChanges();
    }
  }
}
