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
  /// This class handles the logic for the Authors in the GUI classes, connected to the AuthorRepository
  /// Inherits the IService method to handle events in GUI in accordance with the Observable pattern
  /// </summary>
  class AuthorService : IService
  {
    AuthorRepository authorRepository;

    public event EventHandler Updated;

    /// <summary>
    /// Constructor launches when class is initiated
    /// </summary>
    /// <param name="rFactory">Connection to Book Copy repository, creates its own through Factory pattern</param>
    public AuthorService(RepositoryFactory rFactory)
    {
      this.authorRepository = rFactory.CreateAuthorRepository();
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
    /// Gets all the authors
    /// </summary>
    /// <returns>IEnumerable of all authors</returns>
    public IEnumerable<Author> All()
    {
      return authorRepository.All();
    }
    /// <summary>
    /// Adds and author
    /// </summary>
    /// <param name="a">The author to be added</param>
    public void Add(Author a)
    {
      if (a.Name != null && a != null) {
        authorRepository.Add(a);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();
    }
  }

}
