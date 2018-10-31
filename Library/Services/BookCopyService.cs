using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class BookCopyService: IService
  {

    BookCopyRepository bookCopyRepository;


    public event EventHandler Updated;


    public BookCopyService(RepositoryFactory rFactory)
    {
      this.bookCopyRepository = rFactory.CreateBookCopyRepository();
    }

    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }

    public IEnumerable<BookCopy> All()
    {
      return bookCopyRepository.All();
    }
    public void Add(BookCopy bc)
    {
      if (bc != null) {
        bookCopyRepository.Add(bc);
        OnChanged(EventArgs.Empty);

      }
    }
    public IEnumerable<BookCopy> GetAvailableBookCopies(IEnumerable<Loan> loans)
    {
      return from bc in bookCopyRepository.All()
             where bc.IsLoaned == false
             select bc;
      
    }
  }
}
