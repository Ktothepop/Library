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
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        public event EventHandler Updated;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        protected virtual void OnChanged(EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        public Book GetBookById(int id)
        {

            try
            {
                return (from b in bookRepository.All()
                        where b.Id == id
                        select b).First();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    throw ex;
                    
                }
                return null;
            }

        }

        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            if (a != null)
            {
                return from b in bookRepository.All()
                       where b.Title.Contains(a)
                       select b;
            }
            else throw new ArgumentNullException();
        }

        //Tar in author objekt och returnerar alla böcker som den skrivit
        public IEnumerable<Book> GetBooksByAuthor(Author author)
        {
            if (author != null)
            {
                return from b in bookRepository.All()
                       where b.Author == author
                       select b;
            }
            else throw new ArgumentNullException();
        }



        //Adds the book copy to the book
        public void BookCopyAdded(Book b, BookCopy bc)
        {
            if (b != null && bc != null )
            {
                b.BookCopies.Add(bc);
                bookRepository.Edit(b);
                OnChanged(EventArgs.Empty);
            }
            else throw new ArgumentNullException();
        }

        public void Add(Book b)
        {
            if (b != null)
            {
                bookRepository.Add(b);
                OnChanged(EventArgs.Empty);
            }
            else throw new ArgumentNullException();

        }
        public void Remove(Book b)
        {
            if (b != null)
            {
                bookRepository.Remove(b);
                OnChanged(EventArgs.Empty);
            }
            else throw new ArgumentNullException();

        }
        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {
            if (b != null)
            {
                bookRepository.Edit(b);
                OnChanged(EventArgs.Empty);
            }
            else throw new ArgumentNullException();

        }

    }
}
