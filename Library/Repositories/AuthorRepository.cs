using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// CRUD methods for Author object(s) extends IRepository<T,tid>
    /// </summary>
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <returns>
        /// Author object(s)
        /// </returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }
        /// <summary>
        /// Updates data
        /// </summary>
        /// <param name="a">
        /// Author object
        /// </param>
        public void Edit(Author a)
        {
            context.SaveChanges();
        }
        /// <summary>
        /// Creates data
        /// </summary>
        /// <param name="a">
        /// Author object
        /// </param>
        public void Add(Author a)
        {
            context.Authors.Add(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes data
        /// </summary>
        /// <param name="a">
        /// Author object
        /// </param>
        public void Remove(Author a)
        {
            context.Authors.Remove(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <param name="inID">
        /// Integer value
        /// </param>
        /// <returns>
        /// Author with the ID value of the param
        /// </returns>
        public Author Find(int inID)
        {
            return context.Authors.Find(inID);
        }
    }
}
