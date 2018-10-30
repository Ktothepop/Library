using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        //Samtliga funktioner här ska utnyttja Linq
        //ser ut såhär, frågan är om man gör en kontroll här eller tidigare? Borde kanske alltid kontrolleras?
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }
        public void Edit(Loan a)
        {
            context.SaveChanges();
        }
        public void Add(Loan a)
        {
            context.Loans.Add(a);
            context.SaveChanges();

        }
        public void Remove(Loan a)
        {
            context.Loans.Remove(a);
            context.SaveChanges();
        }
        public Loan Find(int inID)
        {
            return context.Loans.Find(inID);
        }
    }
}
