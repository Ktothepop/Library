using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class BookService
  {
    /// <summary>
    /// service doesn't need a context but it needs a repository.
    /// </summary>
    BookRepository bookRepository;

    /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
    public BookService(RepositoryFactory rFactory)
    {
      this.bookRepository = rFactory.CreateBookRepository();
    }

    public IEnumerable<Book> All()
    {
      return bookRepository.All();
    }

    public Book GetBookById(int id)
        {
            return (from b in bookRepository.All()
                    where b.Id == id
                    select b).First();
        }

    public IEnumerable<Book> GetAllThatContainsInTitle(string a)
    {
      return from b in bookRepository.All()
             where b.Title.Contains(a)
             select b;
    }

    //Tar in author objekt och returnerar alla böcker som den skrivit
    public IEnumerable<Book> GetBooksByAuthor(Author author)
    {
      return from b in bookRepository.All()
             where b.Author == author
             select b;
    }

    

    //Adds the book copy to the book
    public void BookCopyAdded(Book b, BookCopy bc)
    {
      if (b != null && bc != null) {
        b.BookCopies.Add(bc);
        bookRepository.Edit(b);
      }

    }

    public void Add(Book b)
    {
      if (b != null)
        bookRepository.Add(b);
    }
    public void Remove(Book b)
    {
      if (b != null)
        bookRepository.Remove(b);
    }
    /// <summary>
    /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
    /// </summary>
    /// <param name="b"></param>
    public void Edit(Book b)
    {
      if (b != null)
        bookRepository.Edit(b);
      // TODO: Raise the Updated event.
    }

  }
}
