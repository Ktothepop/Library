using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService : IService
    {
        AuthorRepository authorRepository;

        public event EventHandler Updated;

        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        protected virtual void OnChanged(EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }
        public void Add(Author a)
        {
            if (a.Name != null && a != null)
            {
                authorRepository.Add(a);
                OnChanged(EventArgs.Empty);
            }
            else throw new ArgumentNullException();
        }
    }

}
