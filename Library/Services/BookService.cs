using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class BookService : IService
  {
    /// <summary>
    /// This class handles the logic for the Books in the GUI classes, connected to the BookRepository
    /// Inherits the IService method to handle events in GUI in accordance with the Observable pattern
    /// </summary>
    BookRepository bookRepository;

    public event EventHandler Updated;

    /// <summary>
    /// Constructor launches when class is initiated
    /// </summary>
    /// <param name="rFactory">Connection to Book repository, creates its own through Factory pattern</param>
    public BookService(RepositoryFactory rFactory)
    {
      this.bookRepository = rFactory.CreateBookRepository();
    }

    /// <summary>
    /// OnChanged event launched when changes is made 
    /// </summary>
    /// <param name="args">Event arguments, placeholder for future use</param>
    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }
    /// <summary>
    /// Gets all the Books
    /// </summary>
    /// <returns>IEnumerable of all Books</returns>
    public IEnumerable<Book> All()
    {
      return bookRepository.All();
    }

    /// <summary>
    /// Returns a single book found by book ID
    /// </summary>
    /// <param name="id">ID of book to be chosen</param>
    /// <returns>Returns the book which has the chosen ID param</returns>
    public Book GetBookById(int id)
    {

      try {
        return (from b in bookRepository.All()
                where b.Id == id
                select b).First();
      } catch (Exception ex) {
        if (ex is FormatException || ex is OverflowException) {
          throw ex;

        }
        return null;
      }

    }

    /// <summary>
    /// Gets all books that contains the title of param
    /// </summary>
    /// <param name="a">String to be compared to book title</param>
    /// <returns>All books that contains the in-param string</returns>
    public IEnumerable<Book> GetAllThatContainsInTitle(string a)
    {
      if (a != null) {
        return from b in bookRepository.All()
               where b.Title.Contains(a)
               select b;
      } else throw new ArgumentNullException();
    }

    /// <summary>
    /// Gets all books that have been written by specific author
    /// </summary>
    /// <param name="author">The author that have written the books</param>
    /// <returns>All books by chosen author</returns>
    public IEnumerable<Book> GetBooksByAuthor(Author author)
    {
      if (author != null) {
        return from b in bookRepository.All()
               where b.Author == author
               select b;
      } else throw new ArgumentNullException();
    }

    /// <summary>
    /// Adds a book and raises the OnChanged() event.
    /// </summary>
    /// <param name="b">The book to be added</param>
    public void Add(Book b)
    {
      if (b != null) {
        bookRepository.Add(b);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();

    }
    /// <summary>
    /// Removes a book and raises the OnChanged() event.
    /// </summary>
    /// <param name="b">Book to be removed</param>
    public void Remove(Book b)
    {
      if (b != null) {
        bookRepository.Remove(b);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();

    }
    /// <summary>
    /// The Edit method makes sure that the given Book object is saved to the database and raises the OnChanged() event.
    /// </summary>
    /// <param name="b">The edited book</param>
    public void Edit(Book b)
    {
      if (b != null) {
        bookRepository.Edit(b);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();

    }

  }
}
