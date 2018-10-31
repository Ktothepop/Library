using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// CRUD methods for Book object(s) extends IRepository<T,tid>
    /// </summary>
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <returns>
        /// Book object(s)
        /// </returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }
        /// <summary>
        /// Updates data
        /// </summary>
        /// <param name="b">
        /// Book object
        /// </param>
        public void Edit(Book b)
        {
            context.SaveChanges();
        }
        /// <summary>
        /// Creates data
        /// </summary>
        /// <param name="a">
        /// Book object
        /// </param>
        public void Add(Book a)
        {
            context.Books.Add(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes data
        /// </summary>
        /// <param name="a">
        /// Book object
        /// </param>
        public void Remove(Book a)
        {
            context.Books.Remove(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <param name="inID">
        /// Integer value
        /// </param>
        /// <returns>
        /// BookCopy object with ID value of param
        /// </returns>
        public Book Find(int inID)
        {
            return context.Books.Find(inID);
        }
    }
}