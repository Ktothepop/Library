using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// CRUD methods for Member object(s) extends IRepository<T,tid>
    /// </summary>
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }
        /// <summary>
        /// Reads data
        /// </summary>
        /// <returns>
        /// Member object(s)
        /// </returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        }
        /// <summary>
        /// Updates data
        /// </summary>
        /// <param name="a">
        /// Member object
        /// </param>
        public void Edit(Member a)
        {
            context.SaveChanges();
        }
        /// <summary>
        /// Creates data
        /// </summary>
        /// <param name="a">
        /// Member object
        /// </param>
        public void Add(Member a)
        {
            context.Members.Add(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Deletes data
        /// </summary>
        /// <param name="a">
        /// Member object
        /// </param>
        public void Remove(Member a)
        {
            context.Members.Remove(a);
            context.SaveChanges();
        }
        /// <summary>
        /// Reads data 
        /// </summary>
        /// <param name="inID">
        /// Integer value
        /// </param>
        /// <returns>
        /// Member object with ID value of param
        /// </returns>
        public Member Find(int inID)
        {
            return context.Members.Find(inID);
        }
    }
}
