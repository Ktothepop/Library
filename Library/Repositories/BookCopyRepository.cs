using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;


namespace Library.Repositories
{
    /// <summary>
    /// CRUD methods for BookCopy object(s) extends IRepository<T,tid>
    /// </summary>
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Reads data
        /// </summary>
        /// <returns>
        /// BookCopy object(s)
        /// </returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }
        /// <summary>
        /// Updates data
        /// </summary>
        /// <param name="a">
        /// BookCopy object
        /// </param>
        public void Edit(BookCopy a)
        {
            context.SaveChanges();
        }
        /// <summary>
        /// Creates data
        /// </summary>
        /// <param name="a">
        /// BookCopy object
        /// </param>
        public void Add(BookCopy a)
        {
            context.BookCopies.Add(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes data
        /// </summary>
        /// <param name="a">
        /// BookCopy object
        /// </param>
        public void Remove(BookCopy a)
        {
            context.BookCopies.Remove(a);
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
        public BookCopy Find(int inID)
        {
            return context.BookCopies.Find(inID);
        }
    }
}
