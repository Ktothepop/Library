using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService
    {
        AuthorRepository authorRepository;

        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }
        public void Add(Author a)
        {
            if (a != null)
                authorRepository.Add(a);
        }
    }

}
