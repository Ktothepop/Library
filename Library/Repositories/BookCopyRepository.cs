using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;


namespace Library.Repositories
{
  public class BookCopyRepository : IRepository<BookCopy, int>
  {
    LibraryContext context;

    public BookCopyRepository(LibraryContext c)
    {
      this.context = c;
    }

    //Samtliga funktioner här ska utnyttja Linq
    //ser ut såhär, frågan är om man gör en kontroll här eller tidigare? Borde kanske alltid kontrolleras?
    public IEnumerable<BookCopy> All()
    {
      return context.BookCopies;
    }
    public void Edit(BookCopy a)
    {
      context.SaveChanges();
    }
    public void Add(BookCopy a)
    {
      context.BookCopies.Add(a);
      context.SaveChanges();
    }
    public void Remove(BookCopy a)
    {
      context.BookCopies.Remove(a);
      context.SaveChanges();
    }
    public BookCopy Find(int inID)
    {
      return context.BookCopies.Find(inID);
    }
  }
}
