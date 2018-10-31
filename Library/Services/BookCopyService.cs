using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class BookCopyService
  {

    BookCopyRepository bookCopyRepository;

    public BookCopyService(RepositoryFactory rFactory)
    {
      this.bookCopyRepository = rFactory.CreateBookCopyRepository();
    }
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }
        public void Add(BookCopy bc)
        {
            if (bc != null)
                bookCopyRepository.Add(bc);
        }
    }
}
