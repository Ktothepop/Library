using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// CRUD methods for Loan object(s) extends IRepository<T,tid>
    /// </summary>
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <returns>
        /// Loan object(s)
        /// </returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }
        /// <summary>
        /// Updates data
        /// </summary>
        /// <param name="a">
        /// Loan object
        /// </param>
        public void Edit(Loan a)
        {
            context.SaveChanges();
        }
        /// <summary>
        /// Creates data
        /// </summary>
        /// <param name="a">
        /// Loan object
        /// </param>
        public void Add(Loan a)
        {
            context.Loans.Add(a);
            context.SaveChanges();

        }
        /// <summary>
        /// Deletes data
        /// </summary>
        /// <param name="a">
        /// Loan object
        /// </param>
        public void Remove(Loan a)
        {
            context.Loans.Remove(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Reads data 
        /// </summary>
        /// <param name="inID">
        /// Integer value
        /// </param>
        /// <returns>
        /// Loan object with ID value of param
        /// </returns>
        public Loan Find(int inID)
        {
            return context.Loans.Find(inID);
        }
    }
}
