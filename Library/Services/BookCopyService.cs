using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  /// <summary>
  /// This class handles the logic for the BookCopies in the GUI classes, connected to the BookCopyRepository
  /// Inherits the IService method to handle events in GUI in accordance with the Observable pattern
  /// </summary>
  class BookCopyService : IService
  {

    BookCopyRepository bookCopyRepository;


    public event EventHandler Updated;

    /// <summary>
    /// Constructor launches when class is initiated
    /// </summary>
    /// <param name="rFactory">Connection to Book Copy repository, creates its own through Factory pattern</param>
    public BookCopyService(RepositoryFactory rFactory)
    {
      this.bookCopyRepository = rFactory.CreateBookCopyRepository();
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
    /// Gets all the Book Copies
    /// </summary>
    /// <returns>IEnumerable of all BookCopies</returns>
    public IEnumerable<BookCopy> All()
    {
      return bookCopyRepository.All();
    }

    /// <summary>
    /// Adds a Book Copy
    /// </summary>
    /// <param name="bc">Book Copy to be added</param>
    public void Add(BookCopy bc)
    {
      if (bc != null) {
        bookCopyRepository.Add(bc);
        OnChanged(EventArgs.Empty);

      } else throw new ArgumentNullException();
    }
    public IEnumerable<BookCopy> GetAvailableBookCopies(IEnumerable<Loan> loans)
    {
      if (loans != null) {
        return from bc in bookCopyRepository.All()
               where bc.IsLoaned == false
               select bc;

      } else throw new ArgumentNullException();

    }
  }
}
