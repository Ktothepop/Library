using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        public void Edit(Book b)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        //lagt till de metoderna som saknades.
        public void Add(Book a)
        {
            //Kontakta EF för en Create operation och spara det. Innan detta måste vi bekräfta att Book modellen är korrekt.
        }
        public void Remove(Book a)
        {
            // Samma här
        }
        public Book Find(int inID)
        {
            //Här returneras boken som hittas givetvis.
            return null;
        }
    }
}