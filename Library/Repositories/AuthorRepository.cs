using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
  public class AuthorRepository : IRepository<Author, int>
  {
    LibraryContext context;

    public AuthorRepository(LibraryContext c)
    {
      this.context = c;
    }

    //Samtliga funktioner här ska utnyttja Linq
    //ser ut såhär, frågan är om man gör en kontroll här eller tidigare? Borde kanske alltid kontrolleras?
    public IEnumerable<Author> All()
    {
      return context.Authors;
    }
    public void Edit(Author a)
    {
      context.SaveChanges();
    }
    public void Add(Author a)
    {
      context.Authors.Add(a);
      context.SaveChanges();
    }
    public void Remove(Author a)
    {
      context.Authors.Remove(a);
      context.SaveChanges();
    }
    public Author Find(int inID)
    {
      return context.Authors.Find(inID);
    }
  }
}
